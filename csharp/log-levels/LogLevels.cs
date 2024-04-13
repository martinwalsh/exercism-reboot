using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine.Substring(logLine.IndexOf(':') + 1).Trim();
    }

    public static string LogLevel(string logLine)
    {
        try
        {
            string level = logLine.Substring(1, logLine.IndexOf(']') - 1);
            return level.ToLower();
        }
        catch (ArgumentOutOfRangeException)
        {
            throw new ArgumentException("Invalid log line");
        }
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
