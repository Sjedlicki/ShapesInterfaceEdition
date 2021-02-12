using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise52
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
