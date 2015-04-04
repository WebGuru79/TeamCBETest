using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UCT.Models ;

namespace UCT.Models
{
    public class Version
    {       
        public int VersionID { get; set; }
        public int ProgramID {get; set;}
        public IEnumerable<Program> UserPrograms { get; set; }
    }
}