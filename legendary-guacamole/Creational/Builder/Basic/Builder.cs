using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.Builder.Basic
{
    class Builder : IBuilder
    {
        public Builder()
        {
        }

        public Part01 Part01 { get; set; }
        public Part02 Part02 { get; set; }
        public PartNN PartNN { get; set; }

        public AProduct GetProduct()
        {
            return Part01 is IPart01 ? new Product( Part01,  Part02,  PartNN) : null;
        }
    }
}
