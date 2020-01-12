using SchoolLibrary.ESL.Students;
using System;

namespace SchoolLibrary.ESL.States
{
    public class Level2State : EslState
    {
        public Level2State()
        {

        }

        public override void UpdateStateByScores(EslStudent eslStudent, float readingScore, float writingScore, float speakingScore)
        {
            if (IsLevel3Qualified(readingScore, writingScore, speakingScore))
            {
                eslStudent.EslState = new Level3State();
                Console.WriteLine($"You passed the test! {nameof(Level2State)} => {nameof(Level3State)}");
            }
            else
            {
                Console.WriteLine("You Failed the test!");
            }
        }

        private bool IsLevel3Qualified(float readingScore, float writingScore, float speakingScore)
        {
            return readingScore >= 80 && writingScore >= 80 && speakingScore >= 80;
        }
    }
}
