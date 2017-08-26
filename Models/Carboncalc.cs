using System;

namespace ecoMuffins.Models
{
    public class CarbonCalculation{
        public JourneyType {get; set;}
        public double Distance { get; set; }
    }
    public Enum JourneyType {
        Bus,
        Train,
        Bike,
        Walk,
        Car
    }
}