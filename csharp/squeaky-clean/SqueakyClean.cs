using System;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder builder = new StringBuilder();
        char lastChar = '\0';

        foreach (char c in identifier)
        {
            if (c >= 'α' && c <= 'ω') { continue; }
            else if (lastChar == '-') { builder.Append(char.ToUpper(c)); }
            else if (char.IsLetter(c)) { builder.Append(c); }
            else if (char.IsControl(c)) { builder.Append("CTRL"); }
            else if (char.IsWhiteSpace(c)) { builder.Append("_"); }
            lastChar = c;
        }
        return builder.ToString();
    }
}
