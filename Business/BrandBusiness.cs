
using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace Business
{
    public class BrandBusiness
    {
        private DbContext autohouseContext;
        public BrandBusiness(DbContext context)
        {
            autohouseContext = context;
        }
        public BrandBusiness()
        {
            autohouseContext = new AutohouseContext();
        }
        public List<Brand> GetAll()
        {

                return autohouseContext.Set<Brand>().ToList();
            
        }
        public Brand Get(int id)
        {

                return autohouseContext.Set<Brand>().Find(id);
  
        }
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
