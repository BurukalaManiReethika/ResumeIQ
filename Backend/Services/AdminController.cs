using Microsoft.AspNetCore.Mvc;

namespace ResumeIQ.Controllers;

[ApiController]
[Route("api/admin")]
public class AdminController : ControllerBase
{
    [HttpGet("stats")]
    public IActionResult Stats()
    {
        return Ok(new
        {
            Users = 250,
            Resumes = 180,
            Analyses = 500
        });
    }
}
