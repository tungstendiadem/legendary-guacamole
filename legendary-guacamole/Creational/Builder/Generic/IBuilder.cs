using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.Builder.Generic
{
    interface IBuilder<T>
    {
        Part01<T> Part01 { get; set; }
        Part02<T> Part02 { get; set; }
        PartNN<T> PartNN { get; set; }

        AProduct<T> GetProduct();
    }
}
