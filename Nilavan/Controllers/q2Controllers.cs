using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Q2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q2Controller : ControllerBase // Controller class that handles API requests
    {
        [HttpGet(template: "greetingname{UserChioice}")]
        public string q2(string UserChioice)
        {
            return "Hi" + " " + UserChioice + "!"; // Responds with a personalized greeting
        }
    }
}