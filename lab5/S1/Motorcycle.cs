namespace S1;

public class Motorcycle : Vehicle, IReservable
{
    public int EngineCapacity { get; set; }
    private string? reservedBy;

    // Implementacja właściwości interfejsu
    public new bool IsAvailable
    {
        get => base.IsAvailable;
        set => base.IsAvailable = value;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Motorcycle: {Brand} {Model} ({Year}), Engine: {EngineCapacity}cc, Available: {IsAvailable}");
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