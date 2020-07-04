using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParksNearMe.Models
{
    public class Chart
    {
        public string chartTitle { get; set; }
        public string data { get; set; }
        public string chartType { get; set; }
        public string labels { get; set; }
        public string backgroundColors { get; set; }
    }
}
