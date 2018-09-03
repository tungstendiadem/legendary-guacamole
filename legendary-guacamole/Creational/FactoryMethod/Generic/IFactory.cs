using Creational.Builder.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.FactoryMethod.Generic
{
    interface IFactory<T>
    {
        IProduct<T> GetProduct(EProducts eproduct);
    }
}
