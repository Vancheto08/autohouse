using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class CustomerBusiness
    {
        private AutohouseContext autohouseContext;
        public List<Customer> GetAll(int id)
        {
            using (autohouseContext = new AutohouseContext())
            {
                return autohouseContext.Customers.ToList();
            }
        }
        public Customer Get(int id)
        {
            using (autohouseContext = new AutohouseContext())
            {
                return autohouseContext.Customers.Find(id);
            }
        }
        public void Add(Customer customer)
        {
            using (autohouseContext = new AutohouseContext())
            {
                autohouseContext.Customers.Add(customer);
                autohouseContext.SaveChanges();
            }
        }
        public void Update(Customer customer)
        {
            using (autohouseContext = new AutohouseContext())
            {
                var item = autohouseContext.Customers.Find(customer.CustomerId);
                if (item != null)
                {
                    autohouseContext.Entry(item).CurrentValues.SetValues(customer);
                    autohouseContext.SaveChanges();
                }
            }
        }
        public void Delete(int id)
        {
            using (autohouseContext = new AutohouseContext())
            {
                var customer = autohouseContext.Customers.Find(id);
                if (customer != null)
                {
                    autohouseContext.Customers.Remove(customer);
                    autohouseContext.SaveChanges();
                }
            }
        }
    }
}
