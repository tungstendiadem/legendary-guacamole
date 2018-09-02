using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Composite<T> : AComposite<T>
    {
    }

    class CompositeList<T> : AComposite<T>
    {
        readonly List<Composite<T>> composite = new List<Composite<T>>();
        private List<Composite<T>> composites = new List<Composite<T>>();
        internal List<Composite<T>> Composited { get => Composited; set => Composited = value; }
        internal List<Composite<T>> Compositing { get; set; } = new List<Composite<T>>();
    }
}
