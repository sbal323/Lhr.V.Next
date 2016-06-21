using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lhr.Types.Base
{
    public class LhrField
    { /// <summary>
        /// Field name
        /// </summary>
        public string FieldName { get; set; }
       
        /// <summary>
        /// Field Type
        /// </summary>
        public string Type { get; set; }

        public int Order { get; set; }
    }
}
