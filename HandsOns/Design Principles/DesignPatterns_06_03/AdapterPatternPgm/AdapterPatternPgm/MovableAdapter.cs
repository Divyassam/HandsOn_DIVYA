using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternPgm
{
    public interface MovableAdapter
    {
        // returns price in Euros
        double getPrice();
    }

    public class MovableAdapterImpl : MovableAdapter
    {
        private Movable _luxuryCars;
        // standard constructors
        public MovableAdapterImpl(Movable luxuryCars)
        {
            _luxuryCars = luxuryCars;
        }
        public double getPrice()
        {
            return convertUSDtoEuros(_luxuryCars.getPrice());
        }
        private double convertUSDtoEuros(double mph)
        {
            return mph * 0.841174;
        }
    }




    //public interface MovableAdapter
    //{
    //    // returns speed in KM/H
    //    double getSpeed();
    //}

    //public class MovableAdapterImpl : MovableAdapter
    //{
    //    private Movable _luxuryCars;
    //    // standard constructors
    //    public MovableAdapterImpl(Movable luxuryCars)
    //    {
    //        _luxuryCars = luxuryCars;
    //    }
    //    public double getSpeed()
    //    {
    //        return convertMPHtoKMPH(_luxuryCars.getSpeed());
    //    }
    //    private double convertMPHtoKMPH(double mph)
    //    {
    //        return mph * 1.60934;
    //    }
    //}



}
