$dirInfo= New-Object -Typename System.IO.DirectoryInfo -ArgumentList ([System.IO.Directory]::GetCurrentDirectory())
$projectName= $dirInfo.Name;
$key=$env:nugetKey
$buildDay=[DateTime]::Now.ToString("yyMMdd")
$p="build=$($buildDay)".Trim()

function RunCommand
{
    $numOfArgs = $args.Length
    for ($i=0; $i -lt $numOfArgs; $i++)
    {
        iex $args[$i]
        if($LASTEXITCODE -eq 0 -or $i -eq 0) {
            Write-Host "$($args[$i]) success"
        }
        else{
            Write-Host "$($args[$i]) failed"
            return 0
        }
    }
    return 1
}

function NugetPack
{
    $numOfArgs = $args.Length
    for ($i=0; $i -lt $numOfArgs; $i++)
    {
        Write-Host "NugetPack $($args[$i])"

        $result = RunCommand "Remove-Item -Recurse -Force .\bin\Release\**" `
            "dotnet build $($args[$i]).csproj -c Release" `
            "nuget pack $($args[$i]).nuspec -OutputDirectory .\bin\Release -p '$($p)'"

        if($result) {
            Write-Host "$($args[$i]) success"
        }
        else{
            Write-Host "$($args[$i]) failed"
            return 0
        }
    }
    return 1 
}

function NugetPush
{
    $numOfArgs = $args.Length
    for ($i=0; $i -lt $numOfArgs; $i++)
    {
        Write-Host "NugetPush $($args[$i])"

        iex "dotnet nuget push .\bin\Release\*.nupkg --api-key $($key) --source https://api.nuget.org/v3/index.json"
    }
}

$result = NugetPack $projectName
if($result)
{
    if([string]::IsNullOrEmpty($key))
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