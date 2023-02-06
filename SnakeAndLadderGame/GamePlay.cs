using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    public class GamePlay
    {
        public void Game()
        {
            int Player_Position = 0;
            Console.WriteLine("Let start the game");
            Console.WriteLine("The Player is Starting position " +Player_Position);
        }
        public void DieRoll()
        {
            //The Player Roll The Die To Get A Number Between 1 to 6 use Random
            Random random = new Random();
            int diceRoll = random.Next(1,7);
            Console.WriteLine("The Player Get Number {0} on DiceRoll" , diceRoll);
        }
    }
}
