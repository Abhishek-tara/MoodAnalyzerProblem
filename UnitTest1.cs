using MoodAnalyzerProblem;

namespace MoodAnalyzerProblemTest
{
    [TestClass]
    public class UnitTest1
    {
        MoodAnalyzer moodAnalyzer = new MoodAnalyzer();

        //-------------Test Case 1.1---------------//
        [TestMethod]
        public void GivenSadMoodShouldReturnSAD()
        {
            //Arrange
            string expected = "SAD";

            //Act
            string actual = moodAnalyzer.AnalyzeMood("I am in Sad Mood");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //-------------Test Case 1.2---------------//

        [TestMethod]
        public void GivenAnyMoodHAPPY()
        {
            //Arrange
            string expected = "HAPPY";

            //Act
            string actual = moodAnalyzer.AnalyzeMood("I am in Any Mood");

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}