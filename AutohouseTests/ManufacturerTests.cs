using System.Linq;
using Business;
using Data;
using Data.Models;
using Effort;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace AutohouseTests
{
    [TestFixture]
    public class ManufacturerTests
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Structure", "NUnit1032:An IDisposable field/property should be Disposed in a TearDown method", Justification = "<Pending>")]
        private AutohouseContext context;
        private ManufacturerBusiness manufacturerBusiness;

        [SetUp]
        public void Setup()
        {
            var connection = DbConnectionFactory.CreateTransient();
            context = new AutohouseContext(connection);
            manufacturerBusiness = new ManufacturerBusiness(context);

        }

        [Test]
        public void GetAllReturnsAllManufacturers()
        {
            // Arrange
            var manufacturer1 = new Manufacturer { ManufacturerId = 1, Name = "Manufacturer1", Country = "Country1", Brands = null };
            var manufacturer2 = new Manufacturer { ManufacturerId = 2, Name = "Manufacturer2", Country = "Country2", Brands = null };
            context.Manufacturers.Add(manufacturer1);
            context.Manufacturers.Add(manufacturer2);
            context.SaveChanges();
            //Act
            var result = manufacturerBusiness.GetAll();
            // Assert
            ClassicAssert.AreEqual(2, result.Count);
        }
      
        [Test]
        public void GetReturnsManufacturer()
        {   // Arrange
            var manufacturer = new Manufacturer { ManufacturerId = 1, Name = "Manufacturer1", Country = "Country1", Brands = null };
            context.Manufacturers.Add(manufacturer);
            context.SaveChanges();
            // Act
            var result = manufacturerBusiness.Get(1);
            // Assert
            ClassicAssert.AreEqual(manufacturer.ManufacturerId, result.ManufacturerId);
        }

        [Test]
        public void TryAddManufacturer()
        {
            // Arrange
            var manufacturer = new Manufacturer { ManufacturerId = 1, Name = "Manufacturer1", Country = "Country1", Brands = null };
            context.SaveChanges();
            //Act
            manufacturerBusiness.Add(manufacturer);
            var result = context.Manufacturers.FirstOrDefault(m => m.ManufacturerId == manufacturer.ManufacturerId);
           // Assert
            ClassicAssert.NotNull(result);
            ClassicAssert.AreEqual(manufacturer.Name, result.Name);
        }

        [Test]
        public void TryDeleteManufacturer()
        {
            //Arrange
            var manufacturer = new Manufacturer { ManufacturerId = 1, Name = "Manufacturer1", Country = "Country1", Brands = null };
            context.Manufacturers.Add(manufacturer);
            context.SaveChanges();
            //Act
            manufacturerBusiness.Delete(manufacturer.ManufacturerId);
            var result = context.Manufacturers.FirstOrDefault(m => m.ManufacturerId == manufacturer.ManufacturerId);
            //Assert
            ClassicAssert.IsNull(result);
        }

        [Test]
        public void TryUpdateManufacturer()
        {
            //Arrange
            var manufacturer = new Manufacturer { ManufacturerId = 1, Name = "Manufacturer1", Country = "Country1", Brands = null };
            context.Manufacturers.Add(manufacturer);
            context.SaveChanges();
            //Act
            var updateManufacturer = new Manufacturer { ManufacturerId = 1, Name = "Manufacturer6", Country = "Country1", Brands = null };
            var result = context.Manufacturers.FirstOrDefault(m => m.ManufacturerId == updateManufacturer.ManufacturerId);
            //Assert
            ClassicAssert.NotNull(result);
            ClassicAssert.AreEqual(manufacturer.Name, result.Name);
        }
    }
}
