using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryFinalCaseStudy
{
    public enum Channel
    {
        ECommerce, Telecaller
    }

    public enum ProductType
    {
        Electronics, Toys, Furniture
    }
    public abstract class Order
    {
        public Channel channel;
        public ProductType productType;
        public abstract void ProcessOrder();
    }


    public class ElectronicsOrder : Order
    {
        public ElectronicsOrder(Channel channel,ProductType productType)
        {
            this.channel = channel;
            this.productType = productType;
        }
        public override void ProcessOrder()
        {
            Console.WriteLine(productType+"  ordered via "+channel);
        }
    }
    public class FurnitureOrder : Order
    {
        public FurnitureOrder(Channel channel, ProductType productType)
        {
            this.channel = channel;
            this.productType = productType;
        }
        public override void ProcessOrder()
        {
            Console.WriteLine(productType + "  ordered via " + channel);
        }
    }
    public class ToysOrder : Order
    {
        public ToysOrder(Channel channel, ProductType productType)
        {
            this.channel = channel;
            this.productType = productType;
        }
        public override void ProcessOrder()
        {
            Console.WriteLine(productType + "  ordered via " + channel);
        }
    }
}
