using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lhr.Mvc.Base
{
    public class GridPageModel : PageModel 
    {
        private Types.Base.LhrView LocalView;
        public string DataSourceURL { get; set; }
        public FilterUIModel Filter { get; set; }
        public Types.Base.LhrView View {
            get {
                return LocalView;
            }
            set {
                LocalView = value;
                Columns = new List<GridColumn>();
                foreach (Types.Base.LhrField f in LocalView.Fields)
                {
                    Columns.Add(new GridColumn(f));
                }
            }
        }
        public List<GridColumn> Columns { get; set; }
        public string ColumnsSchemaString
        {
            get
            {
                return String.Join(",", Columns.Select(c => "{field: '" + c.Field.FieldName + "'}").ToArray());
            }
        }
        public GridPageModel()
        {
            Filter = new Base.FilterUIModel();
            View = new Types.Base.LhrView();
        }

    }
}
