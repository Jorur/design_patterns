using System.Globalization;

namespace Design_Patterns.Singleton;

public class EventLogger
{
    private static EventLogger? _instance;
    private List<string>? _eventLogs;
    
    private EventLogger()
    {
        _eventLogs = new List<string>();
    }
    
    public static EventLogger GetInstance()
    {
        if (_instance is null)
        {
            _instance = new EventLogger();
        }

        return _instance;
    }

    public void LogEvent(string message)
    {
        var timeStamp = DateTime.Now.ToString(CultureInfo.CurrentCulture);
        _eventLogs?.Add($"{timeStamp}: {message}");
    }

    public void PrintLogs()
    {
        foreach (var eventLog in _eventLogs!)
        {
            Console.WriteLine(eventLog);
        }
    }
}