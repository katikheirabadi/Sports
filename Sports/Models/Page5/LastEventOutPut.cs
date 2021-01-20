using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports.Models.Page5
{
    public class LastEventOutPut
    {
        public string Id { get; set; }
        public string Event_Name { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public string Home_Score { get; set; }
        public string Away_Score { get; set; }
    }
    public class LastEventOutPutList
    {
        public List<LastEventOutPut> Events { get; set; }
    }
}
