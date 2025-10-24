using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduledProgram
{
    class EmailCenter
    { 
        public string FromAddress { get; set; }
        public string ToAddress   { get; set; }
        public string Subject     { get; set; }
        public string Content     { get; set; }
    }
}
