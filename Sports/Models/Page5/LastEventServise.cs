using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports.Models.Page5
{
    public class LastEventServise
    {
        public string idEvent { get; set; }
        public string strEvent { get; set; }
        public string strHomeTeam { get; set; }
        public string strAwayTeam { get; set; }
        public string intHomeScore { get; set; }
        public string intAwayScore { get; set; }
    }
    public class LastEventServiseList
    {
        public List<LastEventServise> results { get; set; }
    }
}
