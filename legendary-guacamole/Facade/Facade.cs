using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class Facade : IFacade
    {
        Component01 component01 = new Component01();
        Component02 component02 = new Component02();
        Component03 component03 = new Component03();


        public void Activate01()
        {
            component01.ToString();
        }

        public void Activate02() => component02.ToString();
    }
}
