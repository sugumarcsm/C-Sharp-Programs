using System;
using System.Threading;

class ThreadLifeCycleDemo
{
   public static void Main(string [] args)
{ 
        Thread t1 = new Thread(PrintNumbers);

        Console.WriteLine("Thread State after creation: " + t1.ThreadState); // Unstarted

        t1.Start();
        Console.WriteLine("Thread State after Start(): " + t1.ThreadState); // Running or WaitSleepJoin

        Thread.Sleep(100); // Give some time
        Console.WriteLine("Thread State during execution: " + t1.ThreadState);

        t1.Join(); // Wait until t1 finishes
        Console.WriteLine("Thread State after completion: " + t1.ThreadState); // Stopped
    }

    static void PrintNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Number: " + i);
            Thread.Sleep(200); // Make it sleep
        }
    }
}
