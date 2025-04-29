using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Data.Models;
using NUnit.Framework.Legacy;
using Data;
using Business;
using Effort;
using System.Data.Common;

namespace AutohouseTests
{
    [TestFixture]
    public class CarTests
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Structure", "NUnit1032:An IDisposable field/property should be Disposed in a TearDown method", Justification = "<Pending>")]
        private AutohouseContext context;
        private CarBusiness carBusiness;

        [SetUp]
        public void Setup()
        {
            var connection = DbConnectionFactory.CreateTransient();
            context = new AutohouseContext(connection);
            carBusiness = new CarBusiness(context);
        }
        [Test]
        public void GetAllReturnsAllBrands()
        {
            //Arrange
            var brand = new Brand { BrandId = 1, Name = "Brand1", ManufacturerId = 1, Manufacturer = null, Cars = null };
            context.Brands.Add(brand);
            context.SaveChanges();

            var car1 = new Car { CarId = 1, BrandId = 1, Brand = brand, Price = 10000, PublicationYear = 2020, Quantity = 5, Order_Cars = null };
            var car2 = new Car { CarId = 2, BrandId = 1, Brand = brand, Price = 12000, PublicationYear = 2021, Quantity = 3, Order_Cars = null };
            context.Cars.Add(car1);
            context.Cars.Add(car2);
            context.SaveChanges();
            //Act
            var result = carBusiness.GetAll();
            //Assert
            ClassicAssert.AreEqual(2, result.Count);
        }
        [Test]
        public void GetReturnsCars()
        {
            //Arrange
            var brand = new Brand { BrandId = 1, Name = "Brand1" };
            context.Brands.Add(brand);
            context.SaveChanges();

            var car1 = new Car { CarId = 1, BrandId = 1, Brand = brand, Price = 10000, PublicationYear = 2020, Quantity = 5 };
            var car2 = new Car { CarId = 2, BrandId = 1, Brand = brand, Price = 12000, PublicationYear = 2021, Quantity = 3 };
            context.Cars.Add(car1);
            context.Cars.Add(car2);
            context.SaveChanges();
            //Act
            var result = carBusiness.Get(1);
            //Assert
            ClassicAssert.AreEqual(car1.CarId, result.CarId);
        }
        [Test]
        public void TryAddcar()
        {
            //Arrange
            var brand = new Brand { BrandId = 1, Name = "Brand1" };
            context.Brands.Add(brand);
            context.SaveChanges();
            var car = new Car { CarId = 1, BrandId = 1, Brand = brand, Price = 10000, PublicationYear = 2020, Quantity = 5 };
            //Act
            var result = context.Cars.FirstOrDefault(c => c.CarId == car.CarId);
            //Assert
            ClassicAssert.NotNull(result);
            ClassicAssert.AreEqual(car.CarId, result.CarId);
        }
    }
}
