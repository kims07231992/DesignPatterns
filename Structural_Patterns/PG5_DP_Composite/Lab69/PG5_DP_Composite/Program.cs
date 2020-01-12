using ShapeLibrary.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Composite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Run();
        }

        private static void Run()
        {
            var circle = new Circle(10);
            var square = new Square(10, 10);
            var triangle = new Triangle(10, 10);
            var combinationShape = new CombinationShape();
            combinationShape.AddShape(new Circle(5));
            combinationShape.AddShape(new Square(5, 5));
            combinationShape.AddShape(new Triangle(5, 5));

            var shapes = new IShapeComponent[]
            {
                combinationShape,
                circle,
                square,
                triangle
            };

            DrawShapes(shapes); // Drawing shapes before resizing

            ResizeShapes(ResizeType.Increase, shapes); // Increasing size of shapes

            DrawShapes(shapes); // Drawing shapes after resizing

        }

        private static void DrawShapes(params IShapeComponent[] shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }

        private static void ResizeShapes(ResizeType resizeType, params IShapeComponent[] shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Resize(resizeType);
            }
        }
    }
}
