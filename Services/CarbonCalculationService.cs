using Microsoft.AspNetCore.Mvc;
using ecoMuffins.Models;

namespace ecoMuffins.Services
{
    public class CarbonCalculationService
    {
        public CarbonCalculationReturnModel CalculateCarbon(CarbonCalculationModel calc) 
        {
            double carbonKg = 0;
            int starRating = 0;
            switch(calc.TransportType) 
            {
                case JourneyType.Car:
                    carbonKg = 0.133*calc.Distance; /* Using "medium car" value */
                    starRating = 1;
                    break;
                case JourneyType.Bus:
                    carbonKg = 0.069*calc.Distance;
                    starRating = 3;
                    break;
                case JourneyType.Train:
                    carbonKg = 0.065*calc.Distance; /* Using "underground/metro" value */
                    starRating = 3;
                    break;
                case JourneyType.Bike:
                    starRating = 5;
                    carbonKg = 0;
                    break;
                case JourneyType.Walk:
                    starRating = 5;
                    carbonKg = 0;
                    break;
            }
            return new CarbonCalculationReturnModel {
                TransportType = calc.TransportType,
                CarbonKg = carbonKg,
                StarRating = starRating,
            };
        }
    }
}
