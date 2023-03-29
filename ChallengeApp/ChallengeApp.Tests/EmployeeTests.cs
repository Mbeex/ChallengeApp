using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WheneEmployeeCollectTwoScores_ShouldCorrectResult()
        {
            //arrange
            var employee = new Employee("Maja", "Obuchowska");
            employee.AddGrade(5);
            employee.AddGrade(6);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(11, result);
        }
    }
}