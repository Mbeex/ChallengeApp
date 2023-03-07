using ChallengeApp;

var employee1 = new Employee("Maja", " Obuchowska", 18);
var employee2 = new Employee("Darek", " Nowak", 24);
var employee3 = new Employee("Alicja", " Kowal", 20);

employee1.AddScore(8);
employee1.AddScore(7);
employee1.AddScore(9);
employee1.AddScore(7);
employee1.AddScore(8);

employee2.AddScore(4);
employee2.AddScore(2);
employee2.AddScore(5);
employee2.AddScore(1);
employee2.AddScore(7);

employee3.AddScore(5);
employee3.AddScore(5);
employee3.AddScore(5);
employee3.AddScore(8);
employee3.AddScore(2);

int result1 = employee1.Result;
int result2 = employee2.Result;
int result3 = employee3.Result;


List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach(var employee in employees)
{
    if(employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employeeWithMaxResult.Result;
    }
}

Console.WriteLine("Najlepszy pracownik to " +  employeeWithMaxResult.Name +  employeeWithMaxResult.Surname + " lat " +  employeeWithMaxResult.Age + " ktory zdobyl " + maxResult + " punktow!!");
