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
        const int NoPlay = 0;
        const int Ladder = 1;
        const int Snakle = 2;
        public void PlayGame()
        {
            Random random = new Random(); 
            int Die = random.Next(1, 7);    
            int Option = random.Next(0, 3);
            int Player = 0;
            switch (Option) 
            {
                case NoPlay:
                    Console.WriteLine("No Play, Pass the chance"); 
                    break;
                case Ladder:
                    Player = Die; // 
                    Console.WriteLine("You got Ladder \n Player position = " + Player);
                    break;
                case Snakle:
                    Player = Die;
                    Console.WriteLine("You gotSnake \n player position = " + Player); 
                    break;
            }
            Console.WriteLine(" Player Die Roll Position :- " + Die);                  
            Console.WriteLine(" Single Player Start_Position:- " + START_POSITION);     
            Console.ReadLine();
        }
        static void Main(string[] args)//Main method
        {
            SnakeAndLadder StartPlay = new SnakeAndLadder(); 
            StartPlay.PlayGame();

        }
    }
}
