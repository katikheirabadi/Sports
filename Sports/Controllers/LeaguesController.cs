using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sports.Models.Page2;
using Sports.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaguesController : ControllerBase
    {
        private readonly SportClient sportClient;
        public LeaguesController(SportClient sportClient)
        {
            this.sportClient = sportClient;
        }

        [HttpGet]
        public OutputList Get_Leagues([FromQuery]string country,[FromQuery] int selected)
        {
            return sportClient.Get_Leagues(country, selected);
        }
    }
}
