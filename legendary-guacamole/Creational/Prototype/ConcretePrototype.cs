using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.Prototype
{
    class ConcretePrototype01 : IPrototype
    {
        public ConcretePrototype01()
        {
        }

        public IClone Clone()
        {
            return (IClone)MemberwiseClone();
        }        
    }
}
