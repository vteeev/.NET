namespace S1;

public interface IReservable
{
    void Reserve(string customer);
    void CancelReservation();
    bool IsAvailable { get; set; }
}