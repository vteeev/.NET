namespace S1;

// VehicleExtensions.cs
public static class VehicleExtensions
{
    public static List<Vehicle> GetAvailableVehicles(this List<Vehicle> vehicles)
    {
        return vehicles.Where(v => v.IsAvailable).ToList();
    }
}
