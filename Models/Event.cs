using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForexCalender;

namespace Models.ForexCalender
{
    public class Event
    {
        public string title { get; set; }
        public string country { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public string impact { get; set; }
        public string forecast { get; set; }
        public string previous { get; set; }
    }
}
