namespace S1;

// RentalCompany.cs
public class RentalCompany
{
    private List<Vehicle> vehicles = new();
    private List<Reservation> reservations = new();

    public event Action<string>? OnNewReservation;

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void ReserveVehicle(int vehicleId, string customer)
    {
        var vehicle = vehicles.FirstOrDefault(v => v.Id == vehicleId);
        if (vehicle is IReservable reservable && vehicle.IsAvailable)
        {
            reservable.Reserve(customer);
            reservations.Add(new Reservation(vehicle, customer));
            OnNewReservation?.Invoke($"New reservation for {vehicle.Brand} {vehicle.Model} by {customer}");
        }
    }

    public void CancelReservation(int vehicleId)
    {
        var reservation = reservations.FirstOrDefault(r => r.Vehicle.Id == vehicleId);
        if (reservation != null && reservation.Vehicle is IReservable reservable)
        {
            reservable.CancelReservation();
            reservations.Remove(reservation);
        }
    }

    public List<Vehicle> GetAvailableVehicles()
    {
        return vehicles.GetAvailableVehicles();
    }

    public void ShowAllVehicles()
    {
        foreach (var v in vehicles)
            v.DisplayInfo();
    }
}
