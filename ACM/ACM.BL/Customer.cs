using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
        }

        public int CustomerId { get; private set; }
        public string FirstName { get; set; }

        private string _lastname;
        public string LastName
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
            }
        }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public string EmailAdress  { get; set; }

        public static int InstanceCount { get; set; }

        /// <summary>
        /// Validate customer data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAdress)) isValid = false;

            return isValid;
        }

        /// <summary>
        /// Retrieve one Customer by Id
        /// </summary>
        /// <param name="CustomerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int CustomerId)
        {
            // code thats retrieve the defined Customer.
            return new Customer();

        }

        /// <summary>
        /// Retrieve all Customers.
        /// </summary>
        /// <returns></returns>
        public List<Customer> Retrieve()
        {
            // code that retrieves all of the customers.
            return new List<Customer>();
        }

        /// <summary>
        /// Saves the current Customer.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // code that saves the defined Customer
            return true;
        }

    }

}
