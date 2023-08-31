using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    internal class Program
    {
        static int NumberGenerator()
        {
            Random randNum = new Random();
            int winNum = randNum.Next(1, 100);
            return winNum;
        }
        static void Main(string[] args)
        {
            string userAnswer;
            string userResponse;
            int userNum = 0;
            bool isPlayAgain = true;

            while (isPlayAgain)
            {
                Console.WriteLine("Welcome to Guess the Number!\nI guessed a number from 1 to 100! Can you guess what I guessed?");
                int compNum = NumberGenerator();

                while (userNum != compNum)
                {
                    Console.Write("Write a number: ");
                    userAnswer = Console.ReadLine();
                    userNum = int.Parse(userAnswer);

                    if (userNum < 1 || userNum > 100)
                    {
                        Console.WriteLine("Wrong number! Enter number again!");
                    }

                    if (userNum > compNum)
                    {
                        Console.WriteLine($"{userNum} is to high!");
                    }
                    else if (userNum < compNum)
                    {
                        Console.WriteLine($"{userNum} is to low!");
                    }
                    else
                    {
                        Console.WriteLine($"You won! I guessed {compNum}");
                    }

                }

                Console.WriteLine("\nPlay again? Y/N");
                userResponse = Console.ReadLine();
                userResponse = userResponse.ToUpper();
                Console.WriteLine();

                if (userResponse == "Y")
                {
                    isPlayAgain = true;
                }
                else
                {
                    isPlayAgain = false;
                }
            }

        }
    }
}