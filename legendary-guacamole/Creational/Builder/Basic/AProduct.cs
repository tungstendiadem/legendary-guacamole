using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.Builder.Basic
{

    class AProduct
    {
        public IPart01 Part01 { get; set; }
        public IPart02 Part02 { get; set; }
        public IPartNN PartNN { get; set; }

        public AProduct(IPart01 part01, IPart02 part02, IPartNN partNN)
        {
            Part01 = part01;
            Part02 = part02;
            PartNN = partNN;
        }
    }
}
