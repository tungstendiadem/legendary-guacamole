using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.Builder.Generic
{

    class AProduct<T>
    {
        public IPart01<T> Part01 { get; set; }
        public IPart02<T> Part02 { get; set; }
        public IPartNN<T> PartNN { get; set; }

        public AProduct(IPart01<T> part01, IPart02<T> part02, IPartNN<T> partNN)
        {
            Part01 = part01;
            Part02 = part02;
            PartNN = partNN;
        }
    }
}
