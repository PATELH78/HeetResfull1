using Heetapp1.Interfaces;
using Heetapp1.Models;
using System.Collections.Generic;
using System.Linq;

namespace Heetapp1.Repositories
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly List<Customer> _customers;

        public CustomerRepo()
        {
            
            _customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "Heet", LastName = "Patel" },
                new Customer { Id = 2, FirstName = "Sumit", LastName = "Patel" }
            };
        }

        public List<Customer> GetAllCustomers()
        {
            return _customers;
        }
    }
}
