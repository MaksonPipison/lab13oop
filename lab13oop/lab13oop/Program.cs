using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter a number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            double result = Math.Sqrt(number);
            Console.WriteLine($"Square root of {number}: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input: not a valid number.");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Error: Entered number is negative.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
