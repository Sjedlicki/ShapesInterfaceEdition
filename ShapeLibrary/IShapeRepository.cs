using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise52
{
    public interface IShapeRepository
    {
        void Save(IShape shape);
        List<IShape> GetAll();
    }
}
