using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class DelegatExaple
    {
        delegate void MyDelegate();
        delegate int opration(int x, int y);


        static int Add(int x, int y) => x + y;
        static int Multiply(int x, int y) => x * y;
            static void Calculator(opration op)
        {
            int result = op(10,5);
            Console.WriteLine(result);
        }

        static void Method1()
        {
            Console.WriteLine("method 1");
        }

        static void Method2()
        {
            Console.WriteLine("method 2");
        }


        static void Main(string[] args)
        {
            MyDelegate del = Method1;
            del += Method2;

            del();
        }
    }
