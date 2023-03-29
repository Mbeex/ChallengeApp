
namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void EmployeeMaxStatistics()
        {
            //arrange
            var employee = new Employee("Maja", "Obuchowska");
            employee.AddGrade(87);
            employee.AddGrade(34);

            //act
            var statistics = employee.GetStatistics();


            //assert
            Assert.AreEqual(87, statistics.Max);

        }
        [Test]
        public void EmployeeMinStatistics()
        {
            //arrange
            var employee1 = new Employee("Maja", "Obuchowska");
            employee1.AddGrade(73);
            employee1.AddGrade(6);
            employee1.AddGrade(54);
            employee1.AddGrade(12);


            //act
            var statistics = employee1.GetStatistics();

            //assert
            Assert.AreEqual(6, statistics.Min);

        }
        [Test]
        public void EmployeeAverageStatistics()
        {
            //arrange
            var employee1 = new Employee("Maja", "Obuchowska");
            employee1.AddGrade(6);
            employee1.AddGrade(2);
            employee1.AddGrade(5);
          
            //act
            var statistics = employee1.GetStatistics();

            //assert
            Assert.AreEqual(Math.Round(4.33, 2), Math.Round(statistics.Average, 2));

        }

        public void EmployeeAverageStatisticsFromGradeToChar()
        {
            //arrange
            var employee1 = new Employee("Maja", "Obuchowska");
            employee1.AddGrade(95);
            employee1.AddGrade(43);
            employee1.AddGrade(65);

            //act
            var statistics = employee1.GetStatistics();
            var AverageLetter = employee1.GetStatistics().AverageLetter;

            //assert
            Assert.AreEqual('B', AverageLetter);
        }

        public void EmployeeAverageStatisticsFromCharToGrade()
        {
            //arrange
            var employee1 = new Employee("Maja", "Obuchowska");
            employee1.AddGrade('c');

            //act
            var statistics = employee1.GetStatistics();

            //assert
            Assert.AreEqual(statistics.Average, 40);

        }


        private Employee GetEmployee(string name,string surname)
        {
            return new Employee(name,surname);
        }
    }
}

