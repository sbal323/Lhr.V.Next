using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lhr.Types.UI
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public int Order { get; set; }
        public int ParentItemId { get; set; }
        public bool IsActive { get; set; }
        public List<MenuItem> SubItems { get; set; }
        public MenuItem()
        {
            SubItems = new List<MenuItem>();
        }
    }
}
