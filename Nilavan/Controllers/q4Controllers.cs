using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace q4.Controllers
{
[Route("api/[controller]")]
public class KnockKnockController : ControllerBase
{
    [HttpPost]
    public string knockknock() // Method that responds to POST requests
    {
        return ("Who's there?"); // Returns the string "Who's there?"
    }
}
}