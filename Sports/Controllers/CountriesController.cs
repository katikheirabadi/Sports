using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sports.Models.Page1_1;
using Sports.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly SportClient sport;
        public CountriesController(SportClient client)
        {
            sport = client;
        }
        [HttpGet]
        public OutPutLists ShowCountries()
        {
            return sport.GetCoutries();
        } 
    }
}
