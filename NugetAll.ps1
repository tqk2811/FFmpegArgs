Import-Module .\FunctionModule.psm1

$names= @(
    "FFmpegArgs",
    "FFmpegArgs.Codec",
    "FFmpegArgs.Cores",
    "FFmpegArgs.Executes",
    "FFmpegArgs.Extensions",
    "FFmpegArgs.Filters",
    "FFmpegArgs.Filters.AudioFilters",
    #"FFmpegArgs.Filters.AudioSinks",
    "FFmpegArgs.Filters.AudioSources",
    "FFmpegArgs.Filters.Generated",
    "FFmpegArgs.Filters.Multimedia",
    #"FFmpegArgs.Filters.MultimediaSources",
    "FFmpegArgs.Filters.OpenCLVideoFilters",
    #"FFmpegArgs.Filters.VAAPIVideoFilters",
    "FFmpegArgs.Filters.VideoFilters",
    #"FFmpegArgs.Filters.VideoSinks",
    "FFmpegArgs.Filters.VideoSources",
    "FFmpegArgs.Inputs",
    "FFmpegArgs.Outputs"
)

$result = NugetPack @names
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

        NugetPush @names
    }
}
else
{
    echo "Build & pack error"
}
pause