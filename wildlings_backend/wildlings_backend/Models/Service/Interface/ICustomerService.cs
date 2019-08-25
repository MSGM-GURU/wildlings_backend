using System.Collections.Generic;

namespace wildlings_backend.Models.Service.Interface
{
    internal interface ICustomerService 
    {
        IEnumerable<Customer> GetAllCustomer();
        Customer GetCustomer(long id);
    }
}