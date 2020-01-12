﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_TemplMeth.Ecommerce.EcommerceHandlers
{
    public class EuropeHandler : EcommerceHandler
    {
        public EuropeHandler()
        {
            this.TaxRate = 0.15;
        }

        protected override decimal CaculateTax(decimal totalPrice)
        {
            var caculatedPrice = base.CaculateTax(totalPrice);
            // do something for Europe regulation.
            return caculatedPrice;
        }

        protected override void CheckCustomerAddress(string customerAddress)
        {
            base.CheckCustomerAddress(customerAddress);
            // check address Europe way.
        }
    }
}
