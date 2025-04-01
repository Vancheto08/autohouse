using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data;


namespace Business
{
    public class OrderCarBusiness
    {
        private AutohouseContext autohouseContext;

        public List<Order_Car> GetAll(int id)
        {
            using (autohouseContext = new AutohouseContext())
            {
                return autohouseContext.Orders_Cars.ToList();
            }
        }

        public Order_Car Get(int id)
        {
            using (autohouseContext = new AutohouseContext())
            {
                return autohouseContext.Orders_Cars.Find(id);
            }
        }

        public void Add(Order_Car order_Car)
        {
            using (autohouseContext = new AutohouseContext())
            {
                autohouseContext.Orders_Cars.Add(order_Car);
                autohouseContext.SaveChanges();
            }
        }

        public void Update(Order_Car order_Car)
        {
            using (autohouseContext = new AutohouseContext())
            {
               var item = autohouseContext.Orders_Cars.Find(order_Car.CarId);
                //var item = autohouseContext.Orders_Cars.Find(order_Car.OrderId);
                if (item != null)
                {
                    autohouseContext.Entry(item).CurrentValues.SetValues(order_Car);
                    autohouseContext.SaveChanges();
                }
            }
        }

        public void Delete(int id)
        {
            using (autohouseContext = new AutohouseContext())
            {
                var item = autohouseContext.Orders_Cars.Find(id);
                if (item != null)
                {
                    autohouseContext.Orders_Cars.Remove(item);
                    autohouseContext.SaveChanges();
                }

            }
        }
    }
}
