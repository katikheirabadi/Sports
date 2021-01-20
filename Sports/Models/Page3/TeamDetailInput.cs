using System;
using System.Collections.Generic;

namespace Sports.Models.Page3
{
    public class TeamDetailInput
    {
        public string idTeam { get; set; }
        public string strTeam { get; set; }
    }

    public class TeamDetailInputList
    {
        public List<TeamDetailInput> teams { get; set; }
        public TeamDetailInputList()
        {
            teams = new List<TeamDetailInput>();
        }
    }
}
