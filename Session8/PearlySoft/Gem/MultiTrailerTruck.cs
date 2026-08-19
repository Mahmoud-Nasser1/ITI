
namespace Gem
{
    public class MultiTrailerTruck : Truck
    {

            public static DateTime firstTimeTruck;
            public static DateTime currentDateTime { get; set; }
            public static string Manufacturer { get; set; }

            public static void GreetVisitor()
            {
                Console.WriteLine("\nWelcome to Pearly Soft!");
            }

            //Access Modifiers are now allowed on static constructors
            //A static constructor must be parameterless
            static MultiTrailerTruck()
            {
                Console.WriteLine("Hi from MultiTrailerTruck Static Constructor!");

                //Initialize static members
                currentDateTime = DateTime.Now;
            }

            //Non-static Constructor
            public MultiTrailerTruck()
            {
                Console.WriteLine("Hello from MultiTrailerTruck non-static/instance parameterless Constructor!");
            }
        
        public MultiTrailerTruck(string trkModel, string trkColor, double trkWidth, double trkLength, double trkHeight, int trkMaxSpeed, string trkEngine, double trkBoxVol, int numberOfTrailers) : base(trkModel, trkColor, trkWidth, trkLength, trkHeight, trkMaxSpeed, trkEngine, trkBoxVol)
        {
            NumberOfTrailers = numberOfTrailers;
        }

        public int NumberOfTrailers { get; set; }

        // Method Overriding (Run-time Polymorphism) preventing further overriding in derived classes
        public sealed override string ShowSpecifications(string type)
        {
            return base.ShowSpecifications(type) +
                $"\nNumber of Trailers\t: {NumberOfTrailers}";
        }
    }
}
