namespace ResumeIQ.Services;

public class ATSService
{
    public int CalculateScore(string skills)
    {
        int score = 0;

        string[] requiredSkills =
        {
            "C#",
            ".NET",
            "SQL",
            "React",
            "Git"
        };

        foreach(var skill in requiredSkills)
        {
            if(skills.Contains(skill,
                StringComparison.OrdinalIgnoreCase))
            {
                score += 20;
            }
        }

        return score;
    }
}
