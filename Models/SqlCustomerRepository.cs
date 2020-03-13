using ja.cha.se.AppDataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ja.cha.se.Models
{
    public class SqlCustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext context;

        public SqlCustomerRepository(AppDbContext context)
        {
            this.context = context;
        }


        public Customer Add(Customer customer)
        {
            context.customers.Add(customer);
            context.SaveChanges();
            return customer;
        }

        public Customer Delete(int id)
        {
           Customer customer = context.customers.Find(id);
            if(customer!=null)
            {
                context.customers.Remove(customer);
                context.SaveChanges();
            }
            return customer;
        }

        public IEnumerable<Customer> GetAllCustomer()
        {
            return context.customers;
        }

        public Customer GetCustomer(int id)
        {
            return context.customers.Find(id);
        }

        public Customer update(Customer customerchanges)
        {
           var customer = context.customers.Attach(customerchanges);
            customer.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return customerchanges;
        }
    }
}
