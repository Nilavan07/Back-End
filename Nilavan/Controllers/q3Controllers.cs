using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace q3.Controllers
{
[Route("api/[controller]")]
public class CubeController : ControllerBase // Controller class that handles API requests
{
    [HttpGet("{base}")]
    public ActionResult<int> GetCube(int @base)
    {
        int result = @base * @base * @base;// Calculates the cube of the base
        return (result);
    }
}
}