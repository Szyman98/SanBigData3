using SanBigData3;
using SanBigData3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanBigDataTesting
{
    public class DataGeneratorTests
    {
        [TestCase(@"C:\Users\szyma\OneDrive\Pulpit\test.txt")]
        public void TestGenerateData(string fileLocation)
        {
            var generator = new DataGenerator();

            var firstNames = new List<NameFile>
            {
            new NameFile { Name = "Adam", Gender = "M" },
            new NameFile { Name = "Ewa", Gender = "K" }
            };


            var surnameM = new List<SurnameFile>
            {
            new SurnameFile { Surname = "Kowalski" },
            new SurnameFile { Surname = "Nowak" }
            };

            var surnameF = new List<SurnameFile>
            {
            new SurnameFile { Surname = "Wiśniewska" },
            new SurnameFile { Surname = "Kowalczyk" }
            };


            generator.GenerateData(fileLocation, firstNames, surnameM, surnameF);

            Assert.IsTrue(File.Exists(fileLocation));
            Assert.IsTrue(new FileInfo(fileLocation).Length > 0);


        }
    }
}
