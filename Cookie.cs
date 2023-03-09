namespace Products
{
    public class Cookie : BakedGood
    {
        public bool? Frosted { get; set; }

        public Cookie(bool frostedParam)
        {
            Frosted = frostedParam;
        }

        public void Frost()
        {

        }
    }
}