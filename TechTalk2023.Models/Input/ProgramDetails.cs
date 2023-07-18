using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTalk2023.Models.Input
{ 
    public class ProgramDetails
    {
        public int ProgramId { get; set; } 
        public string ProgramCode { get; set; }
        public string ProgramDescription { get; set; }
        public string ProgramName { get; set; }
        public string ProgramType { get; set; }
        public int ProgramYear { get; set; } 
    }
}
