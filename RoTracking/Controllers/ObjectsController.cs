using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoTracking.Controllers
{
    public class ObjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
