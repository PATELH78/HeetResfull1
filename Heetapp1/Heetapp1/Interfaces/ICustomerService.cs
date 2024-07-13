using Heetapp1.Models;
using System.Collections.Generic;

namespace Heetapp1.Interfaces
{
    public interface ICustomerService
    {
        List<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
    }
}
