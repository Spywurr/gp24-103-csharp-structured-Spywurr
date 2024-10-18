internal class Program
{
    private static void Main(string[] args)
    {
        MyFunction();
        void MyFunction()
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine().ToUpper();
            if (name == "NEO")
            {
                Console.WriteLine("Go home Neo.");
                return;
            }
            else
            {
                Console.WriteLine("How old are you?");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age < 18)
                {
                    Console.WriteLine("Sorry you are too young!");
                    return;
                }
                else
                {
                    Console.WriteLine("Do you want to enter?");
                    string enter = Console.ReadLine().ToUpper();
                    if (enter == "NO")
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Do you want to turn back?");
                        string turnback = Console.ReadLine().ToUpper();
                        if (turnback == "NO")
                        {
                            Console.WriteLine("Congratulations you made it in.");

                        }
                        else
                        {
                            return;
                        }
                    }

                }

            }
        }
    }
}
