﻿using System;
using System.CodeDom;
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
                    Console.Write($"\nWrite a number (You only have {attempts} attempts!): ");

                    try
                    {
                        userNum = int.Parse(Console.ReadLine());
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("Character that is not a number!");
                    }

                    if (userNum < 1 || userNum > 100)
                    {
                        Console.WriteLine("Wrong number!");
                    }

                    else if (userNum > compNum)
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

                    if (attempts == 0)
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