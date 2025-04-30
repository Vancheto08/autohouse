
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
        /// Create an instance of <see href="BrandBusiness">with the  specified context
        /// </summary>
        /// <param name="context">instance of DbContext  </param>
        public BrandBusiness(DbContext context)
        {
            autohouseContext = context;
        }
        /// <summary>       
        /// Create an instance of <see href="BrandBusiness">
        /// </summary>
        public BrandBusiness()
        {
            autohouseContext = new AutohouseContext();
        }
        /// <summary>
        /// Get all brands
        /// </summary>
        /// <returns>List with all Brands</returns>
        public List<Brand> GetAll()
        {
            return autohouseContext.Set<Brand>().ToList();
        }
        /// <summary>
        /// Get brand by id
        /// </summary>
        /// <param name="id">ineger - id of Brand</param>
        /// <returns>value of type Brand </returns>
        public Brand Get(int id)
        {
            return autohouseContext.Set<Brand>().Find(id);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="brand"></param>
        public void Add(Brand brand)
        {
            autohouseContext.Set<Brand>().Add(brand);
            autohouseContext.SaveChanges();
        }
        public void Update(Brand brand)
        {
            var item = autohouseContext.Set<Brand>().Find(brand.BrandId);
            if (item != null)
            {
                autohouseContext.Entry(item).CurrentValues.SetValues(brand);
                autohouseContext.SaveChanges();
            }
        }
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
