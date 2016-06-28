using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lhr.Mvc.Base.Models
{
    public class GridColumn 
    {
        public Types.Base.LhrField Field { get; set; }
        public int Width { get; set; }
        public GridColumn(Types.Base.LhrField field)
        {
            Field = field;
        }

    }
}
