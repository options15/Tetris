using System;

namespace Tetris
{
    public class Graphics
    {
        public Window window { get; private set; }

        private char[,] pixel;

        private int pixelHeight;

        private int pixelWidth;

        public Graphics(Window window)
        {
            this.window = window;
            pixelHeight = window.Height / window.Size;
            pixelWidth = window.Width / window.Size;
            pixel = new char[pixelWidth, pixelHeight];
        }
        public Graphics(Window window, char border) : this(window)
        {
            window.coordinate = new Point(window.coordinate.X + 1, window.coordinate.Y + 1);
            CreateBorder(border);
        }

        private void CreateBorder(char border)
        {
            int startX = window.coordinate.X - 1;
            int startY = window.coordinate.Y - 1;
            int endX = startX + window.Width + 1;
            int endY = startY + window.Height + 1;

            for (int x = startX; x <= endX; x++)
            {
                DrawPoint(x, startY, border);
                DrawPoint(x, endY, border);
            }
            for (int y = startY+1; y < endY; y++)
            {
                DrawPoint(startX, y, border);
                DrawPoint(endX, y, border);
            }
        }

        public void DrawPoint(int x, int y, char ch)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(ch);
        }

        public void DrawPixel(int x, int y, char ch)
        {
            int yCursor = y * window.Size + window.coordinate.Y;
            int xCursor = x * window.Size + window.coordinate.X;
            for (int ix = xCursor; ix < xCursor + window.Size; ix++)
                for (int iy = yCursor; iy < yCursor + window.Size; iy++)
                    DrawPoint(ix, iy, ch);
        }

        public void DrawScreen()
        {
            for (int x = 0; x < pixelWidth; x++)
                for (int y = 0; y < pixelHeight; y++)
                    if(pixel[x, y] != '\0')
                    DrawPixel(x, y, pixel[x, y]);
        }
    }
}
