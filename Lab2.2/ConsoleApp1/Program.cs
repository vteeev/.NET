using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Consol_APP;

namespace Consol_APP
{
    public class Program
    {

        static void Main(string[] args)
        {
            string text = "";

            Console.WriteLine("Wybierz sposób wprowadzenia tekstu:");
            Console.WriteLine("1 - Wprowadź tekst ręcznie");
            Console.WriteLine("2 - Wczytaj tekst z pliku");

            string wybor = Console.ReadLine();

            if (wybor == "1")
            {
                Console.WriteLine("Wprowadź tekst:");
                text = Console.ReadLine();
            }
            else if (wybor == "2")
            {
                Console.WriteLine("Podaj ścieżkę do pliku:");
                string sciezka = Console.ReadLine();
                try
                {
                    text = File.ReadAllText(sciezka);
                    Console.WriteLine("Plik został wczytany.");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Błąd odczytu pliku: {e.Message}");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Niepoprawny wybór.");
                return;
            }

            while (true)
            {
                Console.WriteLine("\n===== MENU ANALIZY TEKSTU =====");
                Console.WriteLine("1 - Liczba znaków (ze spacjami)");
                Console.WriteLine("2 - Liczba znaków (bez spacji)");
                Console.WriteLine("3 - Liczba liter w tekście");
                Console.WriteLine("4 - Liczba cyfr w tekście");
                Console.WriteLine("5 - Liczba znaków interpunkcyjnych");
                Console.WriteLine("6 - Liczba słów");
                Console.WriteLine("7 - Liczba unikalnych słów");
                Console.WriteLine("8 - Najczęściej występujące słowo");
                Console.WriteLine("9 - Średnia długość słowa");
                Console.WriteLine("10 - Najdłuższe i najkrótsze słowo");
                Console.WriteLine("11 - Liczba zdań");
                Console.WriteLine("12 - Średnia liczba słów na zdanie");
                Console.WriteLine("13 - Najdłuższe zdanie pod względem liczby słów");
                Console.WriteLine("0 - Zakończ program");
                Console.Write("\nWybierz opcję: ");

                string opcja = Console.ReadLine();
                switch (opcja)
                {
                    case "1":
                        Console.WriteLine($"Liczba znaków (ze spacjami): {TextAnalyzer.LiczbaZnakowZeSpacjami(text)}");
                        break;
                    case "2":
                        Console.WriteLine($"Liczba znaków (bez spacji): {TextAnalyzer.LiczbaZnakowBezSpacji(text)}");
                        break;
                    case "3":
                        Console.WriteLine($"Liczba liter: {TextAnalyzer.LiczbaLiter(text)}");
                        break;
                    case "4":
                        Console.WriteLine($"Liczba cyfr: {TextAnalyzer.LiczbaCyfr(text)}");
                        break;
                    case "5":
                        Console.WriteLine($"Liczba znaków interpunkcyjnych: {TextAnalyzer.LiczbaZnakowInterpunkcyjnych(text)}");
                        break;
                    case "6":
                        Console.WriteLine($"Liczba słów: {TextAnalyzer.LiczbaSlow(text)}");
                        break;
                    case "7":
                        Console.WriteLine($"Liczba unikalnych słów: {TextAnalyzer.LiczbaUnikalnychSlow(text)}");
                        break;
                    case "8":
                        Console.WriteLine($"Najczęściej występujące słowo: {TextAnalyzer.NajczesciejWystepujaceSlowo(text)}");
                        break;
                    case "9":
                        Console.WriteLine($"Średnia długość słowa: {TextAnalyzer.SredniaDlugoscSlow(text):F2}");
                        break;
                    case "10":
                        var (najkrotsze, najdluzsze) = TextAnalyzer.NajkrotszeNajdluzszeSlowo(text);
                        Console.WriteLine($"Najkrótsze słowo: {najkrotsze}, Najdłuższe słowo: {najdluzsze}");
                        break;
                    case "11":
                        Console.WriteLine($"Liczba zdań: {TextAnalyzer.LiczbaZdan(text)}");
                        break;
                    case "12":
                        Console.WriteLine($"Średnia liczba słów na zdanie: {TextAnalyzer.SredniaLiczbaSlowNaZdanie(text):F2}");
                        break;
                    case "13":
                        Console.WriteLine($"Najdłuższe zdanie ma {TextAnalyzer.NajdluzszeZdanie(text)} słów.");
                        break;
                    case "0":
                        Console.WriteLine("Zamykanie programu...");
                        return;
                    default:
                        Console.WriteLine("Niepoprawna opcja, wybierz ponownie.");
                        break;
                }
            }
        }
    }
}
