using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.FileProviders;
using Microsoft.AspNet.Hosting;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.Extensions.OptionsModel;
using Lhr.Types.System;
using Lhr.Bl;
using Lhr.Mvc.Filters;
using Lhr.Mvc.Services.Session;
using Newtonsoft.Json;

namespace Lhr.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private IBlEmployee BLEmployee { get; set; }
        private AppSettings Settings { get; set; }
        private ISessionService Session;
        public HomeController(IOptions<AppSettings> settings, IBlEmployee blEmployee, ISessionService sessionService)
        {
            Settings = settings.Value;
            BLEmployee = blEmployee;
            Session = sessionService;
        }
        public IActionResult Index()
        {
            var empl = BLEmployee.Get(0);
           // throw new Exception("This is unhandled exception");
            return View(empl);
            
        }
        public IActionResult About()
        {
            ViewData["Title"] = $"Your application looking for views here: {Settings.PathToCoreViewsDirectory} and for addons here {Settings.AddonsFolderName}";

            return View();
        }

        public IActionResult Contact()
        {
            return View();

        }
        public IActionResult SampleGrid()
        {
            Base.Models.GridPageModel gp = new Base.Models.GridPageModel();
            gp.PageTitle = "Employees";
            gp.DataSourceURL = "/Home/GetEmployees";
            return View(gp);

        }
        public IActionResult Template()
        {

            return View();

        }

        public IActionResult Error()
        {
            return View();
        }
        public JsonResult GetEmployees(Types.Base.FilterValue filterValue)
        {
            
           JsonResult jr = Json(BLEmployee.GetEmployees(filterValue));
           return jr;

        }
        
    }
}
