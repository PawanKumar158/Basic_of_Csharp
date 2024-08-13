using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        
        int sum = 0;
        int i = 1;
        
        while (i <= n)
        {
            sum += i;
            i++;
        }
        
        Console.WriteLine("The sum of first " + n + " natural numbers is: " + sum);
    }
}
