using SchoolLibrary.ESL.Students;
using System;

namespace SchoolLibrary.ESL.States
{
    public class Level1State : EslState
    {
        public Level1State()
        {

        }

        public override void UpdateStateByScores(EslStudent eslStudent, float readingScore, float writingScore, float speakingScore)
        {
            if (IsLevel3Qualified(readingScore, writingScore, speakingScore))
            {
                eslStudent.EslState = new Level3State();
                Console.WriteLine($"You passed the test! {nameof(Level1State)} => {nameof(Level3State)}");
            }
            else if (IsLevel2Qualified(readingScore, writingScore, speakingScore))
            {
                eslStudent.EslState = new Level2State();
                Console.WriteLine($"You passed the test! {nameof(Level1State)} => {nameof(Level2State)}");
            }
            else
            {
                Console.WriteLine("You Failed the test!");
            }
        }

        private bool IsLevel3Qualified (float readingScore, float writingScore, float speakingScore)
        {
            return readingScore >= 90 && writingScore >= 90 && speakingScore >= 80;
        }

        private bool IsLevel2Qualified(float readingScore, float writingScore, float speakingScore)
        {
            return readingScore >= 70 && writingScore >= 60 && speakingScore >= 60;
        }
    }
}
