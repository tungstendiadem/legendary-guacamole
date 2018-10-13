using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Adapter
{
    // IFormattable and IFormatProvider supercedes pattern?
    class Provider : IProvider
    {
        private object Adaptation = null;

        public object GetAdaptation()
        {
            return Adapt(Adaptation);
        }

        public object Adapt(object obj)
        {
            return obj as Provider;
            
        }
    }
 
}
