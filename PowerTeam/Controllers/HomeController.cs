using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PowerTeam.Service.Interface;

namespace PowerTeam.Controllers
{
    public class HomeController : Controller
    {
        private IDeliveryService _deliveryService;
        public HomeController(IDeliveryService deliveryService)
        {
            _deliveryService = deliveryService;
        }
        public IActionResult Index()
        {
            _deliveryService.TestMethod();
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
