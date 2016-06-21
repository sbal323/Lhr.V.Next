using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lhr.Mvc.Base
{
    public class FilterUIModel
    {
        public Types.Base.FilterData  filterData { get; set; }
        public Types.Base.FilterValue filterValue { get; set; }
        public FilterUIModel()
        {
            filterData = new Types.Base.FilterData();
        }
    }
}
