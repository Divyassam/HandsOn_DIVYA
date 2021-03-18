using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AUTOMOBILE MANUFACTURES\n*******************************************\nChoose brands: Mercedes  OR   Audi");
            Console.WriteLine("Enter Option : ");
            string optn = Console.ReadLine();
            AbstractFactory obj = FactoryGetter.getFactory(optn);
            obj.GetTire().PrintTire();
            obj.GetHeadlight().PrintHeadlight();

        }
    }
}
