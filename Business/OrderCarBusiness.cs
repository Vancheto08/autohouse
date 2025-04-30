using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Data;
using Data.Models;


namespace Business
{
    public class OrderCarBusiness
    {
        private DbContext autohouseContext;
        /// <summary>
        /// Create an instance of <see href="OrderCarBusiness"> with the specified context.
        /// </summary>
        /// <param name="context">An instance of DbContext.</param>
        public OrderCarBusiness(DbContext context)
        {
            autohouseContext = context;
        }
        /// <summary>
        /// Create an instance of <see href="OrderCarBusiness">.
        /// </summary>
        public OrderCarBusiness()
        {
            autohouseContext = new AutohouseContext();
        }
        /// <summary>
        /// Gets all order-cars from the database.
        /// </summary>
        /// <returns>A list of all order-cars.</returns>
        public List<Order_Car> GetAll()
        {
            return autohouseContext.Set<Order_Car>().ToList();
        }
        /// <summary>
        /// Gets a list of car brands with basic details from the database.
        /// </summary>
        /// <returns>A list of car brands with Id, name, price, year, and quantity.</returns>
        public List<CarBrand> GetAllCarBrand()
        {
            return autohouseContext.Set<Car>().Select(x => new CarBrand
            {
                Id = x.CarId,
                BrandName = x.Brand.Name,
                Price = x.Price,
                PublicationYear = x.PublicationYear,
                Quantity = x.Quantity
            }).ToList();
        }
        /// <summary>
        /// Gets an order-car record by order Id and car Id.
        /// </summary>
        /// <param name="orderId">The Id of the order.</param>
        /// <param name="carId">The Id of the car.</param>
        /// <returns>The order-car record that exists, if it doesn't - null.</returns>
        public Order_Car Get(int orderId, int carId)
        {
            return autohouseContext.Set<Order_Car>().Find(orderId, carId);
        }
        /// <summary>
        /// Adds a new order-car record to the database.
        /// </summary>
        /// <param name="order_Car">The order-car record to add.</param>
        public void Add(Order_Car order_Car)
        {
            autohouseContext.Set<Order_Car>().Add(order_Car);
            autohouseContext.SaveChanges();
        }
        /// <summary>
        /// Updates an existing order-car record in the database.
        /// </summary>
        /// <param name="order_Car">The order-car record with updated values.</param>
        public void Update(Order_Car order_Car)
        {
            var item = autohouseContext.Set<Order_Car>().Find(order_Car.OrderId, order_Car.CarId);

            if (item != null)
            {
                autohouseContext.Entry(item).CurrentValues.SetValues(order_Car);
                autohouseContext.SaveChanges();
            }
        }
        /// <summary>
        /// Deletes an order-car record from the database by order Id and car Id.
        /// </summary>
        /// <param name="orderId">The Id of the order.</param>
        /// <param name="carId">The Id of the car.</param>
        public void Delete(int orderId, int carId)
        {
            var item = autohouseContext.Set<Order_Car>().Find(orderId, carId);

            if (item != null)
            {
                autohouseContext.Set<Order_Car>().Remove(item);
                autohouseContext.SaveChanges();
            }
        }
    }
    /// <summary>
    /// Represents a car brand with its details such as Id, name, price, publication year, and quantity.
    /// </summary>
    public class CarBrand
    {
        /// <summary>
        /// Gets or sets the Id of the car brand.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the name of the car brand.
        /// </summary>
        public string BrandName { get; set; }
        /// <summary>
        /// Gets or sets the price of the car.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Gets or sets the publication year of the car.
        /// </summary>
        public int PublicationYear { get; set; }
        /// <summary>
        /// Gets or sets the quantity of cars available for this brand.
        /// </summary>
        public int Quantity { get; set; }
    }
}
