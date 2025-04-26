using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class OrderBusiness
    {
        private DbContext autohouseContext;
        public OrderBusiness(DbContext context)
        {
            autohouseContext = context;
        }
        public OrderBusiness()
        {
            autohouseContext = new AutohouseContext();
        }
        public List<Order> GetAll()
        {
            
                return autohouseContext.Set<Order>().ToList();
            
        }
        public Order Get(int id)
        {
            
                return autohouseContext.Set<Order>().Find(id);
            
        }
        public void Add(Order order)
        {
            
                autohouseContext.Set<Order>().Add(order);
                autohouseContext.SaveChanges();
            
        }
        public void Update(Order order)
        {
           
                var item = autohouseContext.Set<Order>().Find(order.OrderId);
                if (item != null)
                {
                    autohouseContext.Entry(item).CurrentValues.SetValues(order);
                    autohouseContext.SaveChanges();
                }
            
        }
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
