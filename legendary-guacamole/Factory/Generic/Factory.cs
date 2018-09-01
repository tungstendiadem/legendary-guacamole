using System;

namespace Factory
{
    public class Factory<T> : IFactory
    {
        public void CreateFactory()
        {
            throw new NotImplementedException();
        }
    }

    public class Plant<T> : IFactory
    {
        public void CreateFactory()
        {
            throw new NotImplementedException();
        }
    }

    public class WorkShop<T> : IFactory
    {
        public void CreateFactory()
        {
            throw new NotImplementedException();
        }
    }
}
