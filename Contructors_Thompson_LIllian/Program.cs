using System;

namespace Contructors_Thompson_LIllian
{
    class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game("CS:GO", "FPS");

            Console.WriteLine($"My favorite game is {myGame.title} and it is a {myGame.genre}!");

            Game myOtherGame = new Game();

            Console.WriteLine($"My other favorite game is {myOtherGame.title} and it is rated {myOtherGame.genre} game!");
        }
    }
}
