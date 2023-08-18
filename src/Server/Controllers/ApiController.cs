using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public abstract class ApiController : ControllerBase
    {
        protected const string Id = "{Id}";
        protected const string PathSeparator = "/";
    }
}
