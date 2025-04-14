namespace S1;

// Reservation.cs
public class Reservation
{
    public Vehicle Vehicle { get; set; }
    public string Customer { get; set; }
    public DateTime Date { get; set; }

    public Reservation(Vehicle vehicle, string customer)
    {
        Vehicle = vehicle;
        Customer = customer;
        Date = DateTime.Now;
    }
}