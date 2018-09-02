namespace Creational.Builder.Basic
{
    internal class Product : AProduct
    {
        private Part01 _part01;
        private Part02 _part02;
        private PartNN _partNN;

        public Product(Part01 part01, Part02 part02, PartNN partNN) : base(part01, part02, partNN)
        {
            _part01 = part01;
            _part02 = part02;
            _partNN = partNN;
        }
    }
}