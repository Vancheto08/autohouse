using System.Collections.Generic;
using System.Linq;
using Data;
using Data.Models;

namespace Business
{
    public class CarBusiness
    {
        private AutohouseContext autohouseContext;

        public List<Car> GetAll()
        {
            using (autohouseContext = new AutohouseContext())
            {
                return autohouseContext.Cars.ToList();
            }

        }

        public Car Get(int id)
        {
            using (autohouseContext = new AutohouseContext())
            {
                return autohouseContext.Cars.Find(id);
            }
        }

        public void Add(Car car)
        {
            using (autohouseContext = new AutohouseContext())
            {
                autohouseContext.Cars.Add(car);
                autohouseContext.SaveChanges();
            }
        }

        public void Update(Car car)
        {
            using (autohouseContext = new AutohouseContext())
            {
                var item = autohouseContext.Cars.Find(car.CarId);
                if (car != null)
                {
                    autohouseContext.Entry(item).CurrentValues.SetValues(car);
                    autohouseContext.SaveChanges();
                }
            }
        }

        public void Delete(int id)
        {
            using (autohouseContext = new AutohouseContext())
            {
                var car = autohouseContext.Cars.Find(id);
                if (car != null)
                {
                    autohouseContext.Cars.Remove(car);
                    autohouseContext.SaveChanges();
                }
            }
        }
    }
}
