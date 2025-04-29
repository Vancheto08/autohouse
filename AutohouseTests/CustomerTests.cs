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
    public class CustomerTests
    {


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Structure", "NUnit1032:An IDisposable field/property should be Disposed in a TearDown method", Justification = "<Pending>")]
        private AutohouseContext context;
        private CustomerBusiness customerBusiness;

        [SetUp]
        public void Setup()
        {
            var connection = DbConnectionFactory.CreateTransient();
            context = new AutohouseContext(connection);
            customerBusiness = new CustomerBusiness(context);

        }

        [Test]
        public void GetAllReturnsAllManufacturers()
        {
            // Arrange
            var customer1 = new Customer { CustomerId = 1, FirstName = "FName1", LastName = "LName1", PhoneNumber = "086***", Address ="str.****", Orders =null };
            var customer2 = new Customer { CustomerId = 1, FirstName = "FName2", LastName = "LName2", PhoneNumber = "086***2", Address ="str.****2", Orders =null };
            context.Customers.Add(customer1);
           context.Customers.Add(customer2);
            context.SaveChanges();
            //Act
            var result = customerBusiness.GetAll();
            // Assert
            ClassicAssert.AreEqual(2, result.Count);
        }

        [Test]
        public void GetReturnsCustomer()
        {   // Arrange
            var manufacturer = new Manufacturer { ManufacturerId = 1, Name = "Manufacturer1", Country = "Country1", Brands = null };
            var customer = new Customer { CustomerId = 1, FirstName = "FName1", LastName = "LName1", PhoneNumber = "086***", Address = "str.****", Orders = null };
            context.Customers.Add(customer);
            context.SaveChanges();
            // Act
            var result = customerBusiness.Get(1);
            // Assert
            ClassicAssert.AreEqual(customer.CustomerId, result.CustomerId);
        }

        [Test]
        public void TryAddCustomer()
        {
            // Arrange
            var customer = new Customer { CustomerId = 1, FirstName = "FName1", LastName = "LName1", PhoneNumber = "086***", Address = "str.****", Orders = null };
            context.SaveChanges();
            //Act
            customerBusiness.Add(customer);
            var result = context.Customers.FirstOrDefault(c => c.CustomerId == customer.CustomerId);
            // Assert
            ClassicAssert.NotNull(result);
            ClassicAssert.AreEqual(customer.FirstName, result.FirstName);
        }

        [Test]
        public void TryDeleteManufacturer()
        {
            //Arrange
            var customer = new Customer { CustomerId = 1, FirstName = "FName1", LastName = "LName1", PhoneNumber = "086***", Address = "str.****", Orders = null };
            context.Customers.Add(customer);
            context.SaveChanges();
            //Act
            customerBusiness.Delete(customer.CustomerId);
            var result = context.Customers.FirstOrDefault(c => c.CustomerId == customer.CustomerId);
            //Assert
            ClassicAssert.IsNull(result);
        }

        [Test]
        public void TryUpdateManufacturer()
        {
            //Arrange
            var customer = new Customer { CustomerId = 1, FirstName = "FName1", LastName = "LName1", PhoneNumber = "086***", Address = "str.****", Orders = null };
            context.Customers.Add(customer);
            context.SaveChanges();
            //Act
            var updateCustomer = new Customer { CustomerId = 1, FirstName = "FName1", LastName = "LName1", PhoneNumber = "086***", Address = "str.****", Orders = null };
            var result = context.Customers.FirstOrDefault(c => c.CustomerId == updateCustomer.CustomerId);
            //Assert
            ClassicAssert.NotNull(result);
            ClassicAssert.AreEqual(customer.FirstName, result.FirstName);
        }

    }
}
