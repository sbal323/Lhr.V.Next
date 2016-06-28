using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lhr.Mvc.Base.Models
{
    public class MenuModel
    {
        public List<Types.UI.MenuItem> MenuItems { get; set; }
        public MenuModel() {
            MenuItems = new List<Types.UI.MenuItem>();
            }
    }
}
