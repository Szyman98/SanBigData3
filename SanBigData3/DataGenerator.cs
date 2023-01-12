using SanBigData3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanBigData3
{
    public class DataGenerator
    {
        public void GenerateData(string fileLocationToSave, List<NameFile> firstNames, List<SurnameFile> SurnameM, List<SurnameFile> SurnameF)
        {

            Random random = new();
            using (var stream = File.OpenWrite(fileLocationToSave))
            {
                using (var writer = new StreamWriter(stream))
                {
                    int i = 0;

                    while (i != 40_000_000)
                    {
                        var randomFirstNameRow = random.Next(firstNames.Count);
                        var selectedFirstName = firstNames[randomFirstNameRow];

                        if (selectedFirstName.Gender == "M")
                        {
                            var randomSurnameRow = random.Next(SurnameM.Count);
                            writer.WriteLine($"{selectedFirstName.Name},{SurnameM[randomSurnameRow].Surname}");
                        }

                        if (selectedFirstName.Gender == "K")
                        {
                            var randomSurnameRow = random.Next(SurnameF.Count);
                            writer.WriteLine($"{selectedFirstName.Name},{SurnameF[randomSurnameRow].Surname}");
                        }
                        i++;

                    }
                }
            }
        }
    }
}
