using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int number = AskNumberBetween(1, 3);
        if (number > 1 || number < 3)
        {
            Console.WriteLine($"You gave number {number}.");
        }
        int number2 = AskNumberBetween(41, 103);
        if (number2 > 41 || number2 < 103)
        {
            Console.WriteLine($"You gave number {number2}.");
        }

    }

    private static int AskNumberBetween(int min, int max)
    {
        int userInput;

        do
        {
            Console.WriteLine($"Please enter a number between {min} and {max}:");
            userInput = Convert.ToInt32(Console.ReadLine());
        } while (userInput < min || userInput > max);

        return userInput;
    }
}