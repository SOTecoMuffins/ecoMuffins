using System;

namespace ecoMuffins.Models
{
    public class Carboncalc{
        public JourneyType {get; set;}
        public double Distance { get; set; }
    }
    public Enum JourneyType {
        Bus,
        Train,
        Bike,
        Walk
    }
}