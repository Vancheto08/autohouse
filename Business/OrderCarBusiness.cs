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

        public List<Order_Car> GetAll()
        {
            using (autohouseContext = new AutohouseContext())
            {
                return autohouseContext.Orders_Cars.ToList();
            }
        }

        public List<CarBrand> GetAllCarBrand()
        {
            using (autohouseContext = new AutohouseContext())
            {
                return autohouseContext.Cars.Select(x => new CarBrand { Id = x.CarId, 
                    BrandName= x.Brand.Name, Price= x.Price, PublicationYear= x.PublicationYear, 
                    Quantity=x.Quantity }).ToList();
            }
        }
        

        public Order_Car Get(int orderId, int carId)
        {
            using (autohouseContext = new AutohouseContext())
            {
                return autohouseContext.Orders_Cars.Find(orderId, carId);
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
               var item = autohouseContext.Orders_Cars.Find( order_Car.OrderId, order_Car.CarId);
              
                if (item != null)
                {
                    autohouseContext.Entry(item).CurrentValues.SetValues(order_Car);
                    autohouseContext.SaveChanges();
                }
            }
        }

        public void Delete( int orderId, int carId )
        {
            using (autohouseContext = new AutohouseContext())
            {
                var item = autohouseContext.Orders_Cars.Find(orderId,carId);
                if (item != null)
                {
                    autohouseContext.Orders_Cars.Remove(item);
                    autohouseContext.SaveChanges();
                }

            }
        }

    }
    public class CarBrand
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public decimal Price { get; set; }
        public int PublicationYear { get; set; }
        public int Quantity { get; set; }
    }
}
