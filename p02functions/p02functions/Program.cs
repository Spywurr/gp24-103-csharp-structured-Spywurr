using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {

        bool playing = true;

        void Move(string direction, int steps)

        {
            for (int i = 0; i < steps; i++)
            {
                Console.WriteLine($"Move {direction}.");
            }

        }
          
        while (playing)
        {
            Console.WriteLine("Which direction would you like to take? turn (R)ight, turn (L)eft, (F)orward, (Q) to quit.");
            string direction = Console.ReadLine().ToUpper();
            
            if (direction == "Q")
            
            {
                Console.WriteLine("Thanks for playing!");
                playing = false;
                break;
            }

            else
                {
                Console.WriteLine("How many steps would you like to take?");
                string inputSteps = Console.ReadLine();
                int convertedSteps = Convert.ToInt32(inputSteps);
                {
                    if (direction == "R")
                    {
                        direction = "Right";
                        Move(direction, convertedSteps);
                    }
                    if (direction == "L")
                    {
                        direction = "Left";
                        Move(direction, convertedSteps);
                    }
                    if (direction == "F")
                    {
                        direction = "Forward";
                        Move(direction, convertedSteps);
                    }
                    
                }
            }

        }
    }
}