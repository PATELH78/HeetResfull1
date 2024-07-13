﻿using Heetapp1.Interfaces;
using Heetapp1.Models;
using System.Collections.Generic;
using System.Linq;

namespace Heetapp1.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepo _customerRepo;

        public CustomerService(ICustomerRepo customerRepo)
        {
            _customerRepo = customerRepo;
        }

        public List<Customer> GetAllCustomers()
        {
            return _customerRepo.GetAllCustomers();
        }

        public Customer GetCustomerById(int id)
        {
            return _customerRepo.GetAllCustomers().FirstOrDefault(c => c.Id == id);
        }
    }
}