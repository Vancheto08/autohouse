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
            context = new AutohouseContext();
            carBusiness = new CarBusiness(context);
        }
    }
}
