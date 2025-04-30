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
        /// <summary>
        /// Retrieves a list of orders made by customers with the specified payment method ("с карта").
        /// </summary>
        /// <param name="paymentMethod">The payment method to filter orders by ("с карта").</param>
        /// <returns>A collection of orders made with the specified payment method.</returns>
        public ICollection<Order> GetCardOrdersByCustomers(string paymentMethod = "с карта")
        {
            using (AutohouseContext context = new AutohouseContext())
            {
                var cardOrders = context.Orders.Include(o => o.Customer).
                    Where(o => o.PaymentMethod == paymentMethod).ToList();
                return cardOrders;
            }
        }
        //2
        /// <summary>
        /// Retrieves the car that has been ordered the most from the database.
        /// </summary>
        /// <returns>The most ordered car, including its brand and manufacturer details. If it doesn't exist - null.</returns>
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
        /// <summary>
        /// Retrieves the count of cars ordered by each manufacturer.
        /// </summary>
        /// <returns>A list of manufacturers with the count of cars ordered for each manufacturer.</returns>
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
        //4
        /// <summary>
        /// Retrieves a list of cars by a specific manufacturer name.
        /// </summary>
        /// <param name="manufacturerName">The name of the manufacturer to filter cars by.</param>
        /// <returns>A collection of cars that belong to the specified manufacturer.</returns>
        public ICollection<Car> GetCarsByManufacturer(string manufacturerName)
        {
            using (AutohouseContext context = new AutohouseContext())
            {
                return context.Cars.Include(c => c.Brand).Where(c => c.Brand.Manufacturer.Name == manufacturerName).ToList();
            }
        }
    }
    /// <summary>
    /// Represents the count of cars for a specific manufacturer.
    /// </summary>
    public class ManufacturerCountCars
    {
        /// <summary>
        /// Gets or sets the name of the manufacturer.
        /// </summary>
        public string ManufacturerName { get; set; }
        /// <summary>
        /// Gets or sets the number of cars ordered for this manufacturer.
        /// </summary>
        public int CarCount { get; set; }
    }
}
