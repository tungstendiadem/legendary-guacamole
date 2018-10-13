using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.Builder.Basic
{
    interface IBuilder
    {
        Part01 Part01 { get; set; }
        Part02 Part02 { get; set; }
        PartNN PartNN { get; set; }

        AProduct GetProduct();
    }
}
