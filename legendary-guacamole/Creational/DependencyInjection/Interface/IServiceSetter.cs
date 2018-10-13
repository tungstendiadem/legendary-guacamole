using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.DependencyInjection.Interface
{
    interface IServiceSetter
    {
        void SetService(IService service);
    }
}
