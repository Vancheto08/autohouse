
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Data;
using Data.Models;


namespace Business
{
    public class BrandBusiness
    {
        private DbContext autohouseContext;
        /// <summary>
        /// Creates an instance of <see href="BrandBusiness"> with the specified context.
        /// </summary>
        /// <param name="context">An instance of DbContext.</param>
        public BrandBusiness(DbContext context)
        {
            autohouseContext = context;
        }
        /// <summary>       
        /// Creates an instance of <see href="BrandBusiness">.
        /// </summary>
        public BrandBusiness()
        {
            autohouseContext = new AutohouseContext();
        }
        /// <summary>
        /// Gets all the brands from the database.
        /// </summary>
        /// <returns>A list of all brands.</returns>
        public List<Brand> GetAll()
        {
            return autohouseContext.Set<Brand>().ToList();
        }
        /// <summary>
        /// Gets a brand by its Id.
        /// </summary>
        /// <param name="id">The Id of the brand to retrieve.</param>
        /// <returns>The brand with the specified Id.</returns>
        public Brand Get(int id)
        {
            return autohouseContext.Set<Brand>().Find(id);
        }
        /// <summary>
        /// Adds a new brand to the database.
        /// </summary>
        /// <param name="brand">The brand to add.</param>
        public void Add(Brand brand)
        {
            autohouseContext.Set<Brand>().Add(brand);
            autohouseContext.SaveChanges();
        }
        /// <summary>
        /// Updates an existing brand in the database.
        /// </summary>
        /// <param name="brand">The brand with updated values.</param>
        public void Update(Brand brand)
        {
            var item = autohouseContext.Set<Brand>().Find(brand.BrandId);
            if (item != null)
            {
                autohouseContext.Entry(item).CurrentValues.SetValues(brand);
                autohouseContext.SaveChanges();
            }
        }
        /// <summary>
        /// Deletes a brand from the database by its Id.
        /// </summary>
        /// <param name="id">The Id of the brand to delete.</param>
        public void Delete(int id)
        {
            var brand = autohouseContext.Set<Brand>().Find(id);
            if (brand != null)
            {
                autohouseContext.Set<Brand>().Remove(brand);
                autohouseContext.SaveChanges();
            }
        }
    }
}
