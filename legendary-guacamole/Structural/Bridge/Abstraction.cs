using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Bridge
{
    internal class Abstraction : IAbstraction
    {
        public Abstraction(IBridge bridge) => _bridge = bridge;

        public IBridge _bridge;

        public void Operation()
        {
            _bridge.operation();
        }
    }
}
