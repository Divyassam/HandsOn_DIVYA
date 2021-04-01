using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryFinalCaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like to buy?---(electronics / toys / furniture)");            
            Console.WriteLine("How to place order?---(ecommerce / telecaller)");

            Order order = FactoryManager.GetFactory(Channel.ECommerce,ProductType.Electronics);
            Console.WriteLine("-------------------------------------------------------");
            order.ProcessOrder();
            order = FactoryManager.GetFactory(Channel.Telecaller, ProductType.Toys);
            Console.WriteLine("-------------------------------------------------------");
            order.ProcessOrder();
            Console.ReadLine();
        }
    }
}
