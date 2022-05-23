using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace week10day1
{
    public class Game
    {
        public string Choice { get; set; }


        public Game()
        {
            this.Play();
        }

        private void Play()
        {
            bool keepPlaying = true;
            Random rand = new Random();
            while (keepPlaying)
            {
                System.Console.WriteLine("\nPress (r) to pick rock, (p) to pick paper, and (s) to pick scissors");
                char input = Console.ReadKey().KeyChar;
                Choice = CharToChoice(input);
                int compChoiceNum = rand.Next(1, 4);
                string compChoice;
                switch (compChoiceNum)
                {
                    case 1:
                        compChoice = "rock";
                        break;
                    case 2:
                        compChoice = "paper";
                        break;
                    case 3:
                        compChoice = "scissors";
                        break;
                    default:
                        compChoice = "rock";
                        break;
                }
                if (compChoice != Choice)
                {
                    if (compChoice == "rock" && Choice == "paper")
                    {
                        Console.WriteLine("\nYou Won!");
                    }
                    if (compChoice == "rock" && Choice == "scissors")
                    {
                        Console.WriteLine("\nYou Lost :(");
                    }
                    if (compChoice == "paper" && Choice == "rock")
                    {
                        Console.WriteLine("\nYou Lost :(");
                    }
                    if (compChoice == "paper" && Choice == "scissors")
                    {
                        Console.WriteLine("\nYou Won!");
                    }
                    if (compChoice == "scissors" && Choice == "paper")
                    {
                        Console.WriteLine("\nYou Lost :(");
                    }
                    if (compChoice == "scissors" && Choice == "rock")
                    {
                        Console.WriteLine("\nYou Won!");
                    }
                    keepPlaying = Continue();
                }
                else
                {
                    System.Console.WriteLine("\nThere has been a tie! Both sides pick again!");
                }
            }
        }
        private bool Continue()
        {
            Console.WriteLine("\nWould you like to keep playing?\nIf no, press (n). Otherwise, press any key to continue");
            char keepPlaying = Console.ReadKey().KeyChar;
            if (keepPlaying == 'n')
            {
                System.Console.WriteLine("\nThank you for playing");
                Thread.Sleep(2000);
                Console.Clear();
                return false;
            }
            return true;

        }
        private string CharToChoice(char input)
        {
            switch (input)
            {
                case 'r':
                    return "rock";
                case 'p':
                    return "paper";
                case 's':
                    return "scissors";
                default:
                    return "rock";
            }
        }
    }
}