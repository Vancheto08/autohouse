using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data;
using System.Data.Entity;


namespace Business
{
    public class OrderCarBusiness
    {
        private DbContext autohouseContext;
        public OrderCarBusiness(DbContext context)
        {
            autohouseContext = context;
        }
        public OrderCarBusiness()
        {
            autohouseContext = new AutohouseContext();
        }

        public List<Order_Car> GetAll()
        {
           
                return autohouseContext.Set<Order_Car>().ToList();
            
        }

        public List<CarBrand> GetAllCarBrand()
        {
            
                return autohouseContext.Set<Car>().Select(x => new CarBrand { Id = x.CarId, 
                    BrandName= x.Brand.Name, Price= x.Price, PublicationYear= x.PublicationYear, 
                    Quantity=x.Quantity }).ToList();
            
        }
        

        public Order_Car Get(int orderId, int carId)
        {
            
                return autohouseContext.Set<Order_Car>().Find(orderId, carId);
            
        }

        public void Add(Order_Car order_Car)
        {
            
                autohouseContext.Set<Order_Car>().Add(order_Car);
                autohouseContext.SaveChanges();
            
        }

        public void Update(Order_Car order_Car)
        {
            
               var item = autohouseContext.Set<Order_Car>().Find( order_Car.OrderId, order_Car.CarId);
              
                if (item != null)
                {
                    autohouseContext.Entry(item).CurrentValues.SetValues(order_Car);
                    autohouseContext.SaveChanges();
                }
            
        }

        public void Delete( int orderId, int carId )
        {
           
                var item = autohouseContext.Set<Order_Car>().Find(orderId,carId);
                if (item != null)
                {
                    autohouseContext.Set<Order_Car>().Remove(item);
                    autohouseContext.SaveChanges();
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
