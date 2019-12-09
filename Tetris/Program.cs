using System;

namespace Tetris
{
    class Program
    {
        static void Main()
        {
            Game tetris = new Game();
            tetris.Start();
            Console.ReadKey();
        }
    }
}
