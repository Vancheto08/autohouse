using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Data;
using Data.Models;

namespace Business
{
    public class CustomerBusiness
    {
        private DbContext autohouseContext;
        public CustomerBusiness(DbContext context)
        {
            autohouseContext = context;
        }
        public CustomerBusiness()
        {
            autohouseContext = new AutohouseContext();
        }
        public List<Customer> GetAll()
        {
            return autohouseContext.Set<Customer>().ToList();
        }
        public Customer Get(int id)
        {
            return autohouseContext.Set<Customer>().Find(id);
        }
        public void Add(Customer customer)
        {
            autohouseContext.Set<Customer>().Add(customer);
            autohouseContext.SaveChanges();
        }
        public void Update(Customer customer)
        {
            var item = autohouseContext.Set<Customer>().Find(customer.CustomerId);
            if (item != null)
            {
                autohouseContext.Entry(item).CurrentValues.SetValues(customer);
                autohouseContext.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            var customer = autohouseContext.Set<Customer>().Find(id);
            if (customer != null)
            {
                autohouseContext.Set<Customer>().Remove(customer);
                autohouseContext.SaveChanges();
            }
        }
    }
}
