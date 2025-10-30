# .NET Calculator Console Application

This folder contains a .NET console application demonstrating basic arithmetic operations using a separate Calculator library. The application executes all calculator operations sequentially with predefined test values.

## Project Structure

```
dotnet-console/
├── CalculatorSolution.sln          # Solution file containing both projects
├── CalculatorApp/                  # Console application project
│   ├── CalculatorApp.csproj        # Project file
│   └── Program.cs                  # Main application logic
├── Calculator.Library/             # Class library project
│   ├── Calculator.Library.csproj   # Project file
│   └── Calculator.cs               # Calculator implementation
└── README.md                       # This file
```

## Features

The Calculator library provides the following operations:
- **Addition**: Add two numbers
- **Subtraction**: Subtract second number from first
- **Multiplication**: Multiply two numbers
- **Division**: Divide first number by second (with zero-division protection)

## How to Run

1. Navigate to the dotnet-console directory:
   ```bash
   cd dotnet-console
   ```

2. Build the solution:
   ```bash
   dotnet build
   ```

3. Run the console application:
   ```bash
   cd CalculatorApp
   dotnet run
   ```

## Application Behavior

The console application runs in **sequential mode** and automatically demonstrates all calculator operations:

1. **No user input required** - the application uses predefined test values (a = 10, b = 5)
2. **Sequential execution** - performs all four operations in order:
   - Addition: 10 + 5 = 15
   - Subtraction: 10 - 5 = 5
   - Multiplication: 10 * 5 = 50
   - Division: 10 / 5 = 2
3. **Automatic completion** - displays results and terminates

## Example Output

```
=== Calculator Console Application ===
Demonstrating all calculator operations with sample values

Using test values: a = 10, b = 5

=== Addition ===
10 + 5 = 15

=== Subtraction ===
10 - 5 = 5

=== Multiplication ===
10 * 5 = 50

=== Division ===
10 / 5 = 2

All calculator operations completed successfully!
```

## Error Handling

The application includes error handling for:
- Division by zero (built into Calculator.Divide method)
- Unexpected exceptions during execution

## Requirements

- .NET 10.0 or later
- Windows, macOS, or Linux