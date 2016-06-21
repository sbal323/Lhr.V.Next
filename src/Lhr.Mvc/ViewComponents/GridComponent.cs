using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace Lhr.Mvc.ViewComponents
{
    public class GridComponent : ViewComponent 
    {
        public IViewComponentResult Invoke(Base.GridPageModel gp)
        {
            return View("GridComponent",gp);
        }
    }
}
