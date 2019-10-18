using System.Collections.Generic;
using System.Linq;
using wildlings_backend.Models.Repo.Interface;

namespace wildlings_backend.Models.Repo
{
    internal class FakeCustomerRepo : ICustomerRepo
    {
        private List<Customer> _allCustomer = new List<Customer>()
        {
            new Customer()
            {
                Id=1,
                Name = "Cloud"
            },
            new Customer()
            {
                Id=2,
                Name = "Tim"
            },
            new Customer()
            {
                Id=3,
                Name = "Charlie"
            },
        };

        public IEnumerable<Customer> GetAllCustomer()
        {
            return _allCustomer;
        }

        public Customer GetCustomer(long id)
        {
            return _allCustomer.FirstOrDefault(x => x.Id == id);
        }

        public void AddCustomer(Customer customer)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new System.NotImplementedException();
        }
    }
}