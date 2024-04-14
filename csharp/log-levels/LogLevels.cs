using System;

static class LogLine
{
    public static string Message(string logLine) =>
        logLine.Substring(logLine.IndexOf(':') + 1).Trim();

    public static string LogLevel(string logLine)
    {
        try
        {
            return logLine.Substring(1, logLine.IndexOf(']') - 1).ToLower();
        }
        catch (ArgumentOutOfRangeException)
        {
            throw new ArgumentException("Invalid log line");
        }
    }

    public static string Reformat(string logLine) =>
        $"{Message(logLine)} ({LogLevel(logLine)})";
}
