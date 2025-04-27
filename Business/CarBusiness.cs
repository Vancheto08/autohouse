using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Data;
using Data.Models;

namespace Business
{
    public class CarBusiness
    {
        private DbContext autohouseContext;

        public CarBusiness(DbContext context)
        {
            autohouseContext = context;
        }
        public CarBusiness()
        {
            autohouseContext = new AutohouseContext();
        }
        public List<Car> GetAll()
        {
            return autohouseContext.Set<Car>().ToList();
        }

        public Car Get(int id)
        {
            return autohouseContext.Set<Car>().Find(id);
        }

        public void Add(Car car)
        {
            autohouseContext.Set<Car>().Add(car);
            autohouseContext.SaveChanges();
        }

        public void Update(Car car)
        {
            var item = autohouseContext.Set<Car>().Find(car.CarId);
            if (item != null)
            {
                autohouseContext.Entry(item).CurrentValues.SetValues(car);
                autohouseContext.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var car = autohouseContext.Set<Car>().Find(id);
            if (car != null)
            {
                autohouseContext.Set<Car>().Remove(car);
                autohouseContext.SaveChanges();
            }
        }
    }
}
