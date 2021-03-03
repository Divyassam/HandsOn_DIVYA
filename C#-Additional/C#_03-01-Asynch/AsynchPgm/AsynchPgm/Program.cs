using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace AsynchPgm
{
    class Program
    {
        static void Main(string[] args)
        {
            Meth1();
            Console.Read();
        }

        public async static Task Meth1()
        {
            string outpt = await Meth2();
            Console.WriteLine(outpt);
        }

        public async static Task<string> Meth2()
        {
            Thread.Sleep(3000);
            return ("Hellooo");
        }
    }
}
