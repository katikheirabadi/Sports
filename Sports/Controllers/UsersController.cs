using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sports.Models.Page1;
using Sports.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        readonly UserRepository_Page1 userRepository;
        public UsersController()
        {
            userRepository = new UserRepository_Page1();
        }
        [HttpPost]
        public Users Create([FromBody]Users users)
        {
            userRepository.Insert(users);
            Users.Mysport = users.favorite_sport;
            Users.MyTeam = users.favorite_team;
            return users;
        }
    }
}
