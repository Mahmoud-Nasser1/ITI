namespace Gem
{
    // implement
    public class RawMaterial : IItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ExpiryDate { get; set; }

        public double CalculateValidityPeriod()
        {
            return Convert.ToInt32((ExpiryDate - DateTime.Now).TotalDays);
        }

        public override string ToString()
        {
            return $"\nId\t\t: {Id}" +
                   $"\nName\t\t: {Name}\n" +
                   $"Expiry Date\t: {ExpiryDate.ToShortDateString()}";
        }
    }
}