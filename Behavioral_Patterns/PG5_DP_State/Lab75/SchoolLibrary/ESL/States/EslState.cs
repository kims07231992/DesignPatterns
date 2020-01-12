using SchoolLibrary.ESL.Students;

namespace SchoolLibrary.ESL.States
{
    public abstract class EslState
    {
        public EslState()
        {

        }

        public abstract void UpdateStateByScores(EslStudent eslStudent, float readingScore, float writingScore, float speakingScore);
    }
}
