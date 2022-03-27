using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaltaProject.ContentContext
{
    public class Career : Content
    {
        public IList<CareerItem> Items { get; set; }
        public Career(string title, string url) : base(title, url)
        {
            Items = new List<CareerItem>();
        }

        public int TotalCourses  // Ou => Items.Count;
        {
            get 
            { 
                return Items.Count;
            }
        }
    }
}
