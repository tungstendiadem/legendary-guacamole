namespace Creational.Builder.Generic
{
    internal class Product<T> : AProduct<T>
    {
        private Part01<T> _part01;
        private Part02<T> _part02;
        private PartNN<T> _partNN;

        public Product(Part01<T> part01, Part02<T> part02, PartNN<T> partNN) : base(part01, part02, partNN)
        {
            _part01 = part01;
            _part02 = part02;
            _partNN = partNN;
        }
    }
}