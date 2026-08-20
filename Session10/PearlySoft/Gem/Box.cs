using System.Threading.Channels;

namespace Gem
{
    public class Box<T>
    {
        public T Value { get; set; }

        public 
            Box() { }
        public Box(T value)
        {
            Value = value;
        }   

        public void Display() => Console.WriteLine(Value);
    }
}