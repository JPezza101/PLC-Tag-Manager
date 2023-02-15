using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag_Manager
{
    public class IP
    {
        public string Gateway { get; set; }
        public string Rack { get; set; }
        public string Slot { get; set; }
        public string Path { get; set; }
        public string CpuType { get; set; }
        public string CommType { get; set; }
        public bool IPValidated { get; set; } = false;
        public bool RackValidated { get; set; } = false;
        public bool SlotValidated { get; set; } = false;
    }
}
