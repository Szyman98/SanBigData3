using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanBigData3
{
    public class ProgramFacade
    {
        private DataReader _reader;
        private DataGenerator _generator;
        private DataInsert _insert;
        public ProgramFacade()
        {
            _reader = new DataReader();
            _generator = new DataGenerator();
            _insert = new DataInsert("Server=DESKTOP-OGSKMHK\\NAUKASQL;Database=BigData4;Integrated Security=true;TrustServerCertificate=True");

        }

        public void Generate(string fileLocationToSave, string firstNamesFileLocation, string maleSurnamesFileLocation, string femaleSurnamesFileLocation)
        {
            var firstNames = _reader.GetAllFirstNames(firstNamesFileLocation);
            var surnameM = _reader.GetAllMaleSurnames(maleSurnamesFileLocation);
            var surnameF = _reader.GetAllFemaleSurnames(femaleSurnamesFileLocation);


            _generator.GenerateData(fileLocationToSave, firstNames, surnameM, surnameF);

        }

        public void InsertDataToDb(string filePath) 
        {
            _insert.InsertToDatabase(filePath);

        }
    }
}
