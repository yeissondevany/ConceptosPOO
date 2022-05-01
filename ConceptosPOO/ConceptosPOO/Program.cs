// See https://aka.ms/new-console-template for more information
using ConceptosPOO;

Console.WriteLine("POO concepts");
//Date date1 = new Date(2022, 04, 29);
try
{
    Console.WriteLine(new Date(2021, 2, 28));
    Console.WriteLine(new Date(2012, 2, 29));
    Console.WriteLine(new Date(2022, 2, 29));
    Console.WriteLine(new Date(2025, 14, 33));
}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}
