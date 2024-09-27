using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace YourNamespace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Q7Controller : ControllerBase
    {
        [HttpGet("timemachine")]
        public string TimeMachine(int days) // Method that accepts the number of days to add/subtract
        {
           DateTime today = DateTime.Today; // Gets today's date

            
            DateTime adjustedDate = today.AddDays(days); // Adds or subtracts the given number of days

            
            string formattedDate = adjustedDate.ToString("yyyy-MM-dd"); // Formats the date as "yyyy-MM-dd"


        
            return (formattedDate); // Returns the adjusted and formatted date
        }
    }
}
