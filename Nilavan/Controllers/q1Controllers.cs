using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Q1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class q1Controller : ControllerBase // Controller class that handles API requests
    {
        [HttpGet("welcome")]
        
    
    // Defining a method named "Get" that returns a string
     public string Get()
        {
            // Returning a welcome message as a string
            return "GetWelcomeMessage";
        }
    }
}