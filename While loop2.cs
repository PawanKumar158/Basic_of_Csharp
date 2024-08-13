using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        
        int reverse = 0;
        
        while (number != 0)
        {
            int remainder = number % 10;
            reverse = reverse * 10 + remainder;
            number /= 10;
        }
        
        Console.WriteLine("The reverse of the number is: " + reverse);
    }
}
