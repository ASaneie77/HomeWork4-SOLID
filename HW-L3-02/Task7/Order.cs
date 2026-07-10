using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task7.Email;

namespace Task7
{
    public class Order
    {
        private List<Product> products;

        private IEmailProvider _emailProvider;

        public Order(IEmailProvider emailProvider)
        {
            _emailProvider = emailProvider;
        }

        public void AddProductToOrder(Product product)
        {
            products.Add(product);
        }

        public void DeleteProductFromOrder(Product product)
        {
            products.Remove(product);
        }

        public void PayOrder()
        {
            decimal totalPrice = GetTotalPrice();
            decimal totalDiscountPrice = GetTotalDiscountedPrice();
            int numOfProduct = GetTotalNumberOfProducts();



            String purchase = $"Number of products is {numOfProduct}\n," +
                              $"Total bill is  {totalPrice}\n," +
                              $"you pay {totalDiscountPrice}\n," +
                              $"Your profit from this purchase {totalPrice - totalDiscountPrice}\n";

            _emailProvider.SendEmail(purchase);

        }

        #region Private Methods
        private decimal GetTotalPrice()
        {
            decimal sum = 0;

            foreach (var item in products)
            {
                sum += item.Price;
            }

            return sum;
        }

        private decimal GetTotalDiscountedPrice()
        {
            decimal sum = 0;

            foreach (var item in products)
            {
                sum += item.ApplyDiscount();
            }

            return sum;
        }
        private int GetTotalNumberOfProducts()
        {
            return products.Count;
        }
        #endregion
    }
}
