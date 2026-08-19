
namespace Gem
{
    //A struct cannot inherit/derive or be inherited/derived
    //Use it with lightweight short-lived objects
    public struct ProductDescriptionCard
    {
        public string Name { get; set; }
        public byte Size { get; set; }
        public string Color { get; set; }

        public ProductDescriptionCard(string name, byte size, string color)
        {
            Name = name;
            Size = size;
            Color = color;
        }

        public void PrintCard()
        {
            Console.WriteLine($"Name\t: {Name}\nSize\t: {Size}\nColor\t: {Color}");
        }
    }
}
