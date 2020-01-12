using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Shapes
{
    public class Square : IShapeComponent
    {
        private double _width;
        private double _height;

        public Square(double width, double height)
        {
            this._width = width;
            this._height = height;
        }

        public void Draw()
        {
            Console.WriteLine($"Draw square. Width: {this._width} Height: {this._height}");
        }

        public void Resize(ResizeType resizeType)
        {
            if (resizeType == ResizeType.Increase)
            {
                this._width++;
                this._height++;
            }
            else
            {
                this._width--;
                this._height--;
            }
        }
    }
}
