using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace focker_prototype.Controllers
{
    public class ProcessInfoController : ApiController
    {
        [HttpGet("id")]
        public async Task<IActionResult> Get(string id)
        {
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok();
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetStandardOutput(string id)
        {
            return Ok();
        }

    }
}
