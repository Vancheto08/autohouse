using System;
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
    public class OrderCarTests
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Structure", "NUnit1032:An IDisposable field/property should be Disposed in a TearDown method", Justification = "<Pending>")]
        private AutohouseContext context;
        private OrderCarBusiness orderCarBusiness;

        [SetUp]
        public void Setup()
        {
            var connection = DbConnectionFactory.CreateTransient();
            context = new AutohouseContext(connection);
            orderCarBusiness = new OrderCarBusiness(context);
            //TestInfo();
        }
        [Test]
        public void GetAllReturnsAllOrderCars()
        {
            // Arrange
            var customer = new Customer { CustomerId = 1, FirstName = "FName1", LastName = "LName1", PhoneNumber = "086***", Address = "str.****" };
            context.Customers.Add(customer);
            context.SaveChanges();
            var customer2 = new Customer { CustomerId = 2, FirstName = "FName2", LastName = "LName2", PhoneNumber = "086***2", Address = "str.****2" };
            context.Customers.Add(customer2);
            context.SaveChanges();

            var manufacturer1 = new Manufacturer { ManufacturerId = 1, Name = "Manufacturer1", Country = "Country1", Brands = null };
            var manufacturer2 = new Manufacturer { ManufacturerId = 2, Name = "Manufacturer2", Country = "Country2", Brands = null };
            context.Manufacturers.Add(manufacturer1);
            context.Manufacturers.Add(manufacturer2);
            context.SaveChanges();

            var brand1 = new Brand { BrandId = 1, Name = "Brand1", ManufacturerId = 1, Cars = null, Manufacturer = manufacturer1 };
            var brand2 = new Brand { BrandId = 2, Name = "Brand2", ManufacturerId = 2, Cars = null, Manufacturer = manufacturer2 };
            context.Brands.Add(brand1);
            context.Brands.Add(brand2);
            context.SaveChanges();

            var car = new Car { CarId = 1, BrandId = 1, Brand = brand1, Price = 10000, PublicationYear = 2020, Quantity = 5 };
            context.Cars.Add(car);
            context.SaveChanges();
            var car2 = new Car { CarId = 2, BrandId = 2, Brand = brand2, Price = 20000, PublicationYear = 2020, Quantity = 3 };
            context.Cars.Add(car2);
            context.SaveChanges();

            var order = new Order { OrderId = 1, CustomerId = customer.CustomerId, Customer = customer, OrderDate = DateTime.Now, PaymentMethod = "с карта", ShippingAddress = "str. ***", Order_Cars = null };
            context.Orders.Add(order);
            context.SaveChanges();
            var order2 = new Order { OrderId = 1, CustomerId = customer2.CustomerId, Customer = customer2, OrderDate = DateTime.Now, PaymentMethod = "в брой", ShippingAddress = "str.О ***2", Order_Cars = null };
            context.Orders.Add(order2);
            context.SaveChanges();

            var orderCar = new Order_Car { OrderId = order.OrderId, CarId = car.CarId, Quantity = 3, Car = car, Order = order };
            var orderCar2 = new Order_Car { OrderId = order2.OrderId, CarId = car2.CarId, Quantity = 3, Car = car2, Order = order2 };
            context.Orders_Cars.Add(orderCar);
            context.Orders_Cars.Add(orderCar2);
            context.SaveChanges();

            // Act
            var result = orderCarBusiness.GetAll();

            // Assert
            ClassicAssert.AreEqual(2, result.Count);
        }

        [Test]
        public void GetReturnsOrderCars()
        {   // Arrange
            var customer = new Customer { CustomerId = 1, FirstName = "FName1", LastName = "LName1", PhoneNumber = "086***", Address = "str.****" };
            context.Customers.Add(customer);
            context.SaveChanges();
            var customer2 = new Customer { CustomerId = 2, FirstName = "FName2", LastName = "LName2", PhoneNumber = "086***2", Address = "str.****2" };
            context.Customers.Add(customer2);
            context.SaveChanges();

            var manufacturer1 = new Manufacturer { ManufacturerId = 1, Name = "Manufacturer1", Country = "Country1", Brands = null };
            var manufacturer2 = new Manufacturer { ManufacturerId = 2, Name = "Manufacturer2", Country = "Country2", Brands = null };
            context.Manufacturers.Add(manufacturer1);
            context.Manufacturers.Add(manufacturer2);
            context.SaveChanges();

            var brand1 = new Brand { BrandId = 1, Name = "Brand1", ManufacturerId = 1, Cars = null, Manufacturer = manufacturer1 };
            var brand2 = new Brand { BrandId = 2, Name = "Brand2", ManufacturerId = 2, Cars = null, Manufacturer = manufacturer2 };
            context.Brands.Add(brand1);
            context.Brands.Add(brand2);
            context.SaveChanges();

            var car = new Car { CarId = 1, BrandId = 1, Brand = brand1, Price = 10000, PublicationYear = 2020, Quantity = 5 };
            context.Cars.Add(car);
            context.SaveChanges();
            var car2 = new Car { CarId = 2, BrandId = 2, Brand = brand2, Price = 20000, PublicationYear = 2020, Quantity = 3 };
            context.Cars.Add(car2);
            context.SaveChanges();

            var order = new Order { OrderId = 1, CustomerId = customer.CustomerId, Customer = customer, OrderDate = DateTime.Now, PaymentMethod = "с карта", ShippingAddress = "str. ***", Order_Cars = null };
            context.Orders.Add(order);
            context.SaveChanges();
            var order2 = new Order { OrderId = 1, CustomerId = customer2.CustomerId, Customer = customer2, OrderDate = DateTime.Now, PaymentMethod = "в брой", ShippingAddress = "str.О ***2", Order_Cars = null };
            context.Orders.Add(order2);
            context.SaveChanges();

            var orderCar = new Order_Car { OrderId = order.OrderId, CarId = car.CarId, Quantity = 3, Car = car, Order = order };
            var orderCar2 = new Order_Car { OrderId = order2.OrderId, CarId = car2.CarId, Quantity = 3, Car = car2, Order = order2 };
            context.Orders_Cars.Add(orderCar);
            context.Orders_Cars.Add(orderCar2);
            context.SaveChanges();

            // Act
            var result = orderCarBusiness.Get(1, 1);

            // Assert
            ClassicAssert.AreEqual(1, result.CarId);
            ClassicAssert.AreEqual(1, result.OrderId);
        }

        [Test]
        public void TryAddOrderCar()
        {
            // Arrange
            var customer = new Customer { CustomerId = 1, FirstName = "FName1", LastName = "LName1", PhoneNumber = "086***", Address = "str.****" };
            context.Customers.Add(customer);
            context.SaveChanges();

            var manufacturer1 = new Manufacturer { ManufacturerId = 1, Name = "Manufacturer1", Country = "Country1", Brands = null };
            context.Manufacturers.Add(manufacturer1);
            context.SaveChanges();

            var brand1 = new Brand { BrandId = 1, Name = "Brand1", ManufacturerId = 1, Cars = null, Manufacturer = manufacturer1 };
            context.Brands.Add(brand1);
            context.SaveChanges();

            var car = new Car { CarId = 1, BrandId = 1, Brand = brand1, Price = 10000, PublicationYear = 2020, Quantity = 5 };
            context.Cars.Add(car);
            context.SaveChanges();

            var order = new Order { OrderId = 1, CustomerId = customer.CustomerId, Customer = customer, OrderDate = DateTime.Now, PaymentMethod = "с карта", ShippingAddress = "str. ***", Order_Cars = null };
            context.Orders.Add(order);
            context.SaveChanges();

            var orderCar = new Order_Car { OrderId = order.OrderId, CarId = car.CarId, Quantity = 3, Car = car, Order = order };
            context.Orders_Cars.Add(orderCar);
            context.SaveChanges();

            //Act
            var result = context.Orders_Cars.FirstOrDefault(o => o.OrderId == orderCar.OrderId);

            // Assert
            ClassicAssert.NotNull(result);
            ClassicAssert.AreEqual(orderCar.OrderId, result.OrderId);
        }

        [Test]
        public void TryDeleteOrderCar()
        {
            //Arrange
            var customer = new Customer { CustomerId = 1, FirstName = "FName1", LastName = "LName1", PhoneNumber = "086***", Address = "str.****" };
            context.Customers.Add(customer);
            context.SaveChanges();

            var manufacturer1 = new Manufacturer { ManufacturerId = 1, Name = "Manufacturer1", Country = "Country1", Brands = null };
            context.Manufacturers.Add(manufacturer1);
            context.SaveChanges();

            var brand1 = new Brand { BrandId = 1, Name = "Brand1", ManufacturerId = 1, Cars = null, Manufacturer = manufacturer1 };
            context.Brands.Add(brand1);
            context.SaveChanges();

            var car = new Car { CarId = 1, BrandId = 1, Brand = brand1, Price = 10000, PublicationYear = 2020, Quantity = 5 };
            context.Cars.Add(car);
            context.SaveChanges();

            var order = new Order { OrderId = 1, CustomerId = customer.CustomerId, Customer = customer, OrderDate = DateTime.Now, PaymentMethod = "с карта", ShippingAddress = "str. ***", Order_Cars = null };
            context.Orders.Add(order);
            context.SaveChanges();

            var orderCar = new Order_Car { OrderId = order.OrderId, CarId = car.CarId, Quantity = 3, Car = car, Order = order };
            context.Orders_Cars.Add(orderCar);
            context.SaveChanges();

            //Act
            orderCarBusiness.Delete(orderCar.OrderId, orderCar.CarId);
            var result = context.Orders_Cars.FirstOrDefault(oc=> oc.OrderId == orderCar.OrderId);

            //Assert
            ClassicAssert.IsNull(result);
        }

        [Test]
        public void TryUpdateOrderCar()
        {
            //Arrange
            var customer = new Customer { CustomerId = 1, FirstName = "FName1", LastName = "LName1", PhoneNumber = "086***", Address = "str.****" };
            context.Customers.Add(customer);
            context.SaveChanges();

            var manufacturer1 = new Manufacturer { ManufacturerId = 1, Name = "Manufacturer1", Country = "Country1", Brands = null };
            context.Manufacturers.Add(manufacturer1);
            context.SaveChanges();

            var brand1 = new Brand { BrandId = 1, Name = "Brand1", ManufacturerId = 1, Cars = null, Manufacturer = manufacturer1 };
            context.Brands.Add(brand1);
            context.SaveChanges();

            var car = new Car { CarId = 1, BrandId = 1, Brand = brand1, Price = 10000, PublicationYear = 2020, Quantity = 5 };
            context.Cars.Add(car);
            context.SaveChanges();

            var order = new Order { OrderId = 1, CustomerId = customer.CustomerId, Customer = customer, OrderDate = DateTime.Now, PaymentMethod = "с карта", ShippingAddress = "str. ***", Order_Cars = null };
            context.Orders.Add(order);
            context.SaveChanges();

            var orderCar = new Order_Car { OrderId = order.OrderId, CarId = car.CarId, Quantity = 3, Car = car, Order = order };
            context.Orders_Cars.Add(orderCar);
            context.SaveChanges();

            //Act
            var updateOrderCar = new Order_Car { OrderId = 2, CarId = 4, Quantity = 3, Car = car, Order = order };
            var result = context.Orders_Cars.FirstOrDefault(oc => oc.Quantity == updateOrderCar.Quantity);

            //Assert
            ClassicAssert.NotNull(result);
            ClassicAssert.AreEqual(orderCar.Quantity, result.Quantity);
        }

    }
}
