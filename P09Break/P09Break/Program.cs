internal class Program
{
    private static void Main(string[] args)
    {
        int remainingHealth = 10;


        while (remainingHealth > 0) 
        {
            Console.WriteLine($"You have {remainingHealth} HP remaining, how much would you like to add/subtract?");
            string userInput = Console.ReadLine().ToUpper();
            if (userInput == "STOP")
            {
                break;
            }
            else
            {
                int changeHealth = Convert.ToInt32(userInput);
                remainingHealth = remainingHealth + changeHealth;
            }
        }
    Console.WriteLine("Game finished.");
    
    }
}