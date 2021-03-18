using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    //Factory getter
    public class FactoryGetter
    {
        public static AbstractFactory getFactory(string option)
        {
            if (option == "mercedes")
            {
                return new MercedesFactory();
            }
            else if(option == "audi")
            {
                return new AudiFactory();
            }
            else
            {
                throw new Exception("Enter valid option");
            }
        }


    }
}
