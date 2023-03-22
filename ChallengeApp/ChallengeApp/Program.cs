using ChallengeApp;

var employee1 = new Employee("Maja","Obuchowska");
var employee2 = new Employee("Konrad", "Nowak");
var employee3 = new Employee("Justyna", "Kowal");
var employee4 = new Employee("Karol", "Kowalski");


employee1.AddGrade("seven");
employee1.AddGrade("11");
employee1.AddGrade(2);
employee1.AddGrade(6);

employee2.AddGrade("2.5");
employee2.AddGrade(8);
employee2.AddGrade(1000);
employee2.AddGrade(2);

employee3.AddGrade(6);
employee3.AddGrade(7);
employee3.AddGrade(2);
employee3.AddGrade(2);

employee4.AddGrade(3);
employee4.AddGrade(12);
employee4.AddGrade(1);
employee4.AddGrade(2);

var statistics1 = employee1.GetStatisticsWithForeach();
var statistics2 = employee2.GetStatisticsWithFor();
var statistics3 = employee3.GetStatisticsWithDoWhile();
var statistics4 = employee4.GetStatisticsWithWhile();

Console.WriteLine($"Foreach:\nEmployee1:\nAverage: {statistics1.Average:N2}\nMax: {statistics1.Max}\nMin: {statistics1.Min}");
Console.WriteLine($"For:\nEmployee2:\nAverage: {statistics2.Average:N2}\nMax: {statistics2.Max}\nMin: {statistics2.Min}");
Console.WriteLine($"DoWhile:\nEmployee3:\nAverage: {statistics3.Average:N2}\nMax: {statistics3.Max}\nMin: {statistics3.Min}");
Console.WriteLine($"While:\nEmployee4:\nAverage: {statistics4.Average:N2}\nMax: {statistics4.Max}\nMin: {statistics4.Min}");





