
using System.IO;

namespace SoftwareEngineering
{
    class Distance
    {
        //Solid design principle
        private readonly double kilometer;     //readonly means it can only be assgined by constructor

        public Distance() : this(10.0, 2.0)
        {
            
        }

        public Distance(double meters, double miles)
        {
            Meters = meters;
            Miles = miles;
        }

        public double Meters { get; }
        public double Miles { get; }

        public static Distance operator +(Distance d1, Distance d2)
        {
            return new Distance(d1.Meters+d2.Meters, d1.Miles+d2.Miles);
        }
    }
}
