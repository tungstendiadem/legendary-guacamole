namespace Creational.AbstractFactory.Generic
{
    public class Factory<T> : IFactory<T>
    {
        public void CreateProduct01()
        {
            Product01<T> product01 = new Product01<T>();
        }

        public void CreateProduct02()
        {
            Product02<T> product02 = new Product02<T>();
        }

        public void CreateProductNN()
        {
            ProductNN<T> productNN = new ProductNN<T>();
        }
    }

}
