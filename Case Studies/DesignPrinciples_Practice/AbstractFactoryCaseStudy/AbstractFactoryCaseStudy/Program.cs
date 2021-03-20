using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryCaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory carFactory = new ConcreteCarFactory();
            CarClient carClient = new CarClient(carFactory);
            carClient.BuildMicroCar(Location.USA);
            carClient.BuildMiniCar(Location.USA);
            carClient.BuildLuxuryCar(Location.USA);

            Console.ReadKey();
        }


        #region Car related - Product and its parent abstract class
        public enum CarType
        {
            MICRO, MINI, LUXURY
        }
        public enum Location
        {
            DEFAULT, USA, INDIA
        }

        abstract class Car
        {
            public Car(CarType model, Location location)
            {
                this.CarType = model;
                this.Location = location;
            }
            public abstract void Construct();
            public CarType CarType { get; set; }
            public Location Location { get; set; }
            public override string ToString()
            {
                return "CarModel - "+CarType.ToString()+" located in "+Location.ToString()+"\n";
            }
        }

        class LuxuryCar : Car
        {
            public LuxuryCar(CarType carType,Location location) : base(CarType.LUXURY, location)
            {
                Construct();
            }
            public override void Construct()
            {
                Console.WriteLine("Connecting to luxury car");
                Console.WriteLine(base.ToString());
            }
        }

        class MicroCar : Car
        {
            public MicroCar(CarType carType, Location location) : base(CarType.MICRO, location)
            {
                Construct();
            }
            public override void Construct()
            {
                Console.WriteLine("Connecting to micro car");
                Console.WriteLine(base.ToString());
            }
        }

        class MiniCar : Car
        {
            public MiniCar(CarType carType, Location location) : base(CarType.MINI, location)
            {
                Construct();
            }
            public override void Construct()
            {
                Console.WriteLine("Connecting to mini car");
                Console.WriteLine(base.ToString());
            }
        }
        #endregion

        #region Abstract factory to expose to client

        abstract class CarFactory
        {
            public abstract Car GetCar(CarType carType, Location location);
        }
        class ConcreteCarFactory : CarFactory
        {
            public override Car GetCar(CarType carType,Location location)
            {
                if (carType == CarType.MICRO)
                {
                    switch (location)
                    {
                        case Location.USA:
                            return new MicroCar(CarType.MICRO,location);
                        case Location.INDIA:
                            return new MicroCar(CarType.MICRO, location);
                        default:
                            return new MicroCar(CarType.MICRO, location);


                    }
                }
                else if (carType == CarType.MINI)
                {
                    switch (location)
                    {
                        case Location.USA:
                            return new MiniCar(CarType.MINI, location);
                        case Location.INDIA:
                            return new MiniCar(CarType.MINI, location);
                        default:
                            return new MiniCar(CarType.MINI, location);


                    }
                }

                else
                {
                    switch (location)
                    {
                        case Location.USA:
                            return new LuxuryCar(CarType.LUXURY, location);
                        case Location.INDIA:
                            return new LuxuryCar(CarType.LUXURY, location);
                        default:
                            return new LuxuryCar(CarType.LUXURY, location);


                    }
                }
            }
        }

        class CarClient
        {
            CarFactory carFactory;
            public CarClient(CarFactory carFactory)
            {
               this.carFactory= carFactory;
            }
            public void BuildMicroCar(Location location)
            {
                carFactory.GetCar(CarType.MICRO, location);
            }
            public void BuildMiniCar(Location location)
            {
                carFactory.GetCar(CarType.MINI, location);
            }
            public void BuildLuxuryCar(Location location)
            {
                carFactory.GetCar(CarType.LUXURY, location);
            }
        }

        #endregion
    }
}
