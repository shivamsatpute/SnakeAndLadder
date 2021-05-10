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
            Random random = new Random();
            int Die = random.Next(1, 6);    
            Console.WriteLine(" Player Die Roll Position :-" + Die);
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