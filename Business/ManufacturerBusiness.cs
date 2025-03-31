using System.Collections.Generic;
using System.Linq;
using Data;
using Data.Models;

namespace Business
{
    public class ManufacturerBusiness
    {
        private AutohouseContext autohouseContext;
        public List<Manufacturer> GetAll()
        {
            using (autohouseContext = new AutohouseContext())
            {
                return autohouseContext.Manufacturers.ToList();
            }
        }
        public Manufacturer Get(int id)
        {
            using (autohouseContext = new AutohouseContext())
            {
                return autohouseContext.Manufacturers.Find(id);
            }
        }

        public void Add(Manufacturer manufacturer)
        {
            using (autohouseContext = new AutohouseContext())
            {
                autohouseContext.Manufacturers.Add(manufacturer);
                autohouseContext.SaveChanges();
            }
        }

        public void Update(Manufacturer manufacturer)
        {
            using (autohouseContext = new AutohouseContext())
            {
                var item = autohouseContext.Manufacturers.Find(manufacturer.ManufacturerId);
                if (item != null)
                {
                    autohouseContext.Entry(item).CurrentValues.SetValues(manufacturer);
                    autohouseContext.SaveChanges();
                }
            }
        }
        public void Delete(int id)
        {
            using (autohouseContext = new AutohouseContext())
            {
                var item = autohouseContext.Manufacturers.Find(id);
                if (item != null)
                {
                    autohouseContext.Manufacturers.Remove(item);
                    autohouseContext.SaveChanges();
                } 
              
            }
        }

    }
}
