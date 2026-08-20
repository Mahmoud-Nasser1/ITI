using System.Globalization;

namespace Gem
{
    public static class ExtenMethod
    {
        //1. static class
        //2. static method
        //3. Must have a parameter of the type to extend
        //4. add 'this' keyword before the parameter type
        public static void WriteToConsoleInParentheses(this string str)
        {
            Console.WriteLine("((" + str + "))");
        }

        public static string FormatAsEgyptianCurrency(this decimal amount)
        {
            return amount.ToString("C2", CultureInfo.CreateSpecificCulture("ar-EG"));
        }

        public static string FormatAsBritishCurrency(this decimal amount)
        {
            return amount.ToString("C2", CultureInfo.CreateSpecificCulture("en-GB"));
        }

        public static bool IsAllowedHiringBirthDate(this DateTime birthDate)
        {
            return birthDate.AddYears(18) <= DateTime.Now;
        }
    }
}