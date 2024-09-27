using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System; // For mathematical operations

namespace YourNamespace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Q8Controller : ControllerBase
    {
        // Constants for small and large squash prices, and HST rate

        private const decimal SmallPrice = 25.50m;
        private const decimal LargePrice = 45.50m;
        private const decimal HSTRate = 0.13m; // 13% tax rate

        [HttpPost("squashfellows")]
        public string OrderSquashFellows([FromForm] int Small, [FromForm] int Large) // Method to handle the form data (quantity of Small and Large)
        {
           
           // Calculate total for small and large orders
            decimal smallTotal = Small * SmallPrice;
            decimal largeTotal = Large * LargePrice;
            decimal subtotal = smallTotal + largeTotal; // Calculate subtotal
            decimal tax = Math.Round(subtotal * HSTRate, 2); // Calculate and round the tax (13%)
            decimal total = subtotal + tax;// Calculate the total including tax

            // Create a summary of the order with all details
            string summary = $"{Small} Small @ ${SmallPrice} = ${smallTotal:F2}; " +
                             $"{Large} Large @ ${LargePrice} = ${largeTotal:F2}; " +
                             $"Subtotal = ${subtotal:F2}; " +
                             $"Tax = ${tax:F2} HST; " +
                             $"Total = ${total:F2}";

            return summary; // Return the summary
        }
    }
}
