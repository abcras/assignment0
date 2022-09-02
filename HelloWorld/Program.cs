// See https://aka.ms/new-console-template for more information
namespace HelloWorld;

internal class Program
{
    private static void Main(string[] args)
    {
        foreach (string arg in args)
        {
            if (int.TryParse(arg, out var val))
            {
                Console.WriteLine(leapYear(val));
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }


    static bool leapYear(int year)
    {
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    return true;
                }
                return false;
            }
            return true;
        }
        return false;
    }

}
