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
            Console.WriteLine("Starting position of player2: " + startPosition);
        }
        public static void DiceRoll()
        {
            const int IS_NO_PLAY = 0, IS_LADDER = 1, IS_SNAKE = 2, WINNING_POSITION=100, PLAYER1=0,PLAYER2=1;
            int newPositionFor1 = 0, newPositionFor2=0 , numOfTimesDiceRolled=0, player = 0;
            while(newPositionFor1 < WINNING_POSITION && newPositionFor2 < WINNING_POSITION)
            {
                Random random = new Random();
                int dice = random.Next(1, 7);
                int option = random.Next(0, 3);
                switch(option)
                {
                    case IS_NO_PLAY:
                        Console.WriteLine("its no play, cannot move");
                        if(player==PLAYER1)
                        {
                            newPositionFor1 += 0;
                        }
                        else
                        {
                            newPositionFor2 += 0;
                        }
                        break;
                    case IS_LADDER:
                        Console.WriteLine("its ladder, going up "+dice);
                        if (player == PLAYER1)
                        {
                            newPositionFor1 += dice;
                        }
                        else
                        {
                            newPositionFor2 += dice;
                        }
                        break;
                    case IS_SNAKE:
                        Console.WriteLine("its snake, going down "+dice);
                        if(player==PLAYER1)
                        {
                            newPositionFor1 -= dice;
                                if(newPositionFor1 <= 0)
                                    newPositionFor1 = 0;
                        }
                        else
                        {
                            newPositionFor2 -= dice;
                            if (newPositionFor2 <= 0)
                                newPositionFor2 = 0;
                        }
                        
                        break;
                }
                if (newPositionFor1 > WINNING_POSITION || newPositionFor2 > WINNING_POSITION)
                {
                    if (player == PLAYER1)
                        newPositionFor1 -= dice;
                    else
                        newPositionFor2 -= dice;
                }
            numOfTimesDiceRolled++;
            Console.WriteLine("new position of player1 {0} after rolling dice {1} time(s) ", newPositionFor1, numOfTimesDiceRolled);
            Console.WriteLine("new position of player2 {0} after rolling dice {1} time(s) ", newPositionFor2, numOfTimesDiceRolled);

                if(option==1)
                {
                    Console.WriteLine("you'll get one more chance:");
                    if (player == PLAYER1)
                        player = 1;
                    else
                        player = 0;
                }
                
            }
            if (newPositionFor1 == 100)
                Console.WriteLine("Player1 is winner");
            else
                Console.WriteLine("Player2 is winner");

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
