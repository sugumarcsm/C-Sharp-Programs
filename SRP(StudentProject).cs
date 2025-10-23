using System;
using System.Collections.Generic;
using System.IO;

namespace SolidPrinciples
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LastUpdate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }

        public Student() { }

        public Student(int id, string name, int marks, DateTime createDate, DateTime updateDate, bool delete)
        {
            Id = id;
            Name = name;
            Marks = marks;
            Created = createDate;
            LastUpdate = updateDate;
            IsDeleted = delete;
        }
    }

    class StudentReport
    {
        public string GenerateReport(Student student)
        {
            return $"Student Id :{student.Id}\n"+
                   $"Student Name: {student.Name}\n" +
                   $"Student Marks: {student.Marks}\n" +
                   $"Join Date: {student.Created}\n" +
                   $"Last Update: {student.LastUpdate}\n" +
                   $"--------------------------\n";
        }
    }

    class ReportPrinter
    {
        public void PrintReport(string report)
        {
            Console.WriteLine("----- Student Report -----");
            Console.WriteLine(report);
        }
    }

    class ReportSaver
    {
        public void SaveReport(string report, string fileName = "students.txt")
        {
            // Append all reports to the file
            File.AppendAllText(fileName, report);
          
        }
    }

    internal class SRPMiniProject
    {
        public static void Main(string[] args)
        {

            //create a List of Student 
            List<Student> students = new List<Student>
            {
                new Student(1,"sugumar",95,DateTime.Now.AddYears(-1),DateTime.Now,false),
                new Student(2,"sathish",98,DateTime.Now.AddYears(-2),DateTime.Now,false),
                new Student(3,"Arun",78,DateTime.Now.AddYears(-4),DateTime.Now,false),
                new Student(4,"Lokesh",98,DateTime.Now.AddYears(-2),DateTime.Now,false),
                new Student(5,"Praveen",78,DateTime.Now.AddYears(-4),DateTime.Now,false),

            };

            // Step 2: Initialize report tools
            StudentReport reportGenerator = new StudentReport();
            ReportPrinter printer = new ReportPrinter();
            ReportSaver saver = new ReportSaver();

            foreach(var student in students)
            {
                string report = reportGenerator.GenerateReport(student);
                printer.PrintReport(report);
                saver.SaveReport(report);
            }
            Console.WriteLine("All report generate and save successfully!");
           

            Console.ReadLine();
        }
    }
}
