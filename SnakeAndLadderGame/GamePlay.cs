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
        Random random = new Random();   
    
        public void Game()
        {
            Console.WriteLine("Let start the game");
            Console.WriteLine("The Player is Starting position " +Player_Position);
        }
        public int DieRoll()
        {
            //The Player Roll The Die To Get A Number Between 1 to 6 use Random
            Random random = new Random();
            int DiceRoll = random.Next(1,7);
            Console.WriteLine("The Player Get Number {0} on DiceRoll" , DiceRoll);
            return DiceRoll;
        }
        public void CheckOption()
        {
            int option = random.Next(3);
            switch(option)
            {
                case No_Play:
                    Player_Position = 0;
                    break;
                case Ladder:
                    Player_Position += DieRoll();
                    break;
                case Snake:
                    Player_Position -= DieRoll();
                       break;
                default:
                    Console.WriteLine("Invalid Selection");
                    break;

            }
            Console.WriteLine("The Player Is Current Position = "+Player_Position);
        }
    }
}
