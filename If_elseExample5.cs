using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a character: ");
        char ch = char.Parse(Console.ReadLine().ToLower());

        if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
        {
            Console.WriteLine("The character is a vowel.");
        }
        else
        {
            Console.WriteLine("The character is a consonant.");
        }
    }
}
