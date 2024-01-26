using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculatorCShaarp
{
    internal class Menu
    {
        public static void Main(string[] args)
        {
            var date = DateTime.UtcNow;
            Console.WriteLine("Welcome to my math game!");
            
            Console.WriteLine("Please Enter your name! ");
            var name = Console.ReadLine();
            
            Console.WriteLine($"Hello {name}, It's {date}. This is a math game!");
            List<String> HistoryTracker = new List<string>();
            
            bool game = true;
            
            do
            {
                Console.WriteLine("Choose one of the following options: " +
                                  "\n1. Addition " +
                                  "\n2. Subtraction" +
                                  "\n3. Multiplication" +
                                  "\n4. Division" +
                                  "\n5. History" +
                                  "\n6. Quit");

                var choice = Console.ReadLine();

                Functions functions = new Functions();
            
                functions.ChoiceFunction(choice, HistoryTracker);
            } while (game);
        }
    }
}
