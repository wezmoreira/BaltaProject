using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BaltaProject.ContentContext
{
    public class Course : Content
    {
        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }

        public Course(string title, string url) : base(title, url)
        {
            Modules = new List<Module>();
        }
    }













}
