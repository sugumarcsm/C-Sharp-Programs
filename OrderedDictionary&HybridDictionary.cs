using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Dictionary
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "sugumar");
            dic.Add(2, "sathish");
            dic.Add(3, "Arun");

            OrderedDictionary od = new OrderedDictionary();
            od.Add("Name", "sugumar");
            od.Add("Age", 21);
            od.Add("City", "Ranipet");

            //Console.WriteLine(od.ToString());
            //Console.WriteLine(od["Name"]);
            //Console.WriteLine(od["Age"]);


            HybridDictionary hd = new HybridDictionary();
            hd.Add("A", "Apple");
            hd.Add("B", "Box");
            hd.Add("C", "Cat");

            foreach (DictionaryEntry item in hd)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            Console.WriteLine("-------------------------------------------");
            foreach (var ods in od.Values)
            {
                Console.WriteLine(ods.ToString());
            }
            Console.WriteLine("----------------------------");
            foreach(var item in dic)
            {
                Console.WriteLine(item);
            }
        }
    }
}
