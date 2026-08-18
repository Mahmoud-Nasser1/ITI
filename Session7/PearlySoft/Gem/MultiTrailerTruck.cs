
namespace Gem
{
    public class MultiTrailerTruck : Truck
    {
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
