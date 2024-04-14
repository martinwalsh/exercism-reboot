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
            if (c == ' ') { builder.Append("_"); }
            else if (char.IsControl(c)) { builder.Append("CTRL"); }
            else if (lastChar == '-') { builder.Append(char.ToUpper(c)); }
            else if (c >= 'α' && c <= 'ω') { continue; }
            else if (char.IsLetter(c) || c == '_') { builder.Append(c); }
            lastChar = c;
        }
        return builder.ToString();
    }
}
