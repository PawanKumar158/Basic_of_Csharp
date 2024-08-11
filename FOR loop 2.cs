using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        
        int factorial = 1;
        
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }
        
        Console.WriteLine("The factorial of " + number + " is: " + factorial);
    }
}
