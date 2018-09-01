using System;

namespace Decorator
{
    public class BaseClass : ADecorator
    {
        public new void Process()
        {
            base.Process();
        }
    }
}
