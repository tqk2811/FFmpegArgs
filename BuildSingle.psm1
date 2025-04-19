Import-Module $PSScriptRoot\FunctionModule.psm1

function NugetBuildSingle
{
	$projectName= $args[0];
	$buildDay=[DateTime]::Now.ToString("yyMMdd")
	$env:FFmpegArgsBuild=$buildDay

	$result = NugetPack $projectName
	if($result)
    {
        if([string]::IsNullOrEmpty($env:nugetKey))
        {
            Write-Host "Build & pack success"
        }
        else
        {
            Write-Host "enter to push nuget"
            pause
            Write-Host "enter to confirm"
            pause

            NugetPush $projectName
        }
    }
    else
    {
        echo "Build & pack error"
    }
    pause
}