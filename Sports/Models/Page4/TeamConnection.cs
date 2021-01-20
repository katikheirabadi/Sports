using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports.Models.Page3
{
    public class TeamConnection
    {
        public string Id { get; set; }
        public string Team_Name { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
    }
    public class TeamConnectionList
    {
        public List<TeamConnection> Team { get; set; }
    }
}
