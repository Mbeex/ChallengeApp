using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WheneEmployeeCollectFourScores_ShouldCorrectResult()
        {
            //arrange
            var employee = new Employee("Maja", "Obuchowska",18);
            employee.AddScore(5);
            employee.AddScore(6);
            employee.RemoveScore(5);
            employee.RemoveScore(6);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(0, result);
        }
    }
}