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
            string userResponse; //user choice on whether to restart the game
            int userNum = 0; //user number
            bool isPlayAgain = true;
            int compNum; //computer guessed number

            while (isPlayAgain)
            {
                int attempts = 5; //number of attempts (ENTER THE NUMBER OF ATTEMPTS!)
                Console.WriteLine("Welcome to Guess the Number!\nI guessed a number from 1 to 100! Can you guess what I guessed?");
                compNum = NumberGenerator();

                while (userNum != compNum)
                {
                    Console.Write($"Write a number (You only have {attempts} attempts!): ");
                    userNum = Convert.ToInt32(Console.ReadLine());

                    if (userNum < 1 || userNum > 100)
                    {
                        Console.WriteLine("Wrong number and character that is not a number!");
                        break;
                    }

                    if (userNum > compNum)
                    {
                        Console.WriteLine($"{userNum} is to high!");
                        --attempts;
                    }
                    else if (userNum < compNum)
                    {
                        Console.WriteLine($"{userNum} is to low!");
                        --attempts;
                    }
                    else
                    {
                        Console.WriteLine($"YOU WIN! I guessed {compNum}");
                        break;
                    }

                    if (attempts <= 0)
                    {
                        Console.WriteLine("YOU LOSE! The attempts are over!");
                        break;
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