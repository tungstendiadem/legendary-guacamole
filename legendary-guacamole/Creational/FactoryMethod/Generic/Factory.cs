using System;

namespace Creational.FactoryMethod.Generic
{
    public class Factory<T> : IFactory<T>
    {
        public IProduct<T> GetProduct(EProducts eproduct)
        {
            switch (eproduct)
            {
                case EProducts.Product01:
                    return new Product01<T>();
                case EProducts.Product02:
                    return new Product02<T>();
                case EProducts.ProductNN:
                    return new ProductNN<T>();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}