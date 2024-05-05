namespace Design_Patterns.Singleton;

public class Singleton
{
    private static Singleton? _instance;
    public Guid Id { get; private set; }
    
    private Singleton()
    {
        Id = Guid.NewGuid();
    }

    public static Singleton GetInstance()
    {
        return _instance ??= new Singleton();
    }
}