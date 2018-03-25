
using RPS.players;
using RPS.symbols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    class Game
    {
        private string name;
        private int wins;

        private ISymbol rock = new Rock();
        private ISymbol paper = new Paper();
        private ISymbol scissors = new Scissors();

        private IPlayer user = new User();
        private IPlayer compuer = new Computer();

        public void BeginingGame()
        {
            Console.WriteLine("Welcom in Rock, Paper, Scissors game!\nWhat's your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name + " | For how many wins do you want to play?");
            try
            {
                wins = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("OK. We will play up to " + wins + " wins");
            }
            Console.WriteLine("Simple instructions: 1 = ROCK, 2 = PAPER, 3 = SCISSORS, x= end of the game, n = restart game");
        }

        public void Play()
        {

            user.Score = 0;
            compuer.Score = 0;
            while (Result() == 2)
            {
                Console.WriteLine("1 = ROCK, 2 = PAPER, 3 = SCISSORS ?");
                user.Rps = Convert.ToInt32(Console.ReadKey().Key);
                Console.WriteLine();

                Random random = new Random();
                compuer.Rps = random.Next(49, 52);


                if (user.Rps == compuer.Rps)
                {
                    Console.WriteLine("DRAW!");
                    Console.WriteLine(ShowMove());
                    Console.WriteLine(ShowScore());
                }
                else if ((user.Rps == rock.Code && compuer.Rps == scissors.Code) || (user.Rps == paper.Code && compuer.Rps == rock.Code) || (user.Rps == scissors.Code && compuer.Rps == paper.Code))
                {
                    user.Score++;
                    Console.WriteLine(ShowMove());
                    Console.WriteLine(ShowScore());
                }
                else if ((user.Rps == scissors.Code && compuer.Rps == rock.Code) || (user.Rps == rock.Code && compuer.Rps == paper.Code) || (user.Rps == paper.Code && compuer.Rps == scissors.Code))
                {
                    compuer.Score++;
                    Console.WriteLine(ShowMove());
                    Console.WriteLine(ShowScore());
                }
                else if (user.Rps == 88)
                {
                    ExitGame();
                }
                else if (user.Rps == 78)
                {
                    RestartGame();
                }
                else
                {
                    Console.WriteLine("Wrong Char");
                }
            }

        }
        private String ShowMove()
        {
            return "You: " + (user.Rps == 49 ? rock.Name : (user.Rps == 50 ? paper.Name : (user.Rps == 51 ? scissors.Name : null))) + " | Computer: " + (compuer.Rps == 49 ? rock.Name : (compuer.Rps == 50 ? paper.Name : (compuer.Rps == 51 ? scissors.Name : null)));
        }

        private String ShowScore()
        {
            return "Score: You = " + user.Score + " | Computer = " + compuer.Score;
        }

        private int Result()
        {
            if (user.Score == wins)
            {
                return 0;
            }
            else if (compuer.Score == wins)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
        public String Winner()
        {
            if (Result() == 0)
            {
                return "You WIN";
            }
            else if (Result() == 1)
            {
                return "Computer WINS";
            }
            else
            {
                return null;
            }
        }

        public void EndOfTheGame()
        {

            Console.WriteLine("New game? - press n | Exit - press x ");
            if (Console.ReadKey().Key == ConsoleKey.N)
            {
                Console.WriteLine();
                RestartGame();
            }
            else if (Console.ReadKey().Key == ConsoleKey.X)
            {
                Console.WriteLine();
                ExitGame();
            }
            else
            {
                Console.WriteLine("Wrong Char");
                EndOfTheGame();
            }
        }

        private void ExitGame()
        {
            Console.WriteLine("Exit? If yes - press y");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Environment.Exit(0);
            }
        }
        private void RestartGame()
        {
            Console.WriteLine("Restar? If yes - press y");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Program.Main(null);
            }
        }
    }
}
