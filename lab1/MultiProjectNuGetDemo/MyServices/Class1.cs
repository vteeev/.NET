namespace MyServices;

public interface ILoggerService
{
    void Log(string message);
}
//Utwórz implementację interfejsu, np. klasę ConsoleLogger:
public class ConsoleLogger : ILoggerService
{
    public void Log(string message)
    {
        Console.WriteLine($"[LOG]: {message}");
    }
}