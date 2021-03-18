using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{   
    public abstract class Tire
    {
        public abstract void PrintTire();
    }

    public abstract class Headlight
    {
        public abstract void PrintHeadlight();
    }

    public abstract class AbstractFactory
    {
        public abstract Tire GetTire();
        public abstract Headlight GetHeadlight();
    }
}
