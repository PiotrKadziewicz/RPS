using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("gime ");
            // //ConsoleKey key = Console.ReadKey().Key;
            // int b = Convert.ToInt32(Console.ReadKey().Key);
            //// Console.WriteLine(key);
            // Console.WriteLine(b);
            // Console.ReadLine();
            Game game = new Game();
            game.BeginingGame();
            game.Play();
            Console.WriteLine(game.Winner());
            game.EndOfTheGame();
        }
    }
}
