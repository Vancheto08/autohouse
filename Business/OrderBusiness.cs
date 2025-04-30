using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Data;
using Data.Models;

namespace Business
{
    public class OrderBusiness
    {
        private DbContext autohouseContext;
        /// <summary>
        /// Create an instance of <see href="OrderBusiness"> with the specified context.
        /// </summary>
        /// <param name="context">An instance of DbContext.</param>
        public OrderBusiness(DbContext context)
        {
            autohouseContext = context;
        }
        /// <summary>
        /// Create an instance of <see href="OrderBusiness">.
        /// </summary>
        public OrderBusiness()
        {
            autohouseContext = new AutohouseContext();
        }
        /// <summary>
        /// Gets all the orders from the database.
        /// </summary>
        /// <returns>A list of all orders.</returns>
        public List<Order> GetAll()
        {
            return autohouseContext.Set<Order>().ToList();
        }
        /// <summary>
        /// Gets an order by its Id.
        /// </summary>
        /// <param name="id">The Id of the order to retrieve.</param>
        /// <returns>The order with the specified Id.</returns>
        public Order Get(int id)
        {
            return autohouseContext.Set<Order>().Find(id);
        }
        /// <summary>
        /// Adds a new order to the database.
        /// </summary>
        /// <param name="order">The order to add.</param>
        public void Add(Order order)
        {
            autohouseContext.Set<Order>().Add(order);
            autohouseContext.SaveChanges();
        }
        /// <summary>
        /// Updates an existing order in the database.
        /// </summary>
        /// <param name="order">The order with updated values.</param>
        public void Update(Order order)
        {
            var item = autohouseContext.Set<Order>().Find(order.OrderId);

            if (item != null)
            {
                autohouseContext.Entry(item).CurrentValues.SetValues(order);
                autohouseContext.SaveChanges();
            }
        }
        /// <summary>
        /// Deletes an order from the database by its Id.
        /// </summary>
        /// <param name="id">The Id of the order to delete.</param>
        public void Delete(int id)
        {
            var order = autohouseContext.Set<Order>().Find(id);

            if (order != null)
            {
                autohouseContext.Set<Order>().Remove(order);
                autohouseContext.SaveChanges();
            }
        }
    }
}
