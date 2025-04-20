using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business
{
    public class QueryBusiness
    {
        //1
        public ICollection<Order> GetCardOrdersByCustomers(string paymentMethod = "с карта")
        {
            using (AutohouseContext context = new AutohouseContext())
            {
                var cardOrders = context.Orders.Where(o => o.PaymentMethod == paymentMethod).ToList();
                foreach (var order in cardOrders)
                {
                    var customer = context.Customers.FirstOrDefault(c => c.CustomerId == order.CustomerId);
                    if (customer != null)
                    {
                        order.Customer.FirstName = customer.FirstName;
                        order.Customer.LastName = customer.LastName;
                    }
                }
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

        //3
        public ICollection<Car> GetCarsByManufacturer(string manufacturerName)
        {
            using (AutohouseContext context = new AutohouseContext())
            {
                return context.Cars.Where(c => c.Brand.Manufacturer.Name == manufacturerName).ToList();
            }
        }

        //4
        public ICollection<Car> getCarCountByManufacturer()
        {
            using (AutohouseContext context = new AutohouseContext())
            {
                var carCountByManufacturer = context.Orders_Cars
                    .GroupBy(oc => oc.Car.Brand.Manufacturer.Name)
                    .Select(group => new
                    {
                        ManufacturerName = group.Key,
                        CarCount = group.Count()
                    })
                    .ToList();

                return (ICollection<Car>)carCountByManufacturer;
            }
        }
    }
}
