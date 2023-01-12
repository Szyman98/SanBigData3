
using SanBigData3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanBigData3.Test
{

    public class BaseHelperTests
    {
        [Test]
        public void TestGetPersonId()
        {
            // Arrange
            var nameToFind = new FullName { FirstName = "MYRON", LastName = "DROZD-DROZDOWSKI" };
            var connectionString = "Server=DESKTOP-OGSKMHK\\NAUKASQL;Database=BigData4;Integrated Security=true;TrustServerCertificate=True";

            // Act
            var personId = BaseHelper.GetPersonId(nameToFind, connectionString);

            // Assert
            Assert.AreEqual(35000000, personId);
        }

        [Test]
        public void TestGetPersonId2()
        {
            // Arrange
            var nameToFind = new FullName { FirstName = "MYRON", LastName = "DROZD-DROZDOWSKI" };
            var connectionString = "Server=DESKTOP-OGSKMHK\\NAUKASQL;Database=BigData4;Integrated Security=true;TrustServerCertificate=True";

            // Act
            var personId = BaseHelper.GetPersonId2(nameToFind, connectionString);

            // Assert
            Assert.AreEqual(35000000, personId);

        }

    }
}
