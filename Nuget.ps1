$key=$env:nugetKey
$commit=($(git log --format="%H" -n 1) | Out-String).Trim()
$branch=($(git rev-parse --abbrev-ref HEAD) | Out-String).Trim()
$p="branch=$($branch);commit=$($commit)".Trim()
echo $p
function RunCommand
{
    $numOfArgs = $args.Length
    for ($i=0; $i -lt $numOfArgs; $i++)
    {
        iex $args[$i]
        if($LASTEXITCODE -eq 0) {
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

        $result = RunCommand "Remove-Item -Recurse -Force .\$($args[$i])\bin\Release\**" `
            "dotnet build $($args[$i])\$($args[$i]).csproj -c Release" `
            "nuget pack $($args[$i])\$($args[$i]).nuspec -OutputDirectory .\$($args[$i])\bin\Release -p 'id=$($args[$i]);$($p)'"

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

$result = NugetPack "FFmpegArgs" `
                    "FFmpegArgs.Filters" `
                    "FFmpegArgs.Filters.Autogen" `
                    "FFmpegArgs.Inputs" `
                    "FFmpegArgs.Outputs"
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

        dotnet nuget push FFmpegArgs\bin\Release\*.nupkg --api-key $key --source https://api.nuget.org/v3/index.json
        dotnet nuget push FFmpegArgs.Inputs\bin\Release\*.nupkg --api-key $key --source https://api.nuget.org/v3/index.json
        dotnet nuget push FFmpegArgs.Outputs\bin\Release\*.nupkg --api-key $key --source https://api.nuget.org/v3/index.json
        dotnet nuget push FFmpegArgs.Filters\bin\Release\*.nupkg --api-key $key --source https://api.nuget.org/v3/index.json
        dotnet nuget push FFmpegArgs.Filters.Autogen\bin\Release\*.nupkg --api-key $key --source https://api.nuget.org/v3/index.json
    }
}
else
{
    echo "Build & pack error"
}
pause