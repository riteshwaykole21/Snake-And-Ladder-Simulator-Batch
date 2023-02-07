using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    public class GamePlay
    { 
        int Player_Position = 0;
        const int No_Play = 0, Ladder = 1, Snake = 2;
        int winning_position = 100;
        Random random = new Random();   
    
        public void Game()
        {
            Console.WriteLine("Let start the game");
            Console.WriteLine("The Player is Starting position " +Player_Position);
        }
        public int DieRoll()
        {
            //The Player Roll The Die To Get A Number Between 1 to 6 use Random
           
            int DiceRoll = random.Next(1,7);
            Console.WriteLine("The Player Get Number {0} on DiceRoll" , DiceRoll);
            return DiceRoll;
        }
        public void CheckOption()
        {
            string type = "";
            while (Player_Position < winning_position)
            {
                int option = random.Next(3);
                switch (option)
                {
                    case No_Play:
                        type = "No_Player";
                        break;
                    case Ladder:
                        Player_Position += DieRoll();
                        type = "Ladder";
                        if (Player_Position > 100)
                        {
                            Console.WriteLine("Get second chance To Win");
                            break;
                        }
                        break;
                    case Snake:
                        Player_Position -= DieRoll();
                        type = "Snake";
                        if (Player_Position < 0)
                        {
                            Player_Position = 0;
                        }
                            break;
                    default:
                        Console.WriteLine("Invalid Selection");
                        break;

                }
                Console.WriteLine("Type ="+type);
                Console.WriteLine("The Player Is Current Position = "+Player_Position);
                Console.WriteLine("___________________");
            }
            Console.WriteLine("Game Over ! Player Is At Winning position {0} " +Player_Position);
        }
    }
}
