using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.Builder.Generic
{
    class Builder<T> : IBuilder<T>
    {
        public Builder()
        {
        }

        public Part01<T> Part01 { get; set; }
        public Part02<T> Part02 { get; set; }
        public PartNN<T> PartNN { get; set; }

        public AProduct<T> GetProduct()
        {
            return Part01 is IPart01<T> ? new Product<T>( Part01,  Part02,  PartNN) : null;
        }
    }
}
