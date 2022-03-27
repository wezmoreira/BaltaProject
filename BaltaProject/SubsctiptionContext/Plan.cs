using BaltaProject.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaltaProject.SubsctiptionContext
{
    public class Plan : BaseContent
    {
        public string Title { get; set; }
        public decimal Price { get; set; }

    }
}
