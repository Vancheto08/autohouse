using Business;
using Data;
using Data.Models;
using Effort;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using ServiceStack;
using System;
using System.Linq;
using DbConnectionFactory = Effort.DbConnectionFactory;

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
            brandBusiness = new BrandBusiness(context);
        }
        [Test]
        public void GetAllReturnsAllBrands()
        {
            // Arrange
            var manufacturer1 = new Manufacturer { ManufacturerId = 1, Name = "Manufacturer1", Country = "Country1", Brands = null };
            context.Manufacturers.Add(manufacturer1);
            context.SaveChanges();
            var brand1 = new Brand { BrandId = 1, Name = "Brand1", ManufacturerId = 1, Cars = null, Manufacturer = null };
            var brand2 = new Brand
            {
                BrandId = 2,
                Name = "Brand2",
                ManufacturerId = 1,
                Cars = null,
                Manufacturer = null
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
        [Test]
        public void TryAddBrand()
        {
            // Arrange
            var manufacturer = new Manufacturer { ManufacturerId = 1, Name = "Manufacturer1", Country = "Country1", Brands = null };
            context.Manufacturers.Add(manufacturer);
            context.SaveChanges();

            var brand = new Brand { BrandId = 1, Name = "Brand1", ManufacturerId = 1, Cars = null, Manufacturer = null };
            context.SaveChanges();
            //Act
            brandBusiness.Add(brand);
            var result = context.Brands.FirstOrDefault(b => b.BrandId == brand.BrandId);
            // Assert
            ClassicAssert.NotNull(result);
            ClassicAssert.AreEqual(brand.Name, result.Name);
        }
        [Test]
        public void TryDeleteBrand()
        {
            //Arrange
            var manufacturer = new Manufacturer { ManufacturerId = 1, Name = "Manufacturer1", Country = "Country1", Brands = null };
            context.Manufacturers.Add(manufacturer);
            context.SaveChanges();

            var brand = new Brand { BrandId = 1, Name = "Brand1", ManufacturerId = 1 };
            context.Brands.Add(brand);
            context.SaveChanges();
            //Act
            brandBusiness.Delete(brand.BrandId);
            var result = context.Brands.FirstOrDefault(b => b.BrandId == brand.BrandId);
            //Assert
            ClassicAssert.IsNull(result);
        }
        [Test]
        public void TryUpdateBrand()
        {
            //Arrange
            var manufacturer = new Manufacturer { ManufacturerId = 1, Name = "Manufacturer1", Country = "Country1", Brands = null };
            context.Manufacturers.Add(manufacturer);
            context.SaveChanges();

            var brand = new Brand { BrandId = 1, Name = "Brand1", ManufacturerId = 1 };
            context.Brands.Add(brand);
            context.SaveChanges();
            //Act
            var updateBrand = new Brand { BrandId = 1, Name = "UpdatedBrand", ManufacturerId = 1 };
            var result = context.Brands.FirstOrDefault(b=>b.BrandId == updateBrand.BrandId);
            //Assert
            ClassicAssert.NotNull(result);
            ClassicAssert.AreEqual(brand.Name, result.Name);
        }
    }
}
