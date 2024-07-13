using Heetapp1.Models;
using System.Collections.Generic;

namespace Heetapp1.Interfaces
{
    public interface ICustomerRepo
    {
        List<Customer> GetAllCustomers();
    }
}
