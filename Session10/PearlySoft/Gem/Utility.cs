namespace Gem
{
    //1. cannot declare a variable of it
    //2. cannot create an instance of it
    //3. cannot contain non-static/instance members
    //   while instance class can contain static members
    //4. cannot inherit/derive or be inherited/derived from
    public static class Utility
    {
        public static string HeadOfficeAddress { get; set; }

        public static void GreetUser(string username)
        {
            Console.WriteLine("Hi, " + username +
                              ". Welcome to Pearly Soft!");
        }
    }
}