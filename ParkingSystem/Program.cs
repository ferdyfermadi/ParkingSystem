using ParkingSystem.Models;

class Program
{
    static void Main(string[] args)
    {
        var parkingLot = new ParkingLot(0);

        while (true)
        {
            var input = Console.ReadLine();
            var commands = input.Split(' ');

            switch (commands[0])
            {
                case "create_parking_lot":
                    var totalLots = int.Parse(commands[1]);
                    parkingLot.CreateParkingLot(totalLots);
                    break;

                case "park":
                    var licensePlate = commands[1];
                    var color = commands[2];
                    var type = commands[3];
                    var vehicle = new Vehicle(licensePlate, type, color);
                    parkingLot.ParkVehicle(vehicle);
                    break;

                case "leave":
                    var slotNumber = int.Parse(commands[1]);
                    parkingLot.LeaveVehicle(slotNumber);
                    break;

                case "status":
                    parkingLot.Status();
                    break;

                case "type_of_vehicles":
                    var vehicleType = commands[1];
                    parkingLot.TypeOfVehicles(vehicleType);
                    break;

                case "registration_numbers_for_vehicles_with_odd_plate":
                    parkingLot.RegistrationNumbersForVehiclesWithOddPlate();
                    break;

                case "registration_numbers_for_vehicles_with_even_plate":
                    parkingLot.RegistrationNumbersForVehiclesWithEvenPlate();
                    break;

                case "registration_numbers_for_vehicles_with_colour":
                    var vehicleColor = commands[1];
                    parkingLot.RegistrationNumbersForVehiclesWithColour(vehicleColor);
                    break;

                case "slot_numbers_for_vehicles_with_colour":
                    var colorForSlot = commands[1];
                    parkingLot.SlotNumbersForVehiclesWithColour(colorForSlot);
                    break;

                case "slot_number_for_registration_number":
                    var regNumber = commands[1];
                    parkingLot.SlotNumberForRegistrationNumber(regNumber);
                    break;

                case "exit":
                    return;

                default:
                    Console.WriteLine("Invalid command");
                    break;
            }
        }
    }
}
