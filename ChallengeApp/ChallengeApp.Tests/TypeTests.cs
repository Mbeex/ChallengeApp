
namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void EmployeeMaxStatistics()
        {
            //arrange
            var employee = new Employee("Maja", "Obuchowska");
            employee.AddGrade(2);
            employee.AddGrade(2);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(2, statistics.Max);

        }
        [Test]
        public void EmployeeMinStatistics()
        {
            //arrange
            var employee = new Employee("Maja", "Obuchowska");
            employee.AddGrade(7);
            employee.AddGrade(6);
            employee.AddGrade(4);
            employee.AddGrade(12);


            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(4, statistics.Min);

        }
        [Test]
        public void EmployeeAverageStatistics()
        {
            //arrange
            var employee = new Employee("Maja", "Obuchowska");
            employee.AddGrade(4);
            employee.AddGrade(2);
            employee.AddGrade(3);
            employee.AddGrade(3);


            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(3, statistics.Average);

        }




        private Employee GetEmployee(string name,string surname)
        {
            return new Employee(name,surname);
        }
    }
}

