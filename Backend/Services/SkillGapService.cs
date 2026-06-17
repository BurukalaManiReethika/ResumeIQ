namespace ResumeIQ.Services;

public class SkillGapService
{
    public List<string> FindMissingSkills(
        string skills)
    {
        List<string> missing =
        new();

        string[] requiredSkills =
        {
            "C#",
            ".NET",
            "SQL",
            "React",
            "Git",
            "Docker",
            "Azure"
        };

        foreach(var skill in requiredSkills)
        {
            if(!skills.Contains(skill,
                StringComparison.OrdinalIgnoreCase))
            {
                missing.Add(skill);
            }
        }

        return missing;
    }
}
