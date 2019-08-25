using System.Collections.Generic;

namespace wildlings_backend.Models.Repo.Interface
{
    public interface ICustomerRepo
    {
        IEnumerable<Customer> GetAllCustomer();

        Customer GetCustomer(long id);
    }
}