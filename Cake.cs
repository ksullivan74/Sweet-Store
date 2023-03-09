namespace Products
{
    public class Cake : BakedGood
    {

        public bool Frozen { get; set; }

        public bool Frosted { get; set; }

        public Cake(bool frozenParam, bool frostedParam)
        {
            Frozen = frozenParam;
            Frosted = frostedParam;
        }

        public void Slice()
        {

        }

        public void Frost()
        {

        }
    }
}