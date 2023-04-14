using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RockPaperScissors
{
    class Program
    {
        public static void Main(string[] args)
        {
            string inputPlayer;
            string inputCpu;
            int randomInt;

            Console.WriteLine("Choose between Rock, Paper and scissors: ");
            inputPlayer = Console.ReadLine();

            Random rnd = new Random();

            randomInt = rnd.Next(1,4);

            switch (randomInt)
            {
                case 1:
                    inputCpu = "Rock";
                    Console.WriteLine("Computer chose Rock");
                    if (inputPlayer == "Rock")
                    {
                        Console.WriteLine("Draw!!\n\n");
                    }
                    else if (inputPlayer == "Paper")
                    {
                        Console.WriteLine("player Wins!!\n\n");
                    }
                    else if (inputPlayer == "Scissors")
                    {
                        Console.WriteLine("Computer Wins!!\n\n");
                    }
                    break;
                case 2:
                    inputCpu = "Paper";
                    Console.WriteLine("Computer chose Paper");
                    if (inputPlayer == "Paper")
                    {
                        Console.WriteLine("Draw!!\n\n");
                    }
                    else if (inputPlayer == "Scissors")
                    {
                        Console.WriteLine("player Wins!!\n\n");
                    }
                    else if (inputPlayer == "Rock")
                    {
                        Console.WriteLine("Computer Wins!!\n\n");
                    }
                    break;
                case 3:
                    inputCpu = "Scissors";
                    Console.WriteLine("Computer chose Scissors");
                    if (inputPlayer == "Scissors")
                    {
                        Console.WriteLine("Draw!!\n\n");
                    }
                    else if (inputPlayer == "Rock")
                    {
                        Console.WriteLine("player Wins!!\n\n");
                    }
                    else if (inputPlayer == "Paper")
                    {
                        Console.WriteLine("Computer Wins!!\n\n");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid entry!");
                    break;
            }

        }
    
    
    
    
    
    
    
    }






}