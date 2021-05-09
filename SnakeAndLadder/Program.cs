using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{ 
    class SnakeAndLadder
    {
        int START_POSITION = 0;
        public void PlayGame()
        {
            Console.WriteLine(" Single Player Start_Position:- " + START_POSITION);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            SnakeAndLadder StartPlay = new SnakeAndLadder();
            StartPlay.PlayGame();

        }
    }
}