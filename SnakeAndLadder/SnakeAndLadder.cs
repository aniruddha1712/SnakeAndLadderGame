using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    class SnakeAndLadder
    {
        public static void Start()
        {
            int startPosition = 0;
            Console.WriteLine("Starting position of player1: " + startPosition);
        }
        public static void DiceRoll()
        {
            int newPosition = 0;
            Random random = new Random();
            int dice = random.Next(1, 7);
            newPosition += dice;
            Console.WriteLine("new position of player1:" + newPosition);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Snake And Ladder Game");
            Start();
            DiceRoll();
            Console.ReadLine();
        }
    }
}
