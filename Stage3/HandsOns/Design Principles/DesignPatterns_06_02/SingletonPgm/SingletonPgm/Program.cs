using System;

namespace SingletonPgm
{
    class Program
    {
        static void Main(string[] args)
        {
            DBConn inst1 = DBConn.getInstance();
            DBConn inst2 = DBConn.getInstance();
            if (inst1 == inst2)
            {
                Console.WriteLine("Only single instance created");
            }
        }
    }
}
