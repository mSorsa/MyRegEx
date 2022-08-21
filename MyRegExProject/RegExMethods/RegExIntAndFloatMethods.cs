using System.Text.RegularExpressions;

namespace RegExMethods;

public class RegExIntAndFloatMethods
{
    public bool CheckPositiveIntUsingRegEx(string input)
    {
        if (Regex.IsMatch(input, "^[-]") || Regex.IsMatch(input, "^[0-9]"))
            return false;
        
        if (input.Contains('.'))
            return Regex.IsMatch(input, "^[0-9]+.+[0-9]");
        
        return Regex.IsMatch(input, "^[0-9]+$");
    }
}
