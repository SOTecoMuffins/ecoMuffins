using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using ecoMuffins.Models;
using ecoMuffins.Services;

namespace ecoMuffins.Controllers
{
    public class CarbonController : Controller
    {
        // 
        // GET: /HelloWorld/

        public string Index(CarbonCalculationModel model)
    {
        return HtmlEncoder.Default.Encode($"Distance: {model.Distance}, Transport Type: {model.TransportType}");
    }

    [HttpPost]
        public JsonResult Test(CarbonCalculationModel postedModel)
    {
        var service = new CarbonCalculationService();
        var returnModel = service.CalculateCarbon(postedModel);
        return Json(returnModel);
    }
    
    }
}