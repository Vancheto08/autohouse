using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using Data;
using Data.Models;
using Effort;
using NUnit.Framework;
using NUnit.Framework.Legacy;

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
       
    }
}
