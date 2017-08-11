using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models
{
    public class DefaultDiscountHelper : IDiscountHelper
    {
        //--This is to demonstrate: Binding with property value
        //public decimal DiscountSize { get; set; }

        //--This is to demonstrate: Binding with Constructor
        public decimal discountSize { get; set; }

        public DefaultDiscountHelper(decimal discountParam)
        {
            discountSize = discountParam;
        }

        public decimal ApplyDiscount(decimal totalParam)
        {
            return (totalParam - (discountSize / 100m * totalParam));
        }
    }
}