using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Business;
using Data;
using Data.Models;
using Effort;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using ServiceStack.Script;

namespace AutohouseTests
{
    [TestFixture]
    public class OrderTests
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Structure", "NUnit1032:An IDisposable field/property should be Disposed in a TearDown method", Justification = "<Pending>")]
        private AutohouseContext context;
        private OrderBusiness orderBusiness;

        [SetUp]
        public void Setup()
        {
            var connection = DbConnectionFactory.CreateTransient();
            context = new AutohouseContext(connection);
            orderBusiness = new OrderBusiness(context);
        }
        [Test]
        public void GetAllReturnsAllOrders()
        {
            // Arrange
            var customer = new Customer { CustomerId = 1, FirstName = "FName1", LastName = "LName1", PhoneNumber = "086***", Address = "str.****", Orders = null };
            context.Customers.Add(customer);
            context.SaveChanges();
            var customer2 = new Customer { CustomerId = 2, FirstName = "FName2", LastName = "LName2", PhoneNumber = "086***22", Address = "str.****2", Orders = null };
            context.Customers.Add(customer2);
            context.SaveChanges();

            var order = new Order { OrderId = 1, CustomerId = 1, Customer = customer, OrderDate = DateTime.Now, PaymentMethod = "с карта", ShippingAddress = "str. ***", Order_Cars = null };
            var order2 = new Order { OrderId = 1, CustomerId = 1, Customer = customer2, OrderDate = DateTime.Now, PaymentMethod = "в брой", ShippingAddress = "str.О ***2", Order_Cars = null };
            context.Orders.Add(order);
            context.Orders.Add(order2);
            context.SaveChanges();
            // Act
            var result = orderBusiness.GetAll();
            // Assert
            ClassicAssert.AreEqual(2, result.Count);

        }
        [Test]
        public void GetReturnsOrder()
        {   // Arrange
            var customer = new Customer { CustomerId = 1, FirstName = "FName1", LastName = "LName1", PhoneNumber = "086***", Address = "str.****", Orders = null };
            context.Customers.Add(customer);
            context.SaveChanges();
            var order = new Order { OrderId = 1, CustomerId = 1, Customer = customer, OrderDate = DateTime.Now, PaymentMethod = "с карта", ShippingAddress = "str. ***", Order_Cars = null };
            context.Orders.Add(order);
            context.SaveChanges();
            // Act
            var result = orderBusiness.Get(1);
            // Assert
            ClassicAssert.AreEqual(order .OrderId, result.OrderId);
        }
        [Test]
        public void TryAddOrder()
        {
            // Arrange
            var customer = new Customer { CustomerId = 1, FirstName = "FName1", LastName = "LName1", PhoneNumber = "086***", Address = "str.****", Orders = null };
            context.Customers.Add(customer);
            context.SaveChanges();
            var order = new Order { OrderId = 1, CustomerId = 1, Customer = customer, OrderDate = DateTime.Now, PaymentMethod = "с карта", ShippingAddress = "str. ***", Order_Cars = null };
            context.Orders.Add(order);
            context.SaveChanges();
            //Act
            orderBusiness.Add(order);
            var result = context.Orders.FirstOrDefault(o => o.OrderId == order.OrderId);
            // Assert
            ClassicAssert.NotNull(result);
            ClassicAssert.AreEqual(order.OrderId, result.OrderId);
        }

        [Test]
        public void TryDeleteOrder()
        {
            //Arrange
            var customer = new Customer { CustomerId = 1, FirstName = "FName1", LastName = "LName1", PhoneNumber = "086***", Address = "str.****", Orders = null };
            context.Customers.Add(customer);
            context.SaveChanges();

            var order = new Order { OrderId = 1, CustomerId = 1, Customer = customer, OrderDate = DateTime.Now, PaymentMethod = "с карта", ShippingAddress = "str. ***", Order_Cars = null };
            context.Orders.Add(order);
            context.SaveChanges();
            //Act
            orderBusiness.Delete(order.OrderId);
            var result = context.Orders.FirstOrDefault(o => o.OrderId == order.OrderId);
            //Assert
            ClassicAssert.IsNull(result);
        }

        [Test]
        public void TryUpdateOrder()
        {
            //Arrange
            var customer = new Customer { CustomerId = 1, FirstName = "FName1", LastName = "LName1", PhoneNumber = "086***", Address = "str.****", Orders = null };
            context.Customers.Add(customer);
            context.SaveChanges();
            var order = new Order { OrderId = 1, CustomerId = 1, Customer = customer, OrderDate = DateTime.Now, PaymentMethod = "с карта", ShippingAddress = "str. ***", Order_Cars = null };
            context.Orders.Add(order);
            context.SaveChanges();
            //Act
            var updateOrder = new Order { OrderId = 1, CustomerId = 1, Customer = customer, OrderDate = DateTime.Now, PaymentMethod = "в борй", ShippingAddress = "str. ***2", Order_Cars = null };
            var result = context.Orders.FirstOrDefault(o => o.OrderId == updateOrder.OrderId);
            //Assert
            ClassicAssert.NotNull(result);
            ClassicAssert.AreEqual(order.OrderId, result.OrderId);
        }
    }
}
