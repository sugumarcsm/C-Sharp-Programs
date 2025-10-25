using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Program
    {
        static void Main(string[] args)
        {


            // 1. Current date and time
            DateTime now = DateTime.Now;
            Console.WriteLine("Current DateTime: " + now);
            Console.WriteLine();

            // 2. Standard format strings
            Console.WriteLine("Standard Formats:");
            Console.WriteLine("Short date (d): " + now.ToString("d"));
            Console.WriteLine("Long date (D): " + now.ToString("D"));
            Console.WriteLine("Short time (t): " + now.ToString("t"));
            Console.WriteLine("Long time (T): " + now.ToString("T"));
            Console.WriteLine("Full date & short time (f): " + now.ToString("f"));
            Console.WriteLine("Full date & long time (F): " + now.ToString("F"));
            Console.WriteLine("General date & short time (g): " + now.ToString("g"));
            Console.WriteLine("General date & long time (G): " + now.ToString("G"));
            Console.WriteLine("Month & day (M): " + now.ToString("M"));
            Console.WriteLine();

            // 3. Custom format strings
            Console.WriteLine("Custom Formats:");
            Console.WriteLine("yyyy-MM-dd HH:mm:ss : " + now.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine("dd/MM/yyyy : " + now.ToString("dd/MM/yyyy"));
            Console.WriteLine("dddd, dd MMMM yyyy : " + now.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine("ddd, MMM dd yyyy hh:mm tt : " + now.ToString("ddd, MMM dd yyyy hh:mm tt"));
            Console.WriteLine("HH:mm:ss : " + now.ToString("HH:mm:ss"));
            Console.WriteLine("hh:mm:ss tt : " + now.ToString("hh:mm:ss tt"));
            Console.WriteLine();

            // 4. Parsing date string to DateTime
            string dateStr = "25/10/2025";
            DateTime parsedDate = DateTime.ParseExact(dateStr, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("Parsed DateTime from string: " + parsedDate);
            Console.WriteLine("Custom format after parsing: " + parsedDate.ToString("MMMM dd, yyyy"));

            // 5. Using CultureInfo
            Console.WriteLine();
            Console.WriteLine("Using CultureInfo (InvariantCulture):");
            Console.WriteLine(now.ToString("D", CultureInfo.InvariantCulture));
            Console.WriteLine(now.ToString("f", new CultureInfo("en-US")));
            Console.WriteLine(now.ToString("f", new CultureInfo("fr-FR"))); // French format
        }
    }

   
