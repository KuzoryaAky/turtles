using Microsoft.SmallBasic.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
            Food food = new Food(20, 320,220,"Red");
            Turtle.PenUp();
            while (true)
            {
                Turtle.Move(20);
                if (food.isStrike(Turtle.X, Turtle.Y))
                {
                    food.MoveToRandomPosition();
                   Turtle.Speed++;
                }
                if (Turtle.Y >= GraphicsWindow.Height)
                {
                    Turtle.Y = 0;

                }
                else if (Turtle.Y<= 0)
                {
                    Turtle.Y = GraphicsWindow.Height;
                }
                if (Turtle.X >= GraphicsWindow.Width)
                {
                    Turtle.X = 0;

                }
                else if (Turtle.X <= 0)
                {
                    Turtle.X = GraphicsWindow.Width;
                }
            }


        }

        private static void GraphicsWindow_KeyDown()
        {
            if (GraphicsWindow.LastKey == "Up")
            {
                Turtle.Angle = 0;

            }
            else if (GraphicsWindow.LastKey == "Right")
            {
                Turtle.Angle = 90;
            }
            else if (GraphicsWindow.LastKey == "Left")
            {
                Turtle.Angle = 270;
            }
            else if (GraphicsWindow.LastKey == "Down")
            {
                Turtle.Angle = 180;
            }
        }
    }
}
