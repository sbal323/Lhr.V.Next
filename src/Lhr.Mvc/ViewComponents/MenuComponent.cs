using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Lhr.Types.UI;
namespace Lhr.Mvc.ViewComponents
{
    public class MenuComponent: ViewComponent 
     {
        private Base.Models.MenuModel MainMenuModel; 
        public IViewComponentResult Invoke()
        {
            InitMenuModel();
            return View("MenuComponent", MainMenuModel);
        }
        private void InitMenuModel()
        {
            MainMenuModel = new Base.Models.MenuModel();
            MainMenuModel.MenuItems.Add(new MenuItem { Id = 1, Title = "Core HR", ParentItemId = -1, Icon = "wb-users" });
            MainMenuModel.MenuItems[0].SubItems.Add(new MenuItem { Id = 2, Title = "Employees", ParentItemId = 1, Url= "/Home/SampleGrid" });
            MainMenuModel.MenuItems[0].SubItems.Add(new MenuItem { Id = 3, Title = "Org Charts", ParentItemId = 1, Url = "/OrgStructure" });
            MainMenuModel.MenuItems[0].SubItems.Add(new MenuItem { Id = 4, Title = "Documents", ParentItemId = 1, Url = "/Documents" });
            MainMenuModel.MenuItems.Add(new MenuItem { Id = 5, Title = "Time & Attendance", ParentItemId = -1, Icon = "wb-calendar" });
            MainMenuModel.MenuItems[1].SubItems.Add(new MenuItem { Id = 6, Title = "Absences", ParentItemId = 5, Url = "/Absences" });
            MainMenuModel.MenuItems[1].SubItems.Add(new MenuItem { Id = 7, Title = "Timesheets", ParentItemId = 5, Url = "/Timesheets" });
        }
    }
}
