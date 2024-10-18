using System.ComponentModel.Design;
using System.Diagnostics;





internal partial class Program
{

    public static int Fibnums(int n)
    {
        if (n <= 0)
            return 0;
        else if (n == 1 || n == 2)
            return 1;
        else
            return Fibnums(n - 1) + Fibnums(n - 2);




    }
    private static void Main(string[] args)
    {
        Console.WriteLine("What number would you like?");
        string fibnum = Console.ReadLine();
        var n = Convert.ToInt32(fibnum);
        Console.Write(Fibnums(n));

    }
}