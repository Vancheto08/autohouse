using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Data;
using Data.Models;

namespace Business
{
    public class ManufacturerBusiness
    {
        private DbContext autohouseContext;
        /// <summary>
        /// Create an instance of <see href="ManufacturerBusiness"> with the specified context.
        /// </summary>
        /// <param name="context">An instance of DbContext.</param>
        public ManufacturerBusiness(DbContext context)
        {
            autohouseContext = context;
        }
        /// <summary>
        /// Create an instance of <see href="ManufacturerBusiness">.
        /// </summary>
        public ManufacturerBusiness()
        {
            autohouseContext = new AutohouseContext();
        }
        /// <summary>
        /// Gets all the manufacturers from the database.
        /// </summary>
        /// <returns>A list of all manufacturers.</returns>
        public List<Manufacturer> GetAll()
        {
            return autohouseContext.Set<Manufacturer>().ToList();
        }
        /// <summary>
        /// Gets a manufacturer by its Id.
        /// </summary>
        /// <param name="id">The Id of the manufacturer to retrieve.</param>
        /// <returns>The manufacturer with the specified Id.</returns>
        public Manufacturer Get(int id)
        {
            return autohouseContext.Set<Manufacturer>().Find(id);
        }
        /// <summary>
        /// Adds a new manufacturer to the database.
        /// </summary>
        /// <param name="manufacturer">The manufacturer to add.</param>
        public void Add(Manufacturer manufacturer)
        {
            autohouseContext.Set<Manufacturer>().Add(manufacturer);
            autohouseContext.SaveChanges();
        }
        /// <summary>
        /// Updates an existing manufacturer in the database.
        /// </summary>
        /// <param name="manufacturer">The manufacturer with updated values.</param>
        public void Update(Manufacturer manufacturer)
        {
            var item = autohouseContext.Set<Manufacturer>().Find(manufacturer.ManufacturerId);
            if (item != null)
            {
                autohouseContext.Entry(item).CurrentValues.SetValues(manufacturer);
                autohouseContext.SaveChanges();
            }
        }
        /// <summary>
        /// Deletes a manufacturer from the database by its Id.
        /// </summary>
        /// <param name="id">The Id of the manufacturer to delete.</param>
        public void Delete(int id)
        {
            var item = autohouseContext.Set<Manufacturer>().Find(id);
            if (item != null)
            {
                autohouseContext.Set<Manufacturer>().Remove(item);
                autohouseContext.SaveChanges();
            }
        }
    }
}
