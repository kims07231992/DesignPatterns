using SchoolLibrary.ESL.Students;

namespace PG5_DP_State
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Run();
        }

        private static void Run()
        { 
            var student = new EslStudent(); // Default Level1State

            student.TakeTest(70, 60, 60); // Level up to Level2State
            student.TakeTest(80, 80, 80); // Level up to Level3State
            student.TakeTest(85, 85, 90); // Level up to Level4State
            student.TakeTest(90, 90, 90); // Level up to GraduationState
        }
    }
}
