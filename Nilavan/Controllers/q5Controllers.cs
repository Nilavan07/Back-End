using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace q5.Controller
{
[ApiController]
[Route("api/[controller]")]
public class SecretController : ControllerBase
{
    [HttpPost(template: "secret")] // Handles POST requests to "api/Secret/secret"
    public string q5([FromBody]int integer) // Accepts an integer from the request body
    {
        return $"Shh.. the secret is {integer}"; // Returns a message that includes the secret integer
    }
}
}
