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
        /// <summary>
        /// Create an instance of <see href="CustomerBusiness"> with the specified context.
        /// </summary>
        /// <param name="context">An instance of DbContext.</param>
        public CustomerBusiness(DbContext context)
        {
            autohouseContext = context;
        }
        /// <summary>
        /// Create an instance of <see href="CustomerBusiness">.
        /// </summary>
        public CustomerBusiness()
        {
            autohouseContext = new AutohouseContext();
        }
        /// <summary>
        /// Gets all the customers from the database.
        /// </summary>
        /// <returns>A list of all customers.</returns>
        public List<Customer> GetAll()
        {
            return autohouseContext.Set<Customer>().ToList();
        }
        /// <summary>
        /// Gets a customer by its Id.
        /// </summary>
        /// <param name="id">The Id of the customer to retrieve.</param>
        /// <returns>The customer with the specified Id.</returns>
        public Customer Get(int id)
        {
            return autohouseContext.Set<Customer>().Find(id);
        }
        /// <summary>
        /// Adds a new customer to the database.
        /// </summary>
        /// <param name="customer">The customer to add.</param>
        public void Add(Customer customer)
        {
            autohouseContext.Set<Customer>().Add(customer);
            autohouseContext.SaveChanges();
        }
        /// <summary>
        /// Updates an existing customer in the database.
        /// </summary>
        /// <param name="customer">The customer with updated values.</param>
        public void Update(Customer customer)
        {
            var item = autohouseContext.Set<Customer>().Find(customer.CustomerId);
            if (item != null)
            {
                autohouseContext.Entry(item).CurrentValues.SetValues(customer);
                autohouseContext.SaveChanges();
            }
        }
        /// <summary>
        /// Deletes a customer from the database by its Id.
        /// </summary>
        /// <param name="id">The Id of the customer to delete.</param>
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
