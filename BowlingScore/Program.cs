using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingScore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Dude's Lanes");
            int ballOne = 0;
            int ballTwo = 0;
            int frameScore = 0;
            int[] score = new int[10];
            for(int i = 1; i<10; i++)
            {
                Console.WriteLine("It is frame " + i);
                Console.WriteLine("What did you roll on your first ball?");
                ballOne = Int32.Parse(Console.ReadLine());
                Console.WriteLine("How many pins did you knock down with your second ball?");
                ballTwo = Int32.Parse(Console.ReadLine());
                frameScore = FrameScore(ballOne, ballTwo);
                Console.WriteLine("You scored " + frameScore + " in frame " + i + ".");
                score[i] = frameScore;
            } 
            Console.WriteLine("It is the 10th frame. Let's make it a good one, el Duderino!");
        }

        //Methods
        static int FrameScore(int ballOne, int ballTwo)
        {
            int frameSubtotal = 0;
            if (ballOne <= 9 && ballOne+ballTwo <10)
            {
                frameSubtotal = ballOne+ballTwo;
            }
            else if (ballOne == 10)
            {
                Console.WriteLine("You are throwing rocks, tonight! Whoo!");
                Strike(ballOne, ballTwo);
                //continue;
            }
            else if (ballOne < 0 || ballOne > 10 )
            {
                Console.WriteLine("Please try re-entering the number of pins you knocked over with your first ball.");
                Console.WriteLine("This isn't Nam, Smokey. There are rules.");
                ballOne = Int32.Parse(Console.ReadLine());
            }

            else if (ballTwo + ballOne == 10)
            {
                Spare(ballOne);
            }
            else if (ballTwo < 0 || ballTwo > 10)
            {
                Console.WriteLine("Please try re-entering the number of pins you knocked over with your second ball.");
                Console.WriteLine("This isn't Nam, Smokey. There are rules.");
                ballTwo = Int32.Parse(Console.ReadLine());
            }
            return frameSubtotal;
        }
        static int Spare(int ballOne)
        {
            return 10;
        }
        static int Strike(int ballOne, int ballTwo)
        {
            return 10 + ballOne + ballTwo;
        }
    }
}
