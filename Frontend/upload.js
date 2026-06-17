function uploadResume()
{
    let file =
    document.getElementById(
    "resumeFile").files[0];

    if(file)
    {
        document.getElementById(
        "message").innerHTML =
        file.name +
        " uploaded successfully";
    }
}
