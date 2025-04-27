using Business;
using Data;
using Data.Models;
using Effort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;

namespace AutohouseTests
{
    [TestFixture]
    public class BrandTests
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Structure", "NUnit1032:An IDisposable field/property should be Disposed in a TearDown method", Justification = "<Pending>")]
        private AutohouseContext context;
        private BrandBusiness brandBusiness;

        [SetUp]
        public void Setup()
        {
            var connection = DbConnectionFactory.CreateTransient();
            context = new AutohouseContext(connection);
            brandBusiness= new BrandBusiness(context);
        }
        [Test]
        public void GetAllReturnsAllBrands()
        {
            // Arrange
            var manufacturer1 = new Manufacturer { ManufacturerId = 1, Name = "Manufacturer1", Country = "Country1", Brands = null};
            context.Manufacturers.Add(manufacturer1);
            context.SaveChanges();
            var brand1 = new Brand { BrandId = 1, Name = "Brand1", ManufacturerId = 1, Cars=null, Manufacturer =null};
            var brand2 = new Brand { BrandId = 2, Name = "Brand2",
                ManufacturerId = 1,
                Cars = null,
                Manufacturer= null
            };
      
            context.Brands.Add(brand1);
            context.Brands.Add(brand2);
            context.SaveChanges();
            // Act
            var result = brandBusiness.GetAll();
            // Assert
            ClassicAssert.AreEqual(2, result.Count);

        }
        [Test]
        public void GetReturnsBrand()
        {   // Arrange
            var manufacturer = new Manufacturer { ManufacturerId = 1, Name = "Manufacturer1", Country = "Country1", Brands = null };
            context.Manufacturers.Add(manufacturer);
            context.SaveChanges();
            var brand = new Brand { BrandId = 1, Name = "Brand1", ManufacturerId = 1, Cars = null, Manufacturer = null };
            context.Brands.Add(brand);
            context.SaveChanges();
            // Act
            var result = brandBusiness.Get(1);
            // Assert
            ClassicAssert.AreEqual(brand.BrandId, result.BrandId);
        }
      
      
    }
}
