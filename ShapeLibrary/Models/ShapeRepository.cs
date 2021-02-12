using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesInterfaceEdition
{
    public class ShapeRepository : IShapeRepository
    {
        private readonly List<IShape> _shapes = new List<IShape>();

        public List<IShape> GetAll()
        {
            return _shapes;
        }

        public void Save(IShape shape)
        {
            _shapes.Add(shape);
        }
    }
}
