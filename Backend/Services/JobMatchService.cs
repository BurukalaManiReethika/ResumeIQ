namespace ResumeIQ.Services;

public class JobMatchService
{
    public int MatchPercentage(
        string resumeSkills,
        string jobSkills)
    {
        int match = 0;

        string[] skills =
        jobSkills.Split(',');

        foreach(var skill in skills)
        {
            if(resumeSkills.Contains(skill,
                StringComparison.OrdinalIgnoreCase))
            {
                match += 10;
            }
        }

        return match;
    }
}
