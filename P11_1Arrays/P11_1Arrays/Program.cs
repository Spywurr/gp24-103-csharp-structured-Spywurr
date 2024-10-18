using System.Globalization;
using System.Security.Principal;




internal class Program
{
    private static void Main(string[] args)
    {
        int count = 0;

        Console.WriteLine("How many numbers do you want to give me?");
        int listLength = Convert.ToInt32(Console.ReadLine());
        List <int> numbers = new List<int>() {listLength};


        for (int i = 0; i < listLength; i++)
        {
            numbers = Console.ReadLine();
        }

        AskAgain:
        Console.WriteLine("What number are you looking for?");
        int numberToCheck = Convert.ToInt32(Console.ReadLine());

        
            if (numbers.Contains(numberToCheck))
            {
                count = count + 1;
                Console.WriteLine($"I found that number {count} times!");
                count = 0;
                goto AskAgain;
            
            }
            else
            {
            Console.WriteLine("I found that number 0 times!");
            goto AskAgain;
            }
    }
}