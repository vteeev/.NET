// See https://aka.ms/new-console-template for more information
using System;
using System.Threading;
using MyLibrary;
using Newtonsoft.Json;
using MyServices;
using Microsoft.Extensions.DependencyInjection;



public class Project
{
    public static void Main()
    {
        Console.WriteLine("Hello, World!");
        
        Console.Write("Podaj a:");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Podaj b:");
        int b = int.Parse(Console.ReadLine());
        
        Calculator obj = new Calculator();
        int wynik = obj.Add(a, b);
        Console.WriteLine($"Wynik dodawania: {wynik}");
        wynik = obj.Substraction(a, b);
        Console.WriteLine($"Wynik odejmowania: {wynik}");
        
        int sum = obj.Add(5, 3);
        var result = new { Operation = "Add", A = 5, B = 3, Result = sum };
        string jsonResult = JsonConvert.SerializeObject(result, Formatting.Indented);
        Console.WriteLine(jsonResult);
        
        //czesc 3
        var serviceProvider = new ServiceCollection()
            .AddSingleton<ILoggerService, ConsoleLogger>()
            .BuildServiceProvider();
        
        var logger = serviceProvider.GetService<ILoggerService>();
        logger.Log("Aplikacja uruchomiona.");
        
        int sum2 = obj.Add(10, 17);
        logger.Log($"Wynik dodawania: {sum2}");
    }
}