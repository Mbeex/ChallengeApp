using ChallengeApp;
using System;

Console.WriteLine("Witamy w programie XYZ do oceny pracownikow");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee1 = new Employee("Maja", "Obuchowska");

//try
//{
//    Employee emp = null;
//    //var name = emp.Surname;
//}
//catch (Exception exception)
//{
//    Console.WriteLine(exception.Message);
//}
//finally
//{
//   Console.WriteLine("Finally here");
//}


while (true)
{
    Console.WriteLine("Podaj kolejna ocene pracownika");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        employee1.AddGrade(input);

    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}
var statistics = employee1.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Ogólna ocena pracwonika: {statistics.AverageLetter}");


//employee1.AddGrade(input);





