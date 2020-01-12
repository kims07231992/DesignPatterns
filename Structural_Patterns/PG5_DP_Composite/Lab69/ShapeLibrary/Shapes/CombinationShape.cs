using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Shapes
{
    public class CombinationShape : IShapeComponent
    {
        private Lazy<List<IShapeComponent>> _shapes = new Lazy<List<IShapeComponent>>();

        public CombinationShape()
        {

        }

        public void AddShape(IShapeComponent shape)
        {
            this._shapes.Value.Add(shape);
        }

        public void Draw()
        {
            foreach (var shape in this._shapes.Value)
            {
                shape.Draw();
            }
        }

        public void Resize(ResizeType resizeType)
        {
            foreach (var shape in this._shapes.Value)
            {
                shape.Resize(resizeType);
            }
        }
    }
}
