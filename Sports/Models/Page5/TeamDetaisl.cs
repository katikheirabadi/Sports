using Sports.Models.Page3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports.Models.Page5
{
    public class TeamDetails
    {
        public string idTeam { get; set; }
    }
    public class TmList
    {
        public List<TeamDetails> teams { get; set; }
        public List<TeamDetail> Teams { get; internal set; }
    }
}
