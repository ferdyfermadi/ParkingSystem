namespace ParkingSystem.Models;

public class Vehicle
{
    public string LicensePlate { get; set; }
    public string Type { get; set; }
    public string Color { get; set; }
    public DateTime CheckInTime { get; set; }

    public Vehicle(string licensePlate, string type, string color)
    {
        LicensePlate = licensePlate;
        Type = type;
        Color = color;
        CheckInTime = DateTime.Now;
    }
}