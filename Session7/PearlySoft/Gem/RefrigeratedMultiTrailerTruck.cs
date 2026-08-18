using System;
using System.Collections.Generic;
using System.Text;

namespace Gem
{
    public class RefrigeratedMultiTrailerTruck : MultiTrailerTruck
    {
        public RefrigeratedMultiTrailerTruck(string trkModel, string trkColor, double trkWidth, double trkLength, double trkHeight, int trkMaxSpeed, string trkEngine, double trkBoxVol, int numberOfTrailers) : base(trkModel, trkColor, trkWidth, trkLength, trkHeight, trkMaxSpeed, trkEngine, trkBoxVol, numberOfTrailers)
        {
        }
        //public override string ShowSpecifications(string type)
        //{
        //    return base.ShowSpecifications(type);
        //}
    }
}
