using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sports.Models.Page3;
using Sports.Models.Page4;
using Sports.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sports.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeamsController : ControllerBase
    {
        private readonly SportClient client;

        public TeamsController(SportClient client)
        {
            this.client = client;
        }

        [HttpGet]
        public TeamDetailList GetAllTeamInLeague([FromQuery] int league_id, [FromQuery] int selected)
        {
            return client.GetAllTeamInLeague(league_id, selected);
        }

        [HttpGet("{team_id}")]
        public TeamConnectionList GetTeamConnection(int team_id)
        {
            return client.GetTeamConnection(team_id);
        }
    }
}
