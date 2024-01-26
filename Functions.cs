using System;
using System.Collections.Generic;

namespace CalculatorCShaarp
{
    internal class Functions
    {
        public void ChoiceFunction(String choice, List<String> History)
        {
            Operations operations = new Operations();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Addition Selected");
                    History.Add("Addition");
                    operations.Addition();
                    break;
                case "2":
                    Console.WriteLine("Subtraction Selected");
                    History.Add("Subtraction");
                    operations.Subtraction();
                    break;
                case "3":
                    Console.WriteLine("Multiplication Selected");
                    History.Add("Multiplication");
                    operations.Multiplication();
                    break;
                case "4":
                    Console.WriteLine("Division Selected");
                    History.Add("Division");
                    operations.Division();
                    break;
                case "5":
                    Console.WriteLine("History Selected.");
                    gamesHistory(History);
                    break;
                default:
                    Console.WriteLine("Invalid Option!");
                    Environment.Exit(1);
                    break;
            }
        }

        public void gamesHistory(List<String>HistoryTracker)
        {
            foreach (var history in HistoryTracker)
            {
                Console.WriteLine(history);
            }
        }
    }
}