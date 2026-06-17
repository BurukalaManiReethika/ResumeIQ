using Microsoft.AspNetCore.Mvc;
using ResumeIQ.Services;

namespace ResumeIQ.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ResumeController : ControllerBase
{
    [HttpPost("analyze")]
    public IActionResult Analyze(
        [FromBody] string skills)
    {
        ATSService ats =
        new ATSService();

        SkillGapService gap =
        new SkillGapService();

        return Ok(new
        {
            ATSScore =
            ats.CalculateScore(skills),

            MissingSkills =
            gap.FindMissingSkills(skills)
        });
    }
}
