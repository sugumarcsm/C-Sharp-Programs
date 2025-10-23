using System;
using System.Collections.Generic;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

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
                   $"Marks: {student.Marks}\n" +
                   $"Join Date: {student.Created}\n" +
                   $"Last Update: {student.LastUpdate}\n" +
                   $"--------------------------\n";
        }
    }

    class ReportPrinter
    {
        public void Print(string report)
        {
            Console.WriteLine(report);
        }
    }

    class ReportSaver
    {
        public void SaveReportToPDF(List<Student> students, string fileName = "StudentReports.pdf")
        {
            using (PdfWriter writer = new PdfWriter(fileName))
            {
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);

                document.Add(new Paragraph("----- Student Reports -----\n"));

                foreach (var student in students)
                {
                    document.Add(new Paragraph($"Student ID: {student.Id}"));
                    document.Add(new Paragraph($"Name: {student.Name}"));
                    document.Add(new Paragraph($"Marks: {student.Marks}"));
                    document.Add(new Paragraph($"Join Date: {student.Created}"));
                    document.Add(new Paragraph($"Last Update: {student.LastUpdate}"));
                    document.Add(new Paragraph("--------------------------\n"));
                }

                document.Close();
            }

            Console.WriteLine("PDF report generated successfully!");
        }
    }

    internal class SRPMiniProject
    {
        public static void Main(string[] args)
        {
            // Create a list of students
            List<Student> students = new List<Student>
            {
                new Student(1, "Sugumar", 95, DateTime.Now.AddYears(-1), DateTime.Now, false),
                new Student(2, "Sathish", 98, DateTime.Now.AddYears(-1), DateTime.Now, false),
                new Student(3, "Ram", 92, DateTime.Now.AddMonths(-6), DateTime.Now, false)
            };

            // Generate reports and print to console
            StudentReport reportGenerator = new StudentReport();
            ReportPrinter printer = new ReportPrinter();

            foreach (var student in students)
            {
                string report = reportGenerator.GenerateReport(student);
                printer.Print(report);
            }

            // Save all reports to PDF
            ReportSaver saver = new ReportSaver();
            saver.SaveReportToPDF(students);

            Console.ReadLine();
        }
    }
}
