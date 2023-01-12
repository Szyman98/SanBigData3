using CsvHelper;
using SanBigData3.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanBigData3
{
    public class DataReader
    {

        List<NameFile> firstNames;
        List<SurnameFile> SurnameF;
        List<SurnameFile> SurnameM;



        public List<NameFile> GetAllFirstNames(string fileLocation)
        {
            using (var streamReader = new StreamReader(fileLocation))
            {
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    firstNames = csvReader.GetRecords<NameFile>().ToList();
                };
            }
            return firstNames;

        }
        public List<SurnameFile> GetAllMaleSurnames(string fileLocation)
        {
            using (var streamReader = new StreamReader(fileLocation))
            {
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    SurnameM = csvReader.GetRecords<SurnameFile>().ToList();
                };
            }
            return SurnameM;

        }
        public List<SurnameFile> GetAllFemaleSurnames(string fileLocation)
        {
            using (var streamReader = new StreamReader(fileLocation))
            {
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    SurnameF = csvReader.GetRecords<SurnameFile>().ToList();
                };
            }
            return SurnameF;

        }





    }
}
