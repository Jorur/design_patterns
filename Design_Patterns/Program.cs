using Design_Patterns.Singleton;

var instance1 = Singleton.GetInstance();
var instance2 = Singleton.GetInstance();
var instance3 = Singleton.GetInstance();

Console.WriteLine($"Instance 1: {instance1.Id}");
Console.WriteLine($"Instance 2: {instance2.Id}");
Console.WriteLine($"Instance 3: {instance3.Id}");

var eventLogger = EventLogger.GetInstance();
eventLogger.LogEvent("Application started");

var eventLogger2 = EventLogger.GetInstance();
eventLogger2.LogEvent("Application running");

var eventLogger3 = EventLogger.GetInstance();
eventLogger3.LogEvent("Application stopped");

eventLogger.PrintLogs();