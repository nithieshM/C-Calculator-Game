using System;

namespace CalculatorCShaarp
{
    internal class Operations
    {
        public void Addition()
        {
            int score = 0;
            Console.WriteLine("If you want to end the game, type quit.");
            for (int i = 0;; i++)
            {
                var random = new Random();
                int firstNumber = random.Next(1, 9);
                int secondNumber = random.Next(1, 9);
            
                Console.WriteLine($"Whats the answer to {firstNumber} + {secondNumber} ?");

                var result = Console.ReadLine();

                if (result.ToLower() == "quit")
                {
                    Console.WriteLine($" You have successfully quit the game. Your score is {score}");
                    break;
                }
                else if (result == (firstNumber + secondNumber).ToString())
                {
                    Console.WriteLine("Congratulations, You have guessed right!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Wrong Answer! Your score: {score}");
                    break;
                }
            }
           
        }

        public void Subtraction()
        {
            int score = 0;
            Console.WriteLine("If you want to end the game, type quit.");
            for (int i = 0;; i++)
            {
                var random = new Random();
                int firstNumber = random.Next(1, 9);
                int secondNumber = random.Next(10, 99);
            
                Console.WriteLine($"Whats the answer to {secondNumber} - {firstNumber} ?");

                var result = Console.ReadLine();

                if (result.ToLower() == "quit")
                {
                    Console.WriteLine($" You have successfully quit the game. Your score is {score}");
                    break;
                }
                else if (result == (secondNumber - firstNumber).ToString())
                {
                    Console.WriteLine("Congratulations, You have guessed right!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Wrong Answer! Your score: {score}");
                    break;
                }
            }
        }

        public void Multiplication()
        {
            int score = 0;
            Console.WriteLine("If you want to end the game, type quit.");
            for (int i = 0;; i++)
            {
                var random = new Random();
                int firstNumber = random.Next(1, 9);
                int secondNumber = random.Next(1, 9);
            
                Console.WriteLine($"Whats the answer to {firstNumber} * {secondNumber} ?");

                var result = Console.ReadLine();

                if (result.ToLower() == "quit")
                {
                    Console.WriteLine($" You have successfully quit the game. Your score is {score}");
                    break;
                }
                else if (result == (firstNumber * secondNumber).ToString())
                {
                    Console.WriteLine("Congratulations, You have guessed right!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Wrong Answer! Your score: {score}");
                    break;
                }
            }
        }

        public void Division()
        {
            int score = 0;
            Console.WriteLine("If you want to end the game, type quit.");
            for (int i = 0;; i++)
            {
                var division = GetDivision();

                var firstNumber = division[0];
                var secondNumber = division[1];
                
                
                Console.WriteLine($"Whats the answer to {firstNumber} / {secondNumber} ?");

                var result = Console.ReadLine();

                if (result.ToLower() == "quit")
                {
                    Console.WriteLine($" You have successfully quit the game. Your score is {score}");
                    break;
                }
                else if (result == (firstNumber / secondNumber).ToString())
                {
                    Console.WriteLine("Congratulations, You have guessed right!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Wrong Answer! Your score: {score}");
                    break;
                }
            }
        }

        int[] GetDivision()
        {
            var random = new Random();
            var firstNumber = random.Next(0, 99);
            var secondNumber = random.Next(0, 99);

            var result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(0, 99);
            }
            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }
    }
}