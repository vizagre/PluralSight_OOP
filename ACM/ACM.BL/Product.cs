using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Product
    {
        public Product()
        {
        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        /// <summary>
        /// Validate Product data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName))
            {
                isValid = false;
            }

            if (CurrentPrice == null)
            {
                isValid = false;
            }

            return isValid;
        }

        /// <summary>
        /// Retrieve one Product by Id
        /// </summary>
        /// <param name="ProductId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            // code thats retrieve the defined Customer.
            return new Product();
        }

        /// <summary>
        /// Saves the current Product.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // code that saves the defined Product
            return true;
        }

    }
}
