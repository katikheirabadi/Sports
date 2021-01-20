using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sports.Models.Page5;
using Sports.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NextController : ControllerBase
    {
        private readonly SportClient client;

        public NextController(SportClient client)
        {
            this.client = client;
        }
        [HttpGet]
        public OutPutTeamList ShowEvents()
        {
            return client.GetNextEvents(client.GetId());
        } 
    }
}
