using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace IoT.IoTManagement.API1.Controllers.V1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/devices")]
    [Route("api/v{version:apiVersion}/devices")]
    public class SystemController : Controller
    {

        public SystemController()
        {

        }

        [ApiExplorerSettings(IgnoreApi = true)]
        [HttpGet("{timestamp:int}")]
        public async Task<int> Get(int timestamp)
        {
            return await Task.FromResult<int>(timestamp);
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        [HttpGet("exception/test")]
        public async Task ExceptionTest()
        {
            throw new Exception("Test");
        }
    }
}
