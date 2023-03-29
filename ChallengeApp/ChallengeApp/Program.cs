using ChallengeApp;

Console.WriteLine("Witamy w programie XYZ do oceny pracownikow");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee1 = new Employee("Maja", "Obuchowska");

while (true)
{
    Console.WriteLine("Podaj kolejna ocene pracownika");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    employee1.AddGrade(input);

}
var statistics = employee1.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Ogólna ocena pracwonika: {statistics.AverageLetter}");


//employee1.AddGrade(input);





