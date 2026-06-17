using Xunit;
using ResumeIQ.Services;

public class ATSServiceTests
{
    [Fact]
    public void Score_Should_Return_100()
    {
        ATSService service =
            new ATSService();

        int score =
            service.CalculateScore(
            "C#,.NET,SQL,React,Git");

        Assert.Equal(100, score);
    }
}
