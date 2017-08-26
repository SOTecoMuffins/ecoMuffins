using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using ecoMuffins.Models;
using System.Web.Mvc;
using ecoMuffins.Services;

namespace ecoMuffins.Controllers
{
    public class CarbonControllerController : Controller
    {
        // 
        // GET: /HelloWorld/
        // or is it JsonResult<CarbonCalculationModel>
        public JsonResult Index(CarbonCalculationModel model)
        {
            CarbonCalculationService service = new CarbonCalculationService();
            CarbonCalculationReturnModel result = service.CalculateCarbon(model);
            return Json(result);
        }

        // 
        // GET: /HelloWorld/Welcome/ 


        public string Welcome(CarbonCalculationModel model)
        {
            return HtmlEncoder.Default.Encode($"Distance: {model.Distance}, Transport Type: {model.TransportType}");
        }
    }
}