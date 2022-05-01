using Microsoft.AspNetCore.Mvc;
using CallApp.Domain.Respons.Data.Abstraction;

namespace CallApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController : ControllerBase
    {
        protected IActionResult Response<T>(IDataResponse<T> result)
        {
            if (result.IsError)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }


        protected IActionResult Response(IDataResponse result)
        {
            if (result.IsError)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }
    }
}