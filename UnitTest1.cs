using MoodAnalyzerProblem;

namespace MoodAnalyzerProblemTest
{
    [TestClass]
    public class UnitTest1
    {

        //-------------Test Case 1.1---------------//
        [TestMethod]
        public void GivenSadMoodShouldReturnSAD()
        {
            //Arrange
            String message = "I am Sad";
            string expected = "SAD";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(expected);

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
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(expected);

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


        //--------------Test Case 3.1-----------------//
        [TestMethod]
        public void GivenNullMoodShouldThrowMoodAnalysisException()
        {
            try
            {
                string message = null;
                MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
                string actual = moodAnalyzer.AnalyzeMood();
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("Mood should not be null", ex.Message);
            }
        }
        //---------Test Case 3.2---------------//
        [TestMethod]
        public void GivenEmptyMoodShouldThrowMoodAnalysisException()
        {
            try
            {
                string message = "";
                MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
                string actual = moodAnalyzer.AnalyzeMood();
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("Mood should not be empty", ex.Message);
            }
        }

        //---------Test Case 4---------------//
        [TestMethod]
        public void GivenMoodAnalyzeClasssNameShouldReturnMoodAnalyzeObject()
        {
            string message = null;
            object expected = new MoodAnalyzer(message);
            object obj = MoodAnalyzerFactory.CreateMoodAnalyze("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyzer");
            expected.Equals(obj);
        }








    }
}