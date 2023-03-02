namespace MoodAnalyzerProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Mood Analyzer Problem....");

            MoodAnalyzer mood = new MoodAnalyzer();
            string message = "I am in Any Mood";
            Console.WriteLine(mood.AnalyzeMood(message));
        }
    }
}
