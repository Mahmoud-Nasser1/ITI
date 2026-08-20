namespace Gem
{

    //محمود ناصر محمد خليل 
    public class SemiFinished : IItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ExpiryDate { get; set; }

        public double CalculateValidityPeriod()
        {
            return Convert.ToInt32((ExpiryDate - DateTime.Now).TotalDays);
        }
    }
}