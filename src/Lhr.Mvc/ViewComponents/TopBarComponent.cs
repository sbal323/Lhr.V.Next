using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Lhr.Types.UI;
namespace Lhr.Mvc.ViewComponents
{
    public class TopBarComponent:ViewComponent 
    {
        private Base.Models.TopBarModel MainTopBarModel;
        public IViewComponentResult Invoke()
        {
           
            return View("TopBarComponent", MainTopBarModel);
        }
    }
}
