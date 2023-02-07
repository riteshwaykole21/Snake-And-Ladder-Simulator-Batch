using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in Snake And Ladder Game");
            GamePlay play = new GamePlay();
            play.Game();
            play.DieRoll();
            play.CheckOption();
           
            Console.ReadLine();
        }
    }
}
