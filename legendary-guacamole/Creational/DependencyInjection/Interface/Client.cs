using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.DependencyInjection.Interface
{
    class Client : IServiceSetter // System.ComponentModel.IServiceProvider.GetService(Type serviceType)
    {
        private IService _service;

        public Client()
        {
        }

        public void SetService(IService service)
        {
            _service = service;
        }
    }
}
