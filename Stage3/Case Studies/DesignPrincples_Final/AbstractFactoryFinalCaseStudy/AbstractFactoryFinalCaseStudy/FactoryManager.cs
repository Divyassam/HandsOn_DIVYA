using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryFinalCaseStudy
{
    class FactoryManager
    {
        public static Order GetFactory(Channel channel,ProductType productType)
        {
            if (channel == Channel.ECommerce)
            {
                return new EcommerceWebsite().GetOrder(productType);
            }
            else if (channel == Channel.Telecaller)
            {
                return new TeleCallerAgent().GetOrder(productType);
            }
            else
            {
                throw new Exception("Enter valid option");
            }
        }
    }
}
