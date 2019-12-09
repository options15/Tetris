namespace Tetris
{
    public struct Point
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
}
