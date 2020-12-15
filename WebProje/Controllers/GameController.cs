using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebProje.Models;

namespace WebProje.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Page()
        {
            return View();
        }
    }
}
