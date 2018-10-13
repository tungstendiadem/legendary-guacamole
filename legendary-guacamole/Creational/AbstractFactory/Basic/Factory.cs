using System;

namespace Creational.AbstractFactory.Basic
{
    public class Factory : IFactory
    {
        public void CreateProduct01()
        {
            Product01 product01 = new Product01();
        }

        public void CreateProduct02()
        {
            Product02 product02 = new Product02();
        }

        public void CreateProductNN()
        {
            ProductNN productNN = new ProductNN();
        }
    }

}
