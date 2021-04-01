using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternPgm
{
    public interface Movable
    {
        // returns price in USD
        double getPrice();
    }


    public class BugattiVeyron : Movable
    {
        public double getPrice()
        {
            return 100;
        }
    }




    //public interface Movable
    //{
    //    // returns speed in MPH
    //    double getSpeed();
    //}


    //public class BugattiVeyron : Movable 
    //{ 
    //    public double getSpeed()
    //    { 
    //        return 268; 
    //    }
    //}



}
