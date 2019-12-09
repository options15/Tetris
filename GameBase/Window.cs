namespace Tetris
{
    public class Window
    {
        public Point coordinate { get; set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public int Size { get; private set; }

        public Window(int Width, int Height, Point coordinate, int Size = 1)
        {
            this.Width = Width * Size;
            this.Height = Height * Size;
            this.coordinate = coordinate;
            this.Size = Size;
        }
    }
}
