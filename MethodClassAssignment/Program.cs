using System;

// Define a class named MathOperations
public class MathOperations
{
    // Define a void method named PerformOperation that takes two integers as parameters
    public void PerformOperation(int firstNumber, int secondNumber)
    {
        // Do a math operation on the first integer (for example, multiply by 2)
        int result = firstNumber * 2;

        // Display the second integer to the screen
        Console.WriteLine($"Result of the operation: {result}, Second Number: {secondNumber}");
    }
}

class Program
{
    static void Main()
    {
        // Instantiate the MathOperations class
        MathOperations mathObj = new MathOperations();

        // Call the PerformOperation method, passing in two numbers (5 and 10)
        mathObj.PerformOperation(5, 10);

        // Call the PerformOperation method, specifying the parameters by name
        mathObj.PerformOperation(firstNumber: 8, secondNumber: 15);
    }
}

