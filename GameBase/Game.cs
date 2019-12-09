using System;

namespace Tetris
{
    public class Game
    {
        private Graphics gamePole;
        private Graphics gameInterface;
        private int figureSize = 1;

        private char defaultBorder = '*';
        public Game()
        {
            Console.SetWindowSize(10, 10);

            Console.CursorVisible = false;

            gamePole = new Graphics(new Window(10, 20, new Point(0, 0), 4), defaultBorder);
            gameInterface = new Graphics(new Window(10, 10, new Point(gamePole.window.Width+2, 0)), defaultBorder);
            int heigth = gamePole.window.Height +2;
            int width = gamePole.window.Width + gameInterface.window.Width + 4;
            Console.SetBufferSize(width, heigth);
        }

        public void Start()
        {
            gamePole.DrawPixel(0, 1, '8');
            gamePole.DrawScreen();
        }
    }
}
