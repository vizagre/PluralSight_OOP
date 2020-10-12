using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Order
    {

        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }
        
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }

        /// <summary>
        /// Validate Order data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null)
            {
                isValid = false;
            }

            return isValid;
        }

        /// <summary>
        /// Retrieve one Order by Id
        /// </summary>
        /// <param name="OrderId"></param>
        /// <returns></returns>
        public Order Retrieve(int OrderId)
        {
            // code thats retrieve the defined Customer.
            return new Order();
        }

        /// <summary>
        /// Saves the current Order.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // code that saves the defined Order
            return true;
        }
    }

}
