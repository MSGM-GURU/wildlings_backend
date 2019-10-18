using System.Collections.Generic;

namespace wildlings_backend.Models.Service.Interface
{
    internal interface ICustomerService 
    {
        IEnumerable<Customer> GetAllCustomer();
        Customer GetCustomer(long id);
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
    }
}