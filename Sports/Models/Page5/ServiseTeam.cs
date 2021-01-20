using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports.Models.Page5
{
    public class ServiseTeam
    {
        public string idEvent { get; set; }
        public string strEvent { get; set; }
        public string strHomeTeam { get; set; }
        public string strAwayTeam { get; set; }
    }
    public class ServiseTeamList
    {
        public List<ServiseTeam> events { get; set; }
    }
}
