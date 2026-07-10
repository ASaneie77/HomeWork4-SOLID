using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class Product
    {
        #region Properties
        public int Id { get; set; }

        public string Name { get; set;}

        public decimal Price { get; set;}

        public int DiscountPercent { get; set; } = 0;
        #endregion

        #region Methods

        public decimal ApplyDiscount()
        {
            decimal discount = Price * DiscountPercent / 100;

            return (Price - discount);
        }

        #endregion
    }
}
