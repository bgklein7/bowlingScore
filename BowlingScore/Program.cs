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
            int frame = 0;
            int ballOne = 0;
            int ballOneScore = 0;
            int ballTwo = 0;
            int ballTwoScore = 0;
            do
            {
                Console.WriteLine("What frame are you in?");
                frame = Int32.Parse(Console.ReadLine());
                Console.WriteLine("What did you roll on your first ball?");
                ballOne = Int32.Parse(Console.ReadLine());
                if (ballOne <= 9)
                {
                    ballOneScore = ballOne;
                }
                else if (ballOne == 10)
                {
                    Console.WriteLine("You are throwing rocks, tonight! Whoo!");
                }
                else
                {
                    Console.WriteLine("Please try re-entering the number of pins you knocked over with your first ball.");
                }

            } while (frame > 0 && frame < 10);
        }
    }
}
