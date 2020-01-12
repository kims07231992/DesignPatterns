using SchoolLibrary.ESL.Students;
using System;

namespace SchoolLibrary.ESL.States
{
    public class GraduationState : EslState
    {
        public GraduationState()
        {

        }

        public override void UpdateStateByScores(EslStudent eslStudent, float readingScore, float writingScore, float speakingScore)
        {
            throw new InvalidOperationException("You already graduated ESL course.");
        }
    }
}
