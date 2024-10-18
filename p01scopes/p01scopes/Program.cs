internal class Program
{
    private static void Main(string[] args)
    {
        {
            Console.WriteLine("Please enter a number: ");
            string input = Console.ReadLine();
            input = input +1;
            Console.WriteLine(input);
        }
        {
            Console.WriteLine("Please enter another number: ");
            string input = Console.ReadLine();
            int convertedInt = Convert.ToInt32(input);
            convertedInt = convertedInt +1;
            Console.WriteLine(convertedInt);
        }
        {
            Console.WriteLine("Please enter a number: ");
            string input = Console.ReadLine();
            char convertedChar = Convert.ToChar(input);
            convertedChar++;
            Console.WriteLine(input);
        }
    }
}