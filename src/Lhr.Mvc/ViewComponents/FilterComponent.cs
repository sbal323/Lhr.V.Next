using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace Lhr.Mvc.ViewComponents
{
    public class FilterComponent : ViewComponent 
    {
        public IViewComponentResult Invoke(Base.FilterUIModel fm)
        {
            FillFilterData(ref fm);
            return View("FilterComponent", fm);
        }
        private void FillFilterData(ref Base.FilterUIModel fm)
        {
            fm.filterData = new Types.Base.FilterData();
            fm.filterData.Countries.Add(1, "USA");
            fm.filterData.Countries.Add(2, "Ukraine");
            fm.filterData.Countries.Add(3, "France");
            fm.filterData.Countries.Add(4, "Germany");
            fm.filterData.Locations.Add(1, "New York");
            fm.filterData.Locations.Add(2, "Kiev");
            fm.filterData.Locations.Add(3, "Paris");
            fm.filterData.Locations.Add(4, "Munich");
            fm.filterData.OrgUnits.Add(1, "TOP");
            fm.filterData.OrgUnits.Add(2, "Software Development");
            fm.filterData.OrgUnits.Add(3, "Marketing");
            fm.filterData.OrgUnits.Add(4, "Operations");


        }
    }
}
