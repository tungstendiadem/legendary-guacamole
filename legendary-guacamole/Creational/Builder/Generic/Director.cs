using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.Builder.Generic
{
    class Director<T>
    {
        private IBuilder<T> _builder;
        public Director(IBuilder<T> builder)
        {
            _builder = builder;
        }
        void GetProduct()
        {
            Part01<T> part01 = _builder.Part01;
            Part02<T> part02 = _builder.Part02;
            PartNN<T> partNN = _builder.PartNN;
        }
    }
}
