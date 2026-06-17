function analyzeResume(){

    let skills =
    document.getElementById("skills").value;

    let score = 0;

    if(skills.includes("C#"))
        score += 20;

    if(skills.includes(".NET"))
        score += 20;

    if(skills.includes("SQL"))
        score += 20;

    if(skills.includes("React"))
        score += 20;

    if(skills.includes("Git"))
        score += 20;

    document.getElementById("result")
    .innerText =
    "ATS Score: " + score + "%";
}
