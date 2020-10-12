﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {

        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            // Code that retrieves the defined product
            // Temporary Hard-coded values to return a populated order

            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                                                     new TimeSpan(7, 0, 0));
            }

            return order;
        }

        public bool Save(Order order)
        {
            // Code that saves the Order

            return true;
        }

    }
}
