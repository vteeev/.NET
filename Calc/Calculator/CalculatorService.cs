namespace Calculator;

public class CalculatorService
{
    public static void Calc(string operation)
    {
                    if (operation == "+" || operation == "-" || operation == "+" || operation == "/")
                    {
                        double calc;
                        Console.WriteLine("Write first number: ");
                        Console.Write(">");
                        string input1 = Console.ReadLine();
                        if (double.TryParse(input1, out double a))
                        {
                        }
                        else
                        {
                            Console.WriteLine("Nieprawidlowe dane!!!");
                        }

                        Console.WriteLine("Write secound number: ");
                        Console.Write(">");
                        string input2 = Console.ReadLine();
                        if (double.TryParse(input2, out double b))
                        {
                        }
                        else
                        {
                            Console.WriteLine("Nieprawidlowe dane!!!");
                        }

                        switch (operation)
                        {

                            case "+":
                                calc = CalcFunctions.add(a, b);
                                Console.WriteLine("Wynik: " + calc);
                                break;
                            case "-":
                                calc = CalcFunctions.Substract(a, b);
                                Console.WriteLine("Wynik: " + calc);
                                break;
                            case "*":
                                calc = CalcFunctions.Multiply(a, b);
                                Console.WriteLine("Wynik: " + calc);
                                break;
                            case "/":
                                if (b == 0)
                                {
                                    Console.WriteLine("Błąd: Nie można dzielić przez zero!");
                                    return;
                                }
                                else
                                {
                                    calc = CalcFunctions.Divide(a, b);
                                    Console.WriteLine("Wynik: " + calc);
                                    break;
                                }
                            default:
                                Console.WriteLine("Nieznana operacja!");
                                return;

                        }
                    }
    }

    public static void ScientificCalc(string inp2)
    {
                    
                    Calc(inp2);
                    if (inp2 == "^" || inp2 == "sqrt" || inp2 == "log")
                    {
                        double calc;
                        Console.WriteLine("Write number: ");
                        Console.Write(">");
                        string input = Console.ReadLine();
                        if (double.TryParse(input, out double a))
                        {
                        }
                        else
                        {
                            Console.WriteLine("Nieprawidlowe dane!!!");
                        }

                        switch (inp2)
                        {
                            case "^":
                                calc = ScientificCalculator.Power(a);
                                Console.WriteLine("Power: " + calc);
                                break;
                            case "sqrt":
                                calc = ScientificCalculator.Sqrt(a);
                                Console.WriteLine("Sqrt: " + calc);
                                break;
                            case "log":
                                calc = ScientificCalculator.Log(a);
                                Console.WriteLine("Log: " + calc);
                                break;
                        }
                    }
                    else if (inp2 == "sum" || inp2 == "minMax" || inp2 == "avg")
                    {
                        double calc;
                        Console.WriteLine("Write numbers: ");
                        Console.Write(">");
                        string input = Console.ReadLine();

                        switch (inp2)
                        {
                            case "sum":
                                calc = ScientificCalculator.MultiSum(input);
                                Console.WriteLine("Sum: " + calc);
                                break;
                            case "minMax":
                                double[] calc2 = ScientificCalculator.MinMax(input);
                                Console.WriteLine("Min: " + calc2[0] + ", Max: " + calc2[1]);
                                break;
                            case "avg":
                                calc = ScientificCalculator.Avg(input);
                                Console.WriteLine("AVG: " + calc);
                                break;
                        }
                    }
                    
    }
    public static void Run()
    {
        bool start = true;
        while (start)
        {
            Console.WriteLine("==================");
            Console.WriteLine("(1) Calculator");
            Console.WriteLine("(2) Scientific Calculator");
            Console.WriteLine("(0) Exit");
            Console.WriteLine("==================");
            Console.Write("Chosen operation: ");
            string type = Console.ReadLine();
            switch (type)
            {
                case "1":
                    Console.WriteLine("\nCalculator C#");
                    Console.WriteLine("Chose operation: +, -, *, /");
                    Console.Write("Chosen operation: ");
                    string inp = Console.ReadLine();
                    
                    Calc(inp);
                    break;
                case "2":
                    Console.WriteLine("\nScientificCalculator C#");
                    Console.WriteLine("Chose operation: +, -, *, /, sum, minMax, avg, ^, sqrt, log");
                    Console.Write("Chosen operation: ");
                    string inp2 = Console.ReadLine();
                    ScientificCalc(inp2);
                    break;
                case "0":
                    start = false;
                    break;
            }

        }
    }
}