using CalculatorLib = Calculator.Library.Calculator;

Console.WriteLine("=== Calculator Console Application ===");
Console.WriteLine("Demonstrating all calculator operations with sample values");
Console.WriteLine();

var calculator = new CalculatorLib();

try
{
    // Test values
    double a = 10;
    double b = 5;
    
    Console.WriteLine($"Using test values: a = {a}, b = {b}");
    Console.WriteLine();

    // Perform all operations sequentially
    Console.WriteLine("=== Addition ===");
    double addResult = calculator.Add(a, b);
    Console.WriteLine($"{a} + {b} = {addResult}");
    Console.WriteLine();

    Console.WriteLine("=== Subtraction ===");
    double subtractResult = calculator.Subtract(a, b);
    Console.WriteLine($"{a} - {b} = {subtractResult}");
    Console.WriteLine();

    Console.WriteLine("=== Multiplication ===");
    double multiplyResult = calculator.Multiply(a, b);
    Console.WriteLine($"{a} * {b} = {multiplyResult}");
    Console.WriteLine();

    Console.WriteLine("=== Division ===");
    double divideResult = calculator.Divide(a, b);
    Console.WriteLine($"{a} / {b} = {divideResult}");
    Console.WriteLine();

    Console.WriteLine("All calculator operations completed successfully!");
}
catch (Exception ex)
{
    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
}
