using SchoolLibrary.ESL.States;

namespace SchoolLibrary.ESL.Students
{
    public class EslStudent
    {
        public EslStudent()
        {
            this.EslState = new Level1State();
        }

        public EslState EslState { get; set; }
        public float ReadingScore { get; set; }
        public float WritingScore { get; set; }
        public float SpeakingScore { get; set; }

        public void TakeTest(float readingScore, float writingScore, float speakingScore)
        {
            this.ReadingScore = readingScore;
            this.WritingScore = writingScore;
            this.SpeakingScore = speakingScore;

            this.EslState.UpdateStateByScores(this, this.ReadingScore, this.WritingScore, this.SpeakingScore);
        }
    }
}
