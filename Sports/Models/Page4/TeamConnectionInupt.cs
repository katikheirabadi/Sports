using System;
using System.Collections.Generic;

namespace Sports.Models.Page4
{
    public class TeamConnectionInput
    {
        public string idTeam { get; set; }
        public string strTeam { get; set; }
        public string strFacebook { get; set; }
        public string strInstagram { get; set; }
    }

    public class TeamConnectionInputList
    {
        public List<TeamConnectionInput> teams { get; set; }
        public TeamConnectionInputList()
        {
            teams = new List<TeamConnectionInput>();
        }
    }
}
