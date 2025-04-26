using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Data;
using Data.Models;

namespace Business
{
    public class QueryBusiness
    {
        //1
        public ICollection<Order> GetCardOrdersByCustomers(string paymentMethod = "с карта")
        {
            using (AutohouseContext context = new AutohouseContext())
            {
                var cardOrders = context.Orders.Include(o=>o.Customer).                    
                    Where(o => o.PaymentMethod == paymentMethod).ToList();
                return cardOrders;
            }
        }

        //2
        public Car GetMostOrderedCar()
        {
            using (AutohouseContext context = new AutohouseContext())
            {
                var mostOrderedCar = context.Orders_Cars
                    .GroupBy(oc => oc.CarId)
                    .Select(group => new
                    {
                        CarId = group.Key,
                        OrderCount = group.Count()
                    })
                    .OrderByDescending(g => g.OrderCount)
                    .FirstOrDefault();
                if (mostOrderedCar != null)
                {
                    return context.Cars
                        .Where(c => c.CarId == mostOrderedCar.CarId)
                        .Include(c => c.Brand)
                        .Include(c => c.Brand.Manufacturer)
                        .FirstOrDefault();
                }

                return null;
            }
        }

        //4
        public ICollection<Car> GetCarsByManufacturer(string manufacturerName)
        {
            using (AutohouseContext context = new AutohouseContext())
            {
                return context.Cars.Include(c=>c.Brand).Where(c => c.Brand.Manufacturer.Name == manufacturerName).ToList();
            }
        }

        //3
        public List<ManufacturerCountCars> GetCarCountByManufacturer()
        {
            using (AutohouseContext context = new AutohouseContext())
            {
                var carCountByManufacturer = context.Orders_Cars
                    .GroupBy(oc => oc.Car.Brand.Manufacturer.Name)
                    .Select(group => new ManufacturerCountCars
                    {
                        ManufacturerName = group.Key,
                        CarCount = group.Count()
                    })
                    .ToList();

                return carCountByManufacturer;
            }
        }
    }
    public class ManufacturerCountCars
    {
        public string ManufacturerName { get; set; }
        public int CarCount { get; set; }
    }
    public class CarsByManufacturer
    {
        public string ManufacturerName { get; set; }

    }
}
