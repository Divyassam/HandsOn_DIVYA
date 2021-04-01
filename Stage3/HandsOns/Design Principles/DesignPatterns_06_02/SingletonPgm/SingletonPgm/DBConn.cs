using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPgm
{
    class DBConn
    {
        private static DBConn instance;
        private DBConn()
        {
            Console.WriteLine("My Singleton");
        }
        public static DBConn getInstance()
        {
            if (instance == null)
            {
                instance = new DBConn();
                
            }
            return instance;
        }
    }

}
