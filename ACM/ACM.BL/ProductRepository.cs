using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            // Create a instance of Product class
            // Pass in a requested Id
            Product product = new Product(productId);

            // Code that retrieves the defined product
            // Temporary Hard-coded values to return a populated product

            if (productId == 2)
            {
                product.ProductName = "SunFlowers";
                product.ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini SunFlowers";
                product.CurrentPrice = 15.96M;
            }

            object myObject = new object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");
            return product;
        }

        public bool Save(Product product)
        {
            var success = true;

            if(product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        // call a Insert Stored Procedure
                    }
                    else
                    {
                        // call a Update Stored Procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
