using System;
using System.Collections.Generic;
using System.Linq;
using wildlings_backend.Models.Exception;
using wildlings_backend.Models.Repo.Interface;
using wildlings_backend.wildlings;

namespace wildlings_backend.Models.Repo
{
    public class CustomerRepo : ICustomerRepo
    {
        private wildlingsContext _db = new wildlingsContext();

        public IEnumerable<Customer> GetAllCustomer()
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(long id)
        {
            throw new NotImplementedException();
        }

        public void AddCustomer(Customer customer)
        {
            if (IsUserExist(customer))
            {
                throw new AddCustomerException();
            }

            _db.Customer.Add(new wildlings.Customer
            {
                Id = customer.Id,
            });
        }

        private bool IsUserExist(Customer customer)
        {
            return _db.Customer.Count(x => x.Id == customer.Id) != 0;
        }

        public void UpdateCustomer(Customer customer)
        {
            if (!IsUserExist(customer))
            {
                throw new UpdateCustomerException();
            }

            _db.Customer.Update(new wildlings.Customer
            {
                Id = customer.Id,
            });
        }
    }
}