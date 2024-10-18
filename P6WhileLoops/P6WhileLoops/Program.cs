using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        int matches = 10;
        

        while (matches > 0)
        {

            AskAgain:
            Console.WriteLine($"There are {matches} matches left.");
            Console.WriteLine("How many matches would you like to draw?");
            int matchesDrawn = Convert.ToInt32(Console.ReadLine());
            if (matchesDrawn > matches)
            {
                Console.WriteLine($"You may only draw up to {matches} matches, try again!");
                goto AskAgain;
            }
            matches = matches - matchesDrawn;
        }
        if (matches == 0)
        {
            Console.WriteLine("Game over!");
        }
    }
}