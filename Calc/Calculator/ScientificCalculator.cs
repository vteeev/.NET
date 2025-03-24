namespace Calculator;

public class ScientificCalculator : CalcFunctions
{
    // NAUKOWY

    public static double Power(double a)
    {
        return Math.Pow(a, 2);
    }

    public static double Sqrt(double a)
    {
        return Math.Sqrt(a);
    }

    public static double Log(double a)
    {
        return Math.Log(a);
    }
    
    //Collections

    public static double MultiSum(string input)
    {
        string[] parts = input.Split(' ');
        double sum = 0;

        foreach (var part in parts)
        {
            if (double.TryParse(part, out double number))
            {
                sum += number;
            }
            else
            {
                Console.WriteLine($"Invalid number: {part}");
            }
        }

        return sum;
    }

    public static double Avg(string input)
    {
        string[] parts = input.Split(' ');
        double sum = 0;
        double count = 0;

        foreach (var part in parts)
        {
            if (double.TryParse(part, out double number))
            {
                sum += number;
                count++;
            }
        }

        // Avoid division by zero
        if (count == 0)
        {
            return 0;  // Or handle as appropriate
        }

        return sum / count;
    }



    public static double[] MinMax(string input)
    {
        string[] parts = input.Split(' ');
        double min = double.MaxValue, max = double.MinValue;

        foreach (var part in parts)
        {
            if (double.TryParse(part, out double number))
            {
                if (number <= min) min = number;
                if (number >= max) max = number;
            }
        }

        double[] tab ={ min, max };
        return tab;
    }
}