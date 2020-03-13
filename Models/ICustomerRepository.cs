using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ja.cha.se.Models
{
    public interface ICustomerRepository
    {
        Customer GetCustomer(int id);
        IEnumerable<Customer> GetAllCustomer();
        Customer Add(Customer customer);
        Customer update(Customer customerchanges);

        Customer Delete(int id);
    }
}
