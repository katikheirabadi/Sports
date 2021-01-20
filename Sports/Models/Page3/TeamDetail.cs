using System;
using System.Collections.Generic;

namespace Sports.Models.Page3
{
    public class TeamDetail
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
    }

    public class TeamDetailList
    {
        public List<TeamDetail> Teams { get; set; }
    }
}
