using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.FactoryMethod.Basic
{
    interface IFactory
    {
        IProduct GetProduct(EProducts eproduct);
    }
}
