using CalculatorLibrary;
using System;

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        // Example usage of Calculator methods
        int a = 10;
        int b = 5;

        int resultAdd = calculator.Add(a, b);
        int resultSubtract = calculator.Subtract(a, b);
        int resultMultiply = calculator.Multiply(a, b);

        Console.WriteLine($"Calculator Example:");
        Console.WriteLine($"-------------------");
        Console.WriteLine($"Addition of {a} and {b}: {resultAdd}");
        Console.WriteLine($"Subtraction of {a} and {b}: {resultSubtract}");
        Console.WriteLine($"Multiplication of {a} and {b}: {resultMultiply}");

        
        try
        {
            int resultDivide = calculator.Divide(a, b);
            Console.WriteLine($"Division of {a} by {b}: {resultDivide}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Division by zero error: {ex.Message}");
        }

        Console.ReadLine(); 
    }
}
