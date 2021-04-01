using System;

namespace BuilderPgm
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            PackageBuilder childBuilder = new ChildPack();
            PackageBuilder adultBuilder = new AdultPack();

            Console.WriteLine(director.MakePack(childBuilder));
            Console.WriteLine(director.MakePack(adultBuilder));

            

        }
    }
}
