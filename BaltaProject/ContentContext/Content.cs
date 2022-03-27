using BaltaProject.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaltaProject.ContentContext
{
    public abstract class Content : BaseContent
    {

        public string Title { get; set; }
        public string Url { get; set; }
        public string MyProperty { get; set; }

        public Content(string title, string url)
        {
            Title = title;
            Url = url;
        }
    }
}
