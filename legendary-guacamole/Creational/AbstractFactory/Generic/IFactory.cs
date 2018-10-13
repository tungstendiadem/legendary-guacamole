using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.AbstractFactory.Generic
{
    interface IFactory<T>
    {
        void CreateProduct01();
        void CreateProduct02();
        void CreateProductNN();
    }
}
