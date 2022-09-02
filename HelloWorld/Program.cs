// See https://aka.ms/new-console-template for more information
namespace HelloWorld;

internal class Program
{
    private static void Main(string[] args)
    {

        if (args.Length != 0)
        {
            foreach (string arg in args)
            {
                if (int.TryParse(arg, out var val))
                {
                    Console.WriteLine(leapYear(val));
                }
            }
        }
        else
        {
            Console.WriteLine("Welcome to LeapYear Calculator.EXE");
            Console.WriteLine("Input year, finish with enter");
            var input = Console.ReadLine();
            //var output = writer.GetStringBuilder().ToString().TrimEnd();
            if (int.TryParse(input, out var val))
            {
                Console.WriteLine(leapYear(val));
            }
        }
    }


    static string leapYear(int year)
    {
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    return "yay";
                }
                return "nay";
            }
            return "yay";
        }
        return "nay";
    }

}
