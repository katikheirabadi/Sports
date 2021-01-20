using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports.Models.Page5
{
    public class OutPutTeam
    {
        public string Id { get; set; }
        public string Event_Name { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
    }
    public class OutPutTeamList
    {
        public List<OutPutTeam> Events { get; set; }
    }
}
