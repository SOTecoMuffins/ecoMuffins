using Microsoft.AspNetCore.Mvc;
using ecoMuffins.Models;

namespace ecoMuffins.Services
{
    public class CarbonCalculationService
    {
        public CarbonCalculationReturnModel CalculateCarbon(CarbonCalculationModel calc) 
        {
            double carbonKg = new double();
            int rating = new int();
            switch(calc.TransportType) 
            {
                case JourneyType.Car:
                    carbonKg = 0.133*calc.Distance; /* Using "medium car" value */
                    rating = 3;
                    break;
                case JourneyType.Bus:
                    carbonKg = 0.069*calc.Distance;
                    rating = 5;
                    break;
                case JourneyType.Train:
                    carbonKg = 0.065*calc.Distance; /* Using "underground/metro" value */
                    rating = 6;
                    break;
                case JourneyType.Bike:
                    carbonKg = 0;
                    rating = 10;
                    break;
                case JourneyType.Walk:
                    carbonKg = 0;
                    rating = 10;
                    break;
            }
            return new CarbonCalculationReturnModel {
                TransportType = calc.TransportType,
                CarbonKg = carbonKg,
                EcoRating = rating,
            };
        }
    }
}
