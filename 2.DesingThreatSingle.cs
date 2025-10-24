using System;
using System.Threading;

class Singleton
{
    private static Singleton instance;
    private static readonly object lockObj = new object();

    // Private constructor
    private Singleton()
    {
        Console.WriteLine("Singleton instance created by thread " + Thread.CurrentThread.ManagedThreadId);
    }

    // Thread-safe Singleton
    public static Singleton GetInstance()
    {
        if (instance == null)
        {
            lock (lockObj)
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
            }
        }
        return instance;
    }

    public void ShowMessage()
    {
        Console.WriteLine("Hello from Singleton!");
    }
}

class Program
{
    static void Main()
    {
        // Create multiple threads
        Thread t1 = new Thread(ThreadTask);
        Thread t2 = new Thread(ThreadTask);
        Thread t3 = new Thread(ThreadTask);
        Thread t4 = new Thread(ThreadTask);
        t1.Start();
        t2.Start();
        t3.Start();
        t4.Start();

        t1.Join();
        t2.Join();
        t3.Join();
        t4.Join();

        Console.WriteLine("All threads used the same instance.");
    }

    static void ThreadTask()
    {
        Singleton s = Singleton.GetInstance();
        Console.WriteLine("Instance HashCode: " + s.GetHashCode());
        s.ShowMessage();
    }
}
