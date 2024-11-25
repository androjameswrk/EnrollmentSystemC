using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EnrollmentSystemProject.PricingModel;

namespace EnrollmentSystemProject
{
    internal class PricingController
    {
        private PricingData pricingData;

        public PricingController(PricingForm form)
        {
            pricingData = new PricingData();
        }
        public PricingController(AssessmentForm form1)
        {
            pricingData = new PricingData();
        }

        public void registerPrice(Pricing pricing)
        {
            pricingData.insertPrice(pricing);
        }
    }
}
