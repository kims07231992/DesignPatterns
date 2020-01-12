using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Shapes
{
    public enum ResizeType { Increase, Decrease }

    public interface IShapeComponent
    {
        void Draw();
        void Resize(ResizeType resizeType);
    }
}
