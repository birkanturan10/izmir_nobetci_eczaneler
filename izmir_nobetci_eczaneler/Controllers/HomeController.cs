using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using izmir_nobetci_eczaneler.Models;

namespace izmir_nobetci_eczaneler.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string json = new WebClient().DownloadString("https://openapi.izmir.bel.tr/api/ibb/nobetcieczaneler");
            var pharmacy = JsonConvert.DeserializeObject<List<Pharmacy>>(json);
            return View(pharmacy);
        }
    }
}
