using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lhr.Mvc.Controllers
{
    public class SystemController : Controller
    {
        public IActionResult LastError()
        {
            return View("Error");
        }
    }
}
