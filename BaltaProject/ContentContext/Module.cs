using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaltaProject.ContentContext.Enums;
using BaltaProject.SharedContext;

namespace BaltaProject.ContentContext
{
    public class Module : BaseContent
    {
        public Module()
        {
            Lectures = new List<Lecture>();
        }
        public int Order { get; set; }
        public string Title { get; set; }
        public IList<Lecture> Lectures { get; set; }

        public int DurationInMinutes { get; set; }

        public EContentLevel Level { get; set; }
    }
}
