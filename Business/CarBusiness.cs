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
        /// <summary>
        /// Create an instance of <see href="CarBusiness"> with the specified context.
        /// </summary>
        /// <param name="context">An instance of DbContext.</param>
        public CarBusiness(DbContext context)
        {
            autohouseContext = context;
        }
        /// <summary>
        /// Create an instance of <see href="CarBusiness">.
        /// </summary>
        public CarBusiness()
        {
            autohouseContext = new AutohouseContext();
        }
        /// <summary>
        /// Gets all the cars from the database.
        /// </summary>
        /// <returns>A list of all cars.</returns>
        public List<Car> GetAll()
        {
            return autohouseContext.Set<Car>().ToList();
        }
        /// <summary>
        /// Gets a car by its Id.
        /// </summary>
        /// <param name="id">The Id of the car to retrieve.</param>
        /// <returns>The car with the specified Id.</returns>
        public Car Get(int id)
        {
            return autohouseContext.Set<Car>().Find(id);
        }
        /// <summary>
        /// Adds a new car to the database.
        /// </summary>
        /// <param name="car">The car to add.</param>
        public void Add(Car car)
        {
            autohouseContext.Set<Car>().Add(car);
            autohouseContext.SaveChanges();
        }
        /// <summary>
        /// Updates an existing car in the database.
        /// </summary>
        /// <param name="car">The car with updated values.</param>
        public void Update(Car car)
        {
            var item = autohouseContext.Set<Car>().Find(car.CarId);
            if (item != null)
            {
                autohouseContext.Entry(item).CurrentValues.SetValues(car);
                autohouseContext.SaveChanges();
            }
        }
        /// <summary>
        /// Deletes a car from the database by its Id.
        /// </summary>
        /// <param name="id">The Id of the car to delete.</param>
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
