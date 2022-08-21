using RegExMethods;

namespace LearnRegEx;

public class Program
{
    public static void Main(string[] args)
    {
        var regulars = new RegularExpressionMethods();
        var regIntAndFloats = new RegExIntAndFloatMethods();
        
        string input;

        Console.WriteLine("Write a string to check if it contains atleast 3 symbols: ");
        input = Console.ReadLine();

        Console.WriteLine(regulars.CheckFor3SymbolsUsingRegex(input));
        Console.WriteLine();


        Console.WriteLine("Write a string to check if a 0 is followed by a 1: ");
        input = Console.ReadLine();

        Console.WriteLine(regulars.CheckFor0FollowedBy1UsingRegex(input));
        Console.WriteLine();


        Console.WriteLine("Write a string to check if there are odd number of 0s and 1s: ");
        input = Console.ReadLine();

        Console.WriteLine(regulars.CheckIfOddNumberOf0sAnd1sUsingRegex(input));
        Console.ReadKey();

        Console.WriteLine("Write a number to check if positive int or float: ");
        input = Console.ReadLine();

        Console.WriteLine(regIntAndFloats.CheckPositiveIntUsingRegEx(input));
        Console.ReadKey();
    }
}