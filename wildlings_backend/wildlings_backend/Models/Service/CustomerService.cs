using System.Collections.Generic;
using wildlings_backend.Models.Repo;
using wildlings_backend.Models.Repo.Interface;
using wildlings_backend.Models.Service.Interface;

namespace wildlings_backend.Models.Service
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepo _customerRepo = new FakeCustomerRepo();

        public IEnumerable<Customer> GetAllCustomer()
        {
            return _customerRepo.GetAllCustomer();
        }

        public Customer GetCustomer(long id)
        {
            return _customerRepo.GetCustomer(id);
        }
    }
}