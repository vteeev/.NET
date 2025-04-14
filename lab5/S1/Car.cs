using System;

namespace S1;

public class Car : Vehicle, IReservable
{
    public string BodyType { get; set; }
    private string? reservedBy;
    
    public new bool IsAvailable
    {
        get => base.IsAvailable;
        set => base.IsAvailable = value;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Car: {Brand} {Model} ({Year}), BodyType: {BodyType}, Available: {IsAvailable}");
    }

    public void Reserve(string customer)
    {
        if (base.IsAvailable)
        {
            base.IsAvailable = false;
            reservedBy = customer;
        }
    }

    public void CancelReservation()
    {
        base.IsAvailable = true;
        reservedBy = null;
    }
}