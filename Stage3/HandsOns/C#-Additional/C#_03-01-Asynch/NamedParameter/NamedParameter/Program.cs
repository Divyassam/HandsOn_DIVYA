using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Output for Named Parameter\n");
            Console.WriteLine("Correct Order");
            GetCohortDetails(cohortName: "ADM20DF003", genCCount:21, mode: "OBL", track: ".Net", currentModule: "ASP .NET Core");
            Console.WriteLine("Wrong Order");
            GetCohortDetails(genCCount: 21, cohortName: "ADM20DF003",track: ".Net", mode: "OBL", currentModule: "ASP .NET Core");

            Console.WriteLine("\n\n\nOutput for Optional Parameter\n");
            Console.WriteLine("Passing only required parameters");
            OrderDetails("ABC ltd","Oven");
            Console.WriteLine("Passing all parameters");
            OrderDetails("XYZ ltd", "Chips",10,false);


            Console.Read();
        }

        //Named param
        public static void GetCohortDetails(string cohortName,int genCCount,string mode,string track, string currentModule)
        {
            Console.WriteLine($"It is {cohortName} with {genCCount} GenCs undergoing training for {track} thru {mode}. The current module of training is {currentModule}");
            
        }

        //Optional param
        public static void OrderDetails(string sellerName,string productName, int orderQty=1, bool isReturnable=true)
        {
            Console.WriteLine($"Here is the order detail – {orderQty} number of {productName} by {sellerName} is ordered. It’s returnable status is {isReturnable} ");

        }
    }
}
