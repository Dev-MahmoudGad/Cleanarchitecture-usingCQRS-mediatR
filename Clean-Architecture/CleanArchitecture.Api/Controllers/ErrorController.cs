using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErrorController : Controller
    {
        [HttpGet]
        public IActionResult GetError()
        {
            var ex = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            return Problem(title: ex.Error.Message);
        }
    }
}
