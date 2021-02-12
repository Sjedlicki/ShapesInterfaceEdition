using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesInterfaceEdition
{
    public interface IShapeRepository
    {
        void Save(IShape shape);
        List<IShape> GetAll();
    }
}
