namespace S1;

public abstract class Vehicle
{
    public int Id { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public bool IsAvailable { get; set; } = true;

    public abstract void DisplayInfo();
}