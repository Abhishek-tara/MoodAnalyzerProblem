﻿namespace MoodAnalyzerProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Mood Analyzer Problem....");

            string message = null;
            MoodAnalyzer mood = new MoodAnalyzer(message);
            Console.WriteLine(mood.AnalyzeMood());
        }
    }
}
