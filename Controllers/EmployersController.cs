using EmployerApi.Models.Employer;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using EmployerApi.Data;
using System.Threading.Tasks;

namespace EmployerApi.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployerController : ControllerBase
{


    private readonly EmployerContext _context;

    public EmployerController(EmployerContext context)
    {
        _context = context;
    }

    [HttpGet("Employers")]
    public async Task<ActionResult<IEnumerable<Employer>>>  getEmployerDetails([FromQuery] string name)
    {
        // This is a placeholder. Replace with your actual logic.
        /*var response = new Employer
        {
            ClientDealerCode = "SAGOV",
            Active = false  
        };*/

        var employer = await _context.Employers
                .Where(e => e.Name == name)
                .ToListAsync();

        if (employer == null || employer.Count == 0)
        {
            return NotFound();
        }

        // Normally, you would have logic to determine the price and color based on the "make" parameter.
        return Ok(employer);
    }
}
