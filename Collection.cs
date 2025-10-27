using System;
using System.Collections.Generic;

namespace CollectionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ---------- 1. List Example ----------
            Console.WriteLine("=== List Example ===");
            List<string> students = new List<string>();

            students.Add("Sugumar");
            students.Add("Vignesh");
            students.Add("Praveen");

            Console.WriteLine("All Students:");
            foreach (var s in students)
                Console.WriteLine(s);

            students.Remove("Vignesh");
            Console.WriteLine("\nAfter Removing 'Vignesh':");
            foreach (var s in students)
                Console.WriteLine(s);

            // ---------- 2. Dictionary Example ----------
            Console.WriteLine("\n=== Dictionary Example ===");
            Dictionary<int, string> employee = new Dictionary<int, string>();

            employee.Add(101, "Arun");
            employee.Add(102, "Bala");
            employee.Add(103, "Chandru");

            Console.WriteLine("Employee List:");
            foreach (var emp in employee)
                Console.WriteLine($"ID: {emp.Key}, Name: {emp.Value}");

            if (employee.ContainsKey(102))
                Console.WriteLine($"\nEmployee with ID 102: {employee[102]}");

            employee.Remove(101);
            Console.WriteLine("\nAfter Removing ID 101:");
            foreach (var emp in employee)
                Console.WriteLine($"ID: {emp.Key}, Name: {emp.Value}");

            // ---------- 3. Queue Example ----------
            Console.WriteLine("\n=== Queue Example ===");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Task 1");
            queue.Enqueue("Task 2");
            queue.Enqueue("Task 3");

            Console.WriteLine("All Tasks in Queue:");
            foreach (var task in queue)
                Console.WriteLine(task);

            Console.WriteLine($"\nNext Task: {queue.Peek()}");
            queue.Dequeue();
            Console.WriteLine("After Dequeue:");
            foreach (var task in queue)
                Console.WriteLine(task);

            // ---------- End ----------
            Console.WriteLine("\nProgram Completed Successfully!");
            Console.ReadLine();
        }
    }
}
