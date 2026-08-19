
namespace Gem
{
    public partial class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"Id\t: {Id}" +
                   $"\nName\t: {Name}" +
                   $"\nEmail\t: {Email}" +
                   $"\nAddress\t: {Address}" +
                   $"\nPhoneNo\t: {PhoneNo}";
        }


    }
}
