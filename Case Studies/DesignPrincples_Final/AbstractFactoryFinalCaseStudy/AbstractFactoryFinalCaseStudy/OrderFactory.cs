using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryFinalCaseStudy
{
    public abstract class OrderFactory
    {
        public abstract Order GetOrder(ProductType orderName);
    }

    public class EcommerceWebsite : OrderFactory
    {
        public override Order GetOrder(ProductType orderName)
        {
            switch (orderName)
            {
                case ProductType.Electronics:
                    return new FurnitureOrder(Channel.ECommerce , orderName);
                case ProductType.Toys:
                    return new ToysOrder(Channel.ECommerce, orderName);
                case ProductType.Furniture:
                    return new FurnitureOrder(Channel.ECommerce, orderName);
                default:
                    return null;
            }
        }
    }

    public class TeleCallerAgent : OrderFactory
    {
        public override Order GetOrder(ProductType orderName)
        {
            switch (orderName)
            {
                case ProductType.Electronics:
                    return new FurnitureOrder(Channel.Telecaller, orderName);
                case ProductType.Toys:
                    return new ToysOrder(Channel.Telecaller, orderName);
                case ProductType.Furniture:
                    return new FurnitureOrder(Channel.Telecaller, orderName);
                default:
                    return null;
            }
        }
    }
}
