using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using ecoMuffins.Models;
using System.Web.Mvc;

namespace ecoMuffins.Controllers
{
    public class CarbonControllerController : Controller
    {
        // 
        // GET: /HelloWorld/

        public string Index(CarbonCalculationModel model)
    {
        return HtmlEncoder.Default.Encode($"Distance: {model.Distance}, Transport Type: {model.TransportType}");
    }

        public JsonResult Test()
    {
        var model = new CarbonCalculationModel{
            Distance = 9901,
            TransportType = JourneyType.Walk        };
        return Json(model);
    }


    }
}