using autohouse;
using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace Business
{
    public class BrandBusiness
    {
        private AutohouseContext autohouseContext;
        public List<Brand> GetAll()
        {
            using (autohouseContext = new AutohouseContext())
            {
                return autohouseContext.Brands.ToList();
            }
        }
        public Brand Get(int id)
        {
            using (autohouseContext = new AutohouseContext())
            {
                return autohouseContext.Brands.Find(id);
            }
        }
        public void Add(Brand brand)
        {
            using (autohouseContext = new AutohouseContext())
            {
                autohouseContext.Brands.Add(brand);
                autohouseContext.SaveChanges();
            }
        }
        public void Update(Brand brand)
        {
            using (autohouseContext = new AutohouseContext())
            {
                var item = autohouseContext.Brands.Find(brand.BrandId);
                if (item != null)
                {
                    autohouseContext.Entry(item).CurrentValues.SetValues(brand);
                    autohouseContext.SaveChanges();
                }
            }
        }
        public void Delete(int id)
        {
            using (autohouseContext = new AutohouseContext())
            {
                var item = autohouseContext.Brands.Find(id);
                if (item != null)
                {
                    autohouseContext.Brands.Remove(item);
                    autohouseContext.SaveChanges();
                }
            }
        }
    }
}
