using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Void.Core.Interfaces;

namespace The_Void.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SisterController : ControllerBase
    {
        private readonly ISisterService sisterService;

        public SisterController(ISisterService sisterService)
        {
            this.sisterService = sisterService;
        }

        public async Task<IActionResult> Insert()
        {
            await sisterService.Insert();


            return Ok();
        }
    }
}



