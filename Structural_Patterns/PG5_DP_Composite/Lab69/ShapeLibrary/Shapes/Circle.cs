using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Shapes
{
    public class Circle : IShapeComponent
    {
        private double _radius;

        public Circle(double radius)
        {
            this._radius = radius;
        }

        public void Draw()
        {
            Console.WriteLine($"Draw Circle. Radius: {this._radius}");
        }

        public void Resize(ResizeType resize)
        {
            if (resize == ResizeType.Increase)
            {
                this._radius++;
            }
            else
            {
                this._radius--;
            }
        }
    }
}
