using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    //Audi Concrete classes
    public class AudiTire : Tire
    {
        public override void PrintTire()
        {
            Console.WriteLine("Audi : Tire");
        }
    }

    public class AudiHeadlight : Headlight
    {
        public override void PrintHeadlight()
        {
            Console.WriteLine("Audi : Headlight");
        }
    }

    public class AudiFactory : AbstractFactory
    {
        public override Tire GetTire()
        {
            return new AudiTire();
        }
        public override Headlight GetHeadlight()
        {
            return new AudiHeadlight();
        }
    }

}
