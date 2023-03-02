using MoodAnalyzerProblem;

namespace MoodAnalyzerProblemTest
{
    [TestClass]
    public class UnitTest1
    {
        MoodAnalyzer moodAnalyzer = new MoodAnalyzer("I am in Any Mood");

        //-------------Test Case 1.1---------------//
        [TestMethod]
        public void GivenSadMoodShouldReturnSAD()
        {
            //Arrange
            string expected = "SAD";

            //Act
            string actual = moodAnalyzer.AnalyzeMood();

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
            string actual = moodAnalyzer.AnalyzeMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }


        //-------------Test Case 2.1---------------//
        [TestMethod]
        public void TestAnalyseMood_ShouldReturnHAPPY1()
        {
            //Arrange
            string message = null;
            string expected = "HAPPY";
            MoodAnalyzer mood = new MoodAnalyzer(message);

            //Act
            string actual = mood.AnalyzeMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}