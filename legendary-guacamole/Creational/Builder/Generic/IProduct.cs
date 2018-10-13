namespace Creational.Builder.Generic
{
    internal interface IProduct<T>
    {
        void Product(Part01<T> part01, Part02<T> part02, PartNN<T> partNN);
    }
}