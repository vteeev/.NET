// RentalTests.cs
using NUnit.Framework;
using S1;

[TestFixture]
public class RentalTests
{
    [Test]
    public void CreateCar_CheckAttributes()
    {
        var car = new Car { Id = 1, Brand = "Toyota", Model = "Corolla", Year = 2020, BodyType = "Sedan" };
        Assert.AreEqual("Toyota", car.Brand);
    }

    [Test]
    public void ReserveAndCancelVehicle()
    {
        var car = new Car();
        car.Reserve("Jan");
        Assert.IsFalse(car.IsAvailable);
        car.CancelReservation();
        Assert.IsTrue(car.IsAvailable);
    }

    [Test]
    public void ExtensionMethodReturnsAvailableVehicles()
    {
        var list = new List<Vehicle>
        {
            new Car { IsAvailable = true },
            new Motorcycle { IsAvailable = false }
        };
        var result = list.GetAvailableVehicles();
        Assert.AreEqual(1, result.Count);
    }

    [Test]
    public void EventTriggeredOnReservation()
    {
        var company = new RentalCompany();
        string? message = null;
        company.OnNewReservation += (msg) => message = msg;

        var car = new Car { Id = 1, Brand = "Ford", Model = "Focus", Year = 2021, BodyType = "Hatchback" };
        company.AddVehicle(car);
        company.ReserveVehicle(1, "Anna");

        Assert.IsNotNull(message);
        Assert.IsTrue(message.Contains("Anna"));
    }
}