


using SanBigData3;
using SanBigData3.Models;
using System.Diagnostics;

string conString = "Server=DESKTOP-OGSKMHK\\NAUKASQL;Database=BigData4;Integrated Security=true;TrustServerCertificate=True";
Stopwatch sw = new();
sw.Start();

//ProgramFacade facade = new ProgramFacade();


//string fileLocationToSave = @"C:\Users\szyma\OneDrive\Pulpit\FullNames2.csv";
//string firstNamesFileLocation = @"C:\Users\szyma\OneDrive\Pulpit\imiona.csv";
//string maleSurnamesFileLocation = @"C:\Users\szyma\OneDrive\Pulpit\nazwiskaM.csv";
//string femaleSurnamesFileLocation = @"C:\Users\szyma\OneDrive\Pulpit\nazwiskaK.csv";

//facade.Generate(fileLocationToSave, firstNamesFileLocation, maleSurnamesFileLocation, femaleSurnamesFileLocation);

//facade.InsertDataToDb(fileLocationToSave);

//sw.Stop();



//Console.WriteLine(sw.ElapsedMilliseconds.ToString());




FullName n = new FullName();
//InsertClass.InsertData(filePath);
Console.WriteLine("Podaj imie");
n.FirstName = Console.ReadLine();
Console.WriteLine("Podaj nazwisko");
n.LastName = Console.ReadLine();


sw.Start();
var returnedId = BaseHelper.GetPersonId(n, conString);
sw.Stop();
Console.WriteLine(returnedId.ToString());
Console.WriteLine("----");
Console.WriteLine(sw.ElapsedMilliseconds.ToString());



Console.ReadLine();

