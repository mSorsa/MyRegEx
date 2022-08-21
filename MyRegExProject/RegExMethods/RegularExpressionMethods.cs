namespace RegExMethods;

public class RegularExpressionMethods
{
    public bool CheckFor0FollowedBy1UsingRegex(string input)
        => System.Text.RegularExpressions.Regex.IsMatch(input, "01");

    public bool CheckFor3SymbolsUsingRegex(string input)
        => System.Text.RegularExpressions.Regex.Matches(input, "[^a-zA-Z0-9]").Count >= 3;

    public bool CheckIfOddNumberOf0sAnd1sUsingRegex(string input)
        => System.Text.RegularExpressions.Regex.Matches(input, "0").Count % 2 != 0 &&
           System.Text.RegularExpressions.Regex.Matches(input, "1").Count % 2 != 0;
}
