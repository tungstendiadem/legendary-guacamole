using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.Builder.Basic
{
    class Director
    {
        private IBuilder _builder;
        public Director(IBuilder builder)
        {
            _builder = builder;
        }
        void GetProduct()
        {
            Part01 part01 = _builder.Part01;
            Part02 part02 = _builder.Part02;
            PartNN partNN = _builder.PartNN;
        }
    }
}
