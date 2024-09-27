using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Q6.Controllers
{
    [Route("api/q6")]
    [ApiController]
    public class hexagonsideController : ControllerBase
    {
        [HttpGet(template: "hexagonside")]
        public double q6(double area) // Method that calculates the actual area of a hexagon 
        {
            double hexarea = 3 * Math.Sqrt(3) * area *  area; // Calculates the hexagon's area using the formula
            double actarea = hexarea / 2; // Divides by 2 to get the actual area
            return actarea; // Returns the calculated area
        }
    }
}