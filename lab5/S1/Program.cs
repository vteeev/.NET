// Program.cs
using S1;

namespace S1
{
    public class Program
    {
        static void Main()
        {
            var rental = new RentalCompany();
            rental.OnNewReservation += msg => Console.WriteLine($"[EVENT] {msg}");

            rental.AddVehicle(new Car { Id = 1, Brand = "BMW", Model = "X5", Year = 2021, BodyType = "SUV" });
            rental.AddVehicle(new Motorcycle
                { Id = 2, Brand = "Yamaha", Model = "R1", Year = 2019, EngineCapacity = 1000 });

            Console.WriteLine("Available vehicles:");
            var available = rental.GetAvailableVehicles();
            available.ForEach(v => v.DisplayInfo());

            rental.ReserveVehicle(1, "John Doe");

            Console.WriteLine("\nAfter reservation:");
            rental.ShowAllVehicles();
        }
    }
}