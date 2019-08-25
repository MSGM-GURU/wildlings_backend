using System;
using System.Collections.Generic;
using wildlings_backend.Models.Repo.Interface;

namespace wildlings_backend.Models.Repo
{
    public class CustomerRepo : ICustomerRepo
    {
        public IEnumerable<Customer> GetAllCustomer()
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(long id)
        {
            throw new NotImplementedException();
        }
    }
}