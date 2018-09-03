using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.DependencyInjection.Constructor
{
    class Client
    {
        private Service _service;
        Client(Service service)
        {
            _service = service;
        }

        public void setService(Service service)
        {
            _service = service;
        }
    }
}
