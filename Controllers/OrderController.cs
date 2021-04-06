using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learn_API.Controllers
{
    [Route ("v1/order")]
    public class OrderController: ControllerBase
    {
        [HttpGet]
        [Route ("")]
        public IActionResult Get()
        {

            return Ok("Presunto");
        }
        [HttpPost]
        [Route("")]
        public IActionResult Post()
        {

            return Ok("Mortadela");
        }
    }
    
}
