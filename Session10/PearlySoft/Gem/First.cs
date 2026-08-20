

namespace Gem
{
    public class First
    {
        //Accessible from anywhere
        public int publicNo;

        //Accessible from its type (class) only
        private int privateNo;

        //Accessible from its type and its child/sub/derived type
        protected int protectedNo;

        public First()
        {
            privateNo = 17;
            publicNo = 27;
            protectedNo = 37;
        }
    }
}
