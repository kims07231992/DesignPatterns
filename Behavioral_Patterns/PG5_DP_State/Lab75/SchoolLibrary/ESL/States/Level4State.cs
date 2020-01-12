using SchoolLibrary.ESL.Students;
using System;

namespace SchoolLibrary.ESL.States
{
    public class Level4State : EslState
    {
        public Level4State()
        {

        }

        public override void UpdateStateByScores(EslStudent eslStudent, float readingScore, float writingScore, float speakingScore)
        {
            if (IsGraduationQualified(readingScore, writingScore, speakingScore))
            {
                eslStudent.EslState = new GraduationState();
                Console.WriteLine($"You passed the test! {nameof(Level4State)} => {nameof(GraduationState)}");
            }
            else
            {
                Console.WriteLine("You Failed the test!");
            }
        }

        private bool IsGraduationQualified(float readingScore, float writingScore, float speakingScore)
        {
            return readingScore >= 90 && writingScore >= 90 && speakingScore >= 90;
        }
    }
}
