namespace ResumeIQ.Services;

public class JwtService
{
    public string GenerateToken()
    {
        return Guid.NewGuid().ToString();
    }
}
