using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Composite : AComposite
    {
    }

    class CompositeList : AComposite
    {
        readonly List<Composite> composite = new List<Composite>();
        private List<Composite> composites = new List<Composite>();
    }
}
