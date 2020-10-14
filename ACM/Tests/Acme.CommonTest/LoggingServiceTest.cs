﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Common;
using ACM.BL;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {

        [TestMethod]
        public void WriteToFileFile()
        {

            //-- arrange
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAdress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden Rake with Steel Head",
                CurrentPrice = 6M
            };
            changedItems.Add(product);

            //-- act

            LogginService.WriteToFile(changedItems);

            //-- assert
            // nothing here
        }
    }
}
