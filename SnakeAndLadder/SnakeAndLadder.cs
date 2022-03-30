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
            const int IS_NO_PLAY = 0, IS_LADDER = 1, IS_SNAKE = 2, WINNING_POSITION=100;
            int newPosition = 0;
            while(newPosition < WINNING_POSITION)
            {
                Random random = new Random();
                int dice = random.Next(1, 7);
                int option = random.Next(0, 3);
                switch(option)
                {
                    case IS_NO_PLAY:
                        newPosition += 0;
                        Console.WriteLine("its no play, cannot move");
                        break;
                    case IS_LADDER:
                        newPosition += dice;
                        Console.WriteLine("its ladder, going up "+dice);
                        break;
                    case IS_SNAKE:
                        newPosition -= dice;
                        if(newPosition<=0)
                        {
                            newPosition = 0;
                        }
                        Console.WriteLine("its snake, going down "+dice);
                        break;
                }
                if (newPosition > WINNING_POSITION)
                {
                    newPosition -= dice;
                }
            }
         Console.WriteLine("new position of player1: " + newPosition);

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
