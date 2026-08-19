namespace Gem
{   // This is the second part of the Customer class
    //partial classes allow you to split the definition of a class across multiple files
    public partial class Customer
    {
        public string Email { get; set; }
        public string Address { get; set; }

        public string PhoneNo { get; set; }
    }
}
