﻿namespace OpenGL
{
    public struct Point
    {
        #region Variables

        public int X, Y;

        #endregion Variables

        #region Constructor

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        #endregion Constructor

        #region Operators

        public static Point operator +(Point a, Point b)
        {
            return new Point(a.X + b.X, a.Y + b.Y);
        }

        public static Point operator -(Point a, Point b)
        {
            return new Point(a.X - b.X, a.Y - b.Y);
        }

        #endregion Operators

        #region Methods

        public override string ToString()
        {
            return X + "," + Y;
        }

        public static Point Min(Point a, Point b)
        {
            return new Point((a.X > b.X) ? b.X : a.X, (a.Y > b.Y) ? b.Y : a.Y);
        }

        public static Point Max(Point a, Point b)
        {
            return new Point((a.X < b.X) ? b.X : a.X, (a.Y < b.Y) ? b.Y : a.Y);
        }

        public bool IsWithin(Point Position, Point Size)
        {
            return !(X < Position.X || Y < Position.Y || X > Position.X + Size.X || Y > Position.Y + Size.Y);
        }

        #endregion Methods
    }
}