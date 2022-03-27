using BaltaProject.ContentContext.Enums;
using BaltaProject.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaltaProject.ContentContext
{
    public class Lecture : BaseContent
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }

        public EContentLevel Level { get; set; }
    }
}
