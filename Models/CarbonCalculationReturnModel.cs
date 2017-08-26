using System;

namespace ecoMuffins.Models
{
    public class CarbonCalculationReturnModel
    {
        public JourneyType TransportType {get; set;}
        public double CarbonKg {get; set;}
        public int StarRating {get; set;}
    }
}
