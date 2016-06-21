using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lhr.Types.Base
{
    public class FilterData
    {
        public Dictionary<int, String> Countries { get; set; }
        public Dictionary<int, String> Locations { get; set; }
        public Dictionary<int, String> OrgUnits { get; set; }
        public FilterData()
        {
            Countries = new Dictionary<int, String>();
            Locations = new Dictionary<int, String>();
            OrgUnits  = new Dictionary<int, String>();

        }

    }
}
