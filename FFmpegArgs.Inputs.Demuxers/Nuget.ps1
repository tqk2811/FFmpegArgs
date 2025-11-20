Import-Module ..\BuildSingle.psm1
$dirInfo= New-Object -Typename System.IO.DirectoryInfo -ArgumentList ([System.IO.Directory]::GetCurrentDirectory())
$projectName= $dirInfo.Name;

NugetBuildSingle $projectName