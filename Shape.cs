using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevationMaster
{
    class Shape
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Hell shape practice");
        }
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            //base.Draw();
            Console.WriteLine("Rectangle!");
        }
    }
    class Circle : Shape
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Circle!");
        }
    }
    class Triangle : Shape
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Triangle!");
        }
    }
}

