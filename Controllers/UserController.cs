using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learn_API.Controllers
{
    [Route ("v1/user")]
    public class UserController: ControllerBase
    {
        [HttpPut]
        [Route("")]
        public IActionResult UpdateAddress()
        {
            return Ok("Atualizado");
        }
        
    }
}
