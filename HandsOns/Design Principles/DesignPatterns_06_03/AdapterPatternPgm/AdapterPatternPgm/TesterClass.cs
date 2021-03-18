using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternPgm
{
    [TestFixture]
    public class TesterClass
    {

        [Test]
        public void whenConvertingUSDtoEuros_thenSuccessfullyConverted()
        {
            Movable bugattiVeyron = new BugattiVeyron();
            MovableAdapter bugattiVeyronAdapter = new MovableAdapterImpl(bugattiVeyron);
            Assert.AreEqual(bugattiVeyronAdapter.getPrice(), 100 * 0.841174);
        }


        //[Test]
        //public void whenConvertingMPHToKMPH_thenSuccessfullyConverted() 
        //{
        //    Movable bugattiVeyron = new BugattiVeyron();
        //    MovableAdapter bugattiVeyronAdapter = new MovableAdapterImpl(bugattiVeyron);
        //    Assert.AreEqual(bugattiVeyronAdapter.getSpeed(), 431.30312, 0.00001);
        //}

    }
}
