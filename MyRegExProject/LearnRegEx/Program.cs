namespace LearnRegEx;

public class Program
{
    public static void Main(string[] args)
    {
        string input;

        Console.WriteLine("Write a string to check if it contains atleast 3 symbols: ");
        input = Console.ReadLine();

        Console.WriteLine(RegExMethods.CheckFor3SymbolsUsingRegex(input));
        Console.WriteLine();
        
        
        Console.WriteLine("Write a string to check if a 0 is followed by a 1: ");
        input = Console.ReadLine();

        Console.WriteLine(RegExMethods.CheckFor0FollowedBy1UsingRegex(input));
        Console.WriteLine();

        
        Console.WriteLine("Write a string to check if there are odd number of 0s and 1s: ");
        input = Console.ReadLine();

        Console.WriteLine(RegExMethods.CheckIfOddNumberOf0sAnd1sUsingRegex(input));
        Console.ReadKey();
    }
}