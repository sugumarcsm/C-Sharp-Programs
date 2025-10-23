using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    
    class Payment
    {
        public virtual void pay(double amount)
        {
            if (amount > 0)
            {
                Console.WriteLine("Payment Processed.");
            }
        }
    }
    
    class CreaticartPayment : Payment
    {
        public override void pay(double amount)
        {
        //    base.pay(amount);
            Console.WriteLine($"Paid {amount}using CreaditCart.");
        }
    }

    class UpiPayment : Payment
    {
        public override void pay(double amount)
        {
           // base.pay(amount);
            if (amount < 1000)
            {
                throw new Exception("UPI Payments below 1000 not allowed!");
            }

            Console.WriteLine($"Paid {amount} using Upi");
        }
    }

    internal class LspExample
    {
        public static void Main(string[] args)
        {
            Payment creadit = new CreaticartPayment();
            creadit.pay(1500);

            Payment upi = new UpiPayment();
            upi.pay(500);
        }
    }
}
