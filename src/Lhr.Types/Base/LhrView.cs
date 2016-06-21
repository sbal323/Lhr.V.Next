using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lhr.Types.Base
{
    public class LhrView
    {
        private List<LhrField> ListFields;
        public Guid Id { get; set; }
        public string ViewName { get; set; }
        public List<LhrField> Fields {
            get{
                return ListFields.OrderBy(f => f.Order).ToList();
            }
            set {
                ListFields = value;
            }
        }
        public LhrView()
        {
            ListFields = new List<LhrField>();
            ListFields.Add(new LhrField { FieldName = "FirstName", Type = "String", Order = 3 });
            ListFields.Add(new LhrField { FieldName = "LastName", Type = "String", Order = 2 });
            ListFields.Add(new LhrField { FieldName = "FullName", Type = "String", Order = 1 });
            ListFields.Add(new LhrField { FieldName = "BankDetails", Type = "String", Order = 4 });
        }
    }
}
