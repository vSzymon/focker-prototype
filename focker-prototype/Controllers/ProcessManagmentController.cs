﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace focker_prototype.Controllers
{
    public class ProcessManagmentController : ApiController
    {
        [HttpPost]
        public async Task<IActionResult> Create() 
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Kill() 
        {
            return Ok();
        }
     

    }
}