using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    //Mercedes Concrete classes
    public class MercedesTire : Tire
    {
        public override void PrintTire()
        {
            Console.WriteLine("Mercedes : Tire");
        }
    }

    public class MercedesHeadlight : Headlight
    {
        public override void PrintHeadlight()
        {
            Console.WriteLine("Mercedes : Headlight");
        }
    }

    public class MercedesFactory : AbstractFactory
    {
        public override Tire GetTire()
        {
            return new MercedesTire();
        }
        public override Headlight GetHeadlight()
        {
            return new MercedesHeadlight();
        }
    }


}
