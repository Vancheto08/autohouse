using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class OrderBusiness
    {
        private AutohouseContext autohouseContext;
        public List<Order> GetAll()
        {
            using (autohouseContext = new AutohouseContext())
            {
                return autohouseContext.Orders.ToList();
            }
        }
        public Order Get(int id)
        {
            using (autohouseContext = new AutohouseContext())
            {
                return autohouseContext.Orders.Find(id);
            }
        }
        public void Add(Order order)
        {
            using (autohouseContext = new AutohouseContext())
            {
                autohouseContext.Orders.Add(order);
                autohouseContext.SaveChanges();
            }
        }
        public void Update(Order order)
        {
            using (autohouseContext = new AutohouseContext())
            {
                var item = autohouseContext.Orders.Find(order.OrderId);
                if (item != null)
                {
                    autohouseContext.Entry(item).CurrentValues.SetValues(order);
                    autohouseContext.SaveChanges();
                }
            }
        }
        public void Delete(int id)
        {
            using (autohouseContext = new AutohouseContext())
            {
                var order = autohouseContext.Orders.Find(id);
                if (order != null)
                {
                    autohouseContext.Orders.Remove(order);
                    autohouseContext.SaveChanges();
                }
            }
        }
    }
}
