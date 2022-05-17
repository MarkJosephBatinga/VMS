using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS.Shared
{
    public class data
    {
        public int total { get; set; }
        public int recoveries { get; set; }
        public int deaths { get; set; }
        public int active_cases { get; set; }
        public string fatality_rate { get; set; }
        public string recovery_rate { get; set; }

    }
}
