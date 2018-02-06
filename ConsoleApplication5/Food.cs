using Microsoft.SmallBasic.Library;
using System;

namespace ConsoleApplication5
{
    public class Food
    {
        public int X;
        public int Y;
        public int Size;
        Primitive Rect;

        public Food(int size, int x, int y, String color)
        {
            X = x;
            Y = y;
            Size = size;

            GraphicsWindow.BrushColor = color;
            Rect = Shapes.AddRectangle(size, size);
            Shapes.Move(Rect,x,y);
        }

        internal bool isStrike(int turtleX, int turtleY)
        {
            if (turtleX >= X && turtleX <= turtleX + Size && turtleY >= Y && turtleY <= Y + Size)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal void MoveToRandomPosition()
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            X = rand.Next(0, GraphicsWindow.Width);
            Y = rand.Next(0, GraphicsWindow.Height);
            Shapes.Move(Rect, X, Y);
        }
    }
}
