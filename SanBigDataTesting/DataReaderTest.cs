using SanBigData3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanBigDataTesting
{
    public class DataReaderTest
    {
        [TestCase(@"C:\Users\szyma\OneDrive\Pulpit\imiona.csv")]
        public void TestGetAllFirstNames(string fileLocation)
        {
            // Arrange
            var reader = new DataReader();

            // Act
            var firstNames = reader.GetAllFirstNames(fileLocation);

            // Assert
            Assert.IsNotNull(firstNames);
            Assert.IsTrue(firstNames.Count > 0);
        }

        [TestCase(@"C:\Users\szyma\OneDrive\Pulpit\nazwiskaM.csv")]
        public void TestGetAllMaleSurnames(string fileLocation)
        {
            // Arrange
            var reader = new DataReader();

            // Act
            var surnames = reader.GetAllMaleSurnames(fileLocation);

            // Assert
            Assert.IsNotNull(surnames);
            Assert.IsTrue(surnames.Count > 0);
        }


        [TestCase(@"C:\Users\szyma\OneDrive\Pulpit\nazwiskaK.csv")]
        public void TestGetAllFemaleSurnames(string fileLocation)
        {
            // Arrange
            var reader = new DataReader();

            // Act
            var surnames = reader.GetAllFemaleSurnames(fileLocation);

            // Assert
            Assert.IsNotNull(surnames);
            Assert.IsTrue(surnames.Count > 0);
        }





    }
}
