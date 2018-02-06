using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Point
    {
        public int X;
        public int Y;
        
        public Point()
        {
            X = 0;
            Y = 0;
        }
        public Point(int x,int y)
        {
            X = x;
            Y = y;
        }
        public void Drow()
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine("*");
        }
    }
}
