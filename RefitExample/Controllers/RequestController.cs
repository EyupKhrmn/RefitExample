using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RefitExample.Interfaces;

namespace RefitExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        private readonly ITodoAPI _todoApı;

        public RequestController(ITodoAPI todoApı)
        {
            _todoApı = todoApı;
        }

        [HttpGet]
        public async Task<IActionResult> GetTodos()
        {
            return Ok(await _todoApı.GetTodos());
        }
    }
}
