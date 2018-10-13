using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Decorator : ADecorator
    {
        public Decorator(ADecorator aDecorator)
        { }
        public ADecorator previousDecoration;
        public void Process()
        {
            base.Process();
            previousDecoration.Process();
        }
    }

    class DecoratorOne : Decorator
    {
        public DecoratorOne(ADecorator aDecorator) : base(aDecorator)
        {
            previousDecoration = aDecorator;
        }
        public void Process()
        {
            base.Process();
        }
    }

    class DecoratorX : Decorator
    {
        public DecoratorX(ADecorator aDecorator) : base(aDecorator)
        {
            previousDecoration = aDecorator;
        }
    }
}
