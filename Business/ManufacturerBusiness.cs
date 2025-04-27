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

        public ManufacturerBusiness(DbContext context)
        {
            autohouseContext = context;
        }
        public ManufacturerBusiness()
        {
            autohouseContext = new AutohouseContext();
        }
        public List<Manufacturer> GetAll()
        {
            return autohouseContext.Set<Manufacturer>().ToList();
        }
        public Manufacturer Get(int id)
        {
            return autohouseContext.Set<Manufacturer>().Find(id);
        }

        public void Add(Manufacturer manufacturer)
        {
            autohouseContext.Set<Manufacturer>().Add(manufacturer);
            autohouseContext.SaveChanges();
        }

        public void Update(Manufacturer manufacturer)
        {
            var item = autohouseContext.Set<Manufacturer>().Find(manufacturer.ManufacturerId);
            if (item != null)
            {
                autohouseContext.Entry(item).CurrentValues.SetValues(manufacturer);
                autohouseContext.SaveChanges();
            }
        }
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
