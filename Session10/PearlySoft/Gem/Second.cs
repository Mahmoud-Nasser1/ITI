
namespace Gem
{
    public class Second : First
    {
        public Second()
        {
            publicNo = 100;
            protectedNo = 200;
        }

        void Test()
        {
            publicNo = 1000;
            protectedNo = 2000;
        }
    }
}
