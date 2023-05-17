
namespace ChallengeApp
{
    //co..?
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        void AddGrade(float grade);
        void AddGrade(char grade);
        void AddGrade(string grade);
        void AddGrade(int grade);



        Statistics GetStatistics();
    }
}
