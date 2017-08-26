using Microsoft.AspNetCore.Mvc;
using ecoMuffins.Models;

namespace ecoMuffins.Services
{
    public class CarbonCalculationService
    {
        public CarbonCalculationReturnModel CalculateCarbon(CarbonCalculation calc) 
        {
            double carbonKg = new double();
            switch(calc.TransportType) 
            {
                case JourneyType.Car:
                    carbonKg = 0.133*calc.Distance; /* Using "medium car" value */
                    break;
                case JourneyType.Bus:
                    carbonKg = 0.069*calc.Distance;
                    break;
                case JourneyType.Train:
                    carbonKg = 0.065*calc.Distance; /* Using "underground/metro" value */
                    break;
                case JourneyType.Bike:
                    carbonKg = 0;
                    break;
                case JourneyType.Walk:
                    carbonKg = 0;
                    break;
            }
            return new CarbonCalculationReturnModel {
                TransportType = calc.TransportType,
                CarbonKg = carbonKg,
            };
        }
    }
}