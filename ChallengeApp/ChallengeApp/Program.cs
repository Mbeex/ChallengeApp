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

var statistics1 = employee1.GetStatistics();
var statistics2 = employee2.GetStatistics();
var statistics3 = employee3.GetStatistics();
var statistics4 = employee4.GetStatistics();

