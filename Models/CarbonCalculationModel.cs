using System;

namespace ecoMuffins.Models
{
    public class CarbonCalculationModel
    {
        public JourneyType TransportType {get; set;}
        public double Distance { get; set; }
    }
    
    public enum JourneyType 
    {
        Bus = 0,
        Train = 1,
        Bike = 2,
        Walk = 3,
        Car = 4
    };
}