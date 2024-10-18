Console.WriteLine("Here is the power of 2's");
for (int i = 1; i <= 1024; i *= 2)
{
    Console.Write(i);
    if (i < 1024)
    {
        Console.Write("-");
    }
}
