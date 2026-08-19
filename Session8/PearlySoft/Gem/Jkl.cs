
namespace Gem
{
    public class Jkl
    {
        //Field Naming Conventions:
        //1. camel case
        //2. camel case prefixed by underscore
        string code; //camel case
        int _serialNo; //camel case prefixed by underscore

        public Jkl(string code, int serialNo)
        {
            this.code = code;
            _serialNo = serialNo;
        }

        public void Test(string code, int serialNo)
        {
            this.code = code;
            _serialNo = serialNo;
        }

        public void Print()
        {
            Console.WriteLine("Code\t\t: " + code + "\nSerial Number\t: " + _serialNo);
        }
    }
}
