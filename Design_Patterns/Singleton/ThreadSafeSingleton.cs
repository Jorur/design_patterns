namespace Design_Patterns.Singleton;

public class ThreadSafeSingleton
{
    private static ThreadSafeSingleton? _instance;
    
    private ThreadSafeSingleton()
    {
    }
    
    public ThreadSafeSingleton GetInstance()
    {
        if (_instance is null)
            _instance = new ThreadSafeSingleton();
        
        return _instance;
    }
}