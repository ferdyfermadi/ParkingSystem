namespace ParkingSystem.Models;

public class ParkingLot
{
    public int TotalLots { get; set; }
    public Dictionary<int, Vehicle> OccupiedLots { get; set; }

    public ParkingLot(int totalLots)
    {
        TotalLots = totalLots;
        OccupiedLots = new Dictionary<int, Vehicle>();
    }

    public void CreateParkingLot(int totalLots)
    {
        TotalLots = totalLots;
        OccupiedLots.Clear();
        Console.WriteLine($"Created a parking lot with {totalLots} slots");
    }

    public void ParkVehicle(Vehicle vehicle)
    {
        if (OccupiedLots.Count >= TotalLots)
        {
            Console.WriteLine("Sorry, parking lot is full");
            return;
        }

        int lotNumber = Enumerable.Range(1, TotalLots).FirstOrDefault(i => !OccupiedLots.ContainsKey(i));
        OccupiedLots[lotNumber] = vehicle;
        Console.WriteLine($"Allocated slot number: {lotNumber}");
    }

    public void LeaveVehicle(int slotNumber)
    {
        if (OccupiedLots.ContainsKey(slotNumber))
        {
            OccupiedLots.Remove(slotNumber);
            Console.WriteLine($"Slot number {slotNumber} is free");
        }
        else
        {
            Console.WriteLine("Slot number is not occupied");
        }
    }

    public void Status()
    {
        Console.WriteLine("Slot\tNo.\tType\tRegistration No\tColour");
        foreach (var slot in OccupiedLots)
        {
            var vehicle = slot.Value;
            Console.WriteLine($"{slot.Key}\t{vehicle.LicensePlate}\t{vehicle.Type}\t{vehicle.LicensePlate}\t{vehicle.Color}");
        }
    }

    public void TypeOfVehicles(string type)
    {
        var count = OccupiedLots.Values.Count(v => v.Type == type);
        Console.WriteLine(count);
    }

    public void RegistrationNumbersForVehiclesWithOddPlate()
    {
        var oddPlates = OccupiedLots.Values.Where(v => int.TryParse(v.LicensePlate.Last().ToString(), out int lastDigit) && lastDigit % 2 != 0)
            .Select(v => v.LicensePlate);
        Console.WriteLine(string.Join(", ", oddPlates));
    }

    public void RegistrationNumbersForVehiclesWithEvenPlate()
    {
        var evenPlates = OccupiedLots.Values.Where(v => int.TryParse(v.LicensePlate.Last().ToString(), out int lastDigit) && lastDigit % 2 == 0)
            .Select(v => v.LicensePlate);
        Console.WriteLine(string.Join(", ", evenPlates));
    }

    public void RegistrationNumbersForVehiclesWithColour(string color)
    {
        var plates = OccupiedLots.Values.Where(v => v.Color == color)
            .Select(v => v.LicensePlate);
        Console.WriteLine(string.Join(", ", plates));
    }

    public void SlotNumbersForVehiclesWithColour(string color)
    {
        var slots = OccupiedLots.Where(v => v.Value.Color == color)
            .Select(v => v.Key);
        Console.WriteLine(string.Join(", ", slots));
    }

    public void SlotNumberForRegistrationNumber(string licensePlate)
    {
        var slot = OccupiedLots.FirstOrDefault(v => v.Value.LicensePlate == licensePlate).Key;
        if (slot > 0)
        {
            Console.WriteLine(slot);
        }
        else
        {
            Console.WriteLine("Not found");
        }
    }
}
