using System;
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
            return $"Student Name: {student.Name}\n" +
                   $"Student Marks: {student.Marks}\n" +
                   $"Join Date: {student.Created}\n" +
                   $"Last Update: {student.LastUpdate}\n" +
                   $"--------------------------\n";
        }
    }

    class ReportPrinter
    {
        public void Print(string report)
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
            Console.WriteLine("Report saved successfully!");
        }
    }

    internal class SRPMiniProject
    {
        public static void Main(string[] args)
        {
            // Create students
            Student student1 = new Student(1, "Sugumar", 95, DateTime.Now.AddYears(-1), DateTime.Now, false);
            Student student2 = new Student(2, "Sathish", 98, DateTime.Now.AddYears(-1), DateTime.Now, false);

            // Generate reports
            StudentReport reportGenerator = new StudentReport();
            string report1 = reportGenerator.GenerateReport(student1);
            string report2 = reportGenerator.GenerateReport(student2);

            // Print reports
            ReportPrinter printer = new ReportPrinter();
            printer.Print(report1);
            printer.Print(report2);

            // Save reports
            ReportSaver saver = new ReportSaver();
            saver.SaveReport(report1);
            saver.SaveReport(report2);

            Console.ReadLine();
        }
    }
}
