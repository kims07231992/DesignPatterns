using SchoolLibrary.ESL.Students;
using System;

namespace SchoolLibrary.ESL.States
{
    public class Level3State : EslState
    {
        public Level3State()
        {

        }

        public override void UpdateStateByScores(EslStudent eslStudent, float readingScore, float writingScore, float speakingScore)
        {
            if (IsGraduationQualified(readingScore, writingScore, speakingScore))
            {
                eslStudent.EslState = new GraduationState();
                Console.WriteLine($"You passed the test! {nameof(Level3State)} => {nameof(GraduationState)}");
            }
            else if (IsLevel4Qualified(readingScore, writingScore, speakingScore))
            {
                eslStudent.EslState = new Level4State();
                Console.WriteLine($"You passed the test! {nameof(Level3State)} => {nameof(Level4State)}");
            }
            else
            {
                Console.WriteLine("You Failed the test!");
            }
        }

        private bool IsGraduationQualified(float readingScore, float writingScore, float speakingScore)
        {
            return readingScore >= 100 && writingScore >= 95 && speakingScore >= 95;
        }

        private bool IsLevel4Qualified(float readingScore, float writingScore, float speakingScore)
        {
            return readingScore >= 85 && writingScore >= 85 && speakingScore >= 90;
        }
    }
}
