using MoodAnalyzerProblem;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        //UC2
        // TC 2.1: Given null mood Should Return HAPPY
        [TestMethod]
        public void GivenNullMoodShouldReturnHAPPY()
        {
            string expected = "HAPPY";
            string message = null;
            MoodAnalyser moodAnalyse = new MoodAnalyser(message);
            string mood = moodAnalyse.AnalyseMood(message);
            Assert.AreEqual(expected, mood);
        }
    }
}