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
using Microsoft.AspNetCore.Mvc;

namespace ResumeIQ.Controllers;

[ApiController]
[Route("api/upload")]
public class ResumeUploadController : ControllerBase
{
    [HttpPost]
    public IActionResult Upload(IFormFile file)
    {
        if (file == null)
            return BadRequest();

        return Ok(new
        {
            FileName = file.FileName,
            Size = file.Length
        });
    }
}
