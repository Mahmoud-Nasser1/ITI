namespace Gem
{
    public interface IItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ExpiryDate { get; set; }

        public double CalculateValidityPeriod();
    }
}