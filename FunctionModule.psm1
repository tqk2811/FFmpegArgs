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
    for ($i=0; $i -lt $args.Length; $i++)
    {
        $id = $args[$i]
        $name =  $id -replace "FFmpegArgs.", ""

        Write-Host "NugetPack $id"
        $result = RunCommand "Remove-Item -Recurse -Force $PSScriptRoot\$id\bin\Release\** -ErrorAction SilentlyContinue; cmd /c exit 0" `
            "dotnet build $PSScriptRoot\$id\$id.csproj -c Release" `
            "nuget pack $PSScriptRoot\$id\$id.nuspec -OutputDirectory $PSScriptRoot\$id\bin\Release -p 'build=$env:FFmpegArgsBuild;name=$name;id=$id'"

        if($result) {
            Write-Host "$id success"
        }
        else{
            Write-Host "$id failed"
            return 0
        }
    }
    return 1 
}
function NugetPush
{
    $nugetKey=$env:nugetKey
    if (-not $nugetKey) {
        Write-Host "Nuget key not found. Please set the environment variable 'nugetKey'."
        return
    }
    for ($i=0; $i -lt $args.Length; $i++)
    {
        $id = $args[$i]

        Write-Host "NugetPush $id"
        
        $files = [System.IO.Directory]::GetFiles("$PSScriptRoot\$id\bin\Release","*.nupkg")
        iex "nuget push $($files[0]) -ApiKey $nugetKey -Source https://api.nuget.org/v3/index.json"
    }
}