using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Enter the second number:");
        string input2 = Console.ReadLine();

        try
        {
            int number1 = Convert.ToInt32(input1);
            int number2 = Convert.ToInt32(input2);

            int result = Divide(number1, number2);
            Console.WriteLine($"The result of {number1} divided by {number2} is: {result}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: One or both of the inputs are not valid integers.");
            Console.WriteLine($"Detailed error message: {ex.Message}");
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Error: One or both numbers are outside the range of Int32 (-2,147,483,648 to 2,147,483,647).");
            Console.WriteLine($"Detailed error message: {ex.Message}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            Console.WriteLine($"Detailed error message: {ex.Message}");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Error: One of the inputs was null (no text was entered).");
            Console.WriteLine($"Detailed error message: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred.");
            Console.WriteLine($"Detailed error message: {ex.Message}");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static int Divide(int a, int b)
    {
        return a / b;
    }
}