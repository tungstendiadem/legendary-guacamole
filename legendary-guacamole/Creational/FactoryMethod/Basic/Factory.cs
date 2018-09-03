using System;

namespace Creational.FactoryMethod.Basic
{
    public class Factory : IFactory
    {
        public IProduct GetProduct(EProducts eproduct)
        {
            switch (eproduct)
            {
                case EProducts.Product01:
                    return new Product01();
                case EProducts.Product02:
                    return new Product02();
                case EProducts.ProductNN:
                    return new ProductNN();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}