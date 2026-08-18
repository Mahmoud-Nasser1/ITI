using System;
using System.Collections.Generic;
using System.Text;

namespace Gem
{
    //Child/Sub/derived : Parent/Super/Base
    public class Truck : Vehicle
    {
        //Specific Code
        public double BoxVolume { get; set; }

        public Truck(string trkModel, string trkColor, double trkWidth,
                     double trkLength, double trkHeight,
                     int trkMaxSpeed, string trkEngine, double trkBoxVol)
            : base(trkModel, trkColor, trkWidth, trkLength, trkHeight,
                   trkMaxSpeed, trkEngine)
        {
            BoxVolume = trkBoxVol;
        }

        //Method Overriding (Run-time Polymorphism)
        public override string ShowSpecifications(string type)
        {
            return base.ShowSpecifications(type) +
                   $"\nBox Volume\t: {BoxVolume}";
        }

        public override string GetDescription()
        {
            return "This is a truck.";
        }
    }
}

