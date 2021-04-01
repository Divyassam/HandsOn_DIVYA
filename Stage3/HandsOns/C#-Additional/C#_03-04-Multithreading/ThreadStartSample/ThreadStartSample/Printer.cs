using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadStartSample
{
    public class Printer
    {
        public void PrintNumbers()
        {
            Console.WriteLine("-> {0} is executing PrintNumbers()", Thread.CurrentThread.Name);

            Console.Write("Your Numbers: ");
            for(int i = 0; i < 10; i++)
            {
                Console.Write("{0}, ",i);
                Thread.Sleep(2000);
            }
            Console.WriteLine();
        }
    }
}
