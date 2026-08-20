namespace Gem
{
    public class ShoppingCart
    {
        private string[] products = new string[3];
        public int Count { get; set; }

        public string this[int i]
        {
            get
            {
                if (i < 0 || i >= products.Length)
                {
                    return "Out of range index.";
                }

                return products[i];
            }
            set
            {
                if (i < 0 || i >= products.Length)
                {
                    return;
                }

                products[i] = value;
                Count++;
            }
        }
    }
}