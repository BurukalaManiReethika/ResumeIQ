function analyze()
{
    let skills =
    document.getElementById(
    "skills").value;

    let score = 0;

    const required =
    [
        "C#",
        ".NET",
        "SQL",
        "React",
        "Git"
    ];

    required.forEach(skill =>
    {
        if(skills.includes(skill))
        {
            score += 20;
        }
    });

    document.getElementById(
    "score").innerHTML =
    "ATS Score : " + score + "%";
}
