using System;

class Singleton
{
    private static Singleton instance;   // static object reference

    // private constructor – மற்ற class-லிருந்து new செய்ய முடியாது
    private Singleton()
    {
        Console.WriteLine("Instance created");
    }

    // ஒரே global access point
    public static Singleton GetInstance()
    {
        
        if (instance == null)
        {
            instance = new Singleton();
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
        Singleton s1 = Singleton.GetInstance();
        Singleton s2 = Singleton.GetInstance();

        if (s1 == s2)
        {
            Console.WriteLine("இரண்டும் ஒரே instance");
        }

        s1.ShowMessage();
    }
}
