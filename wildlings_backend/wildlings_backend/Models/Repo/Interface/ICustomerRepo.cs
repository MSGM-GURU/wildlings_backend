using System.Collections.Generic;

namespace wildlings_backend.Models.Repo.Interface
{
    public interface ICustomerRepo
    {
        IEnumerable<Customer> GetAllCustomer();

        Customer GetCustomer(long id);
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
    }
}