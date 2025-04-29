using Business;
using Data;
using Effort;
using NUnit.Framework;

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
        }
    }
}
