param(
    [Parameter(Mandatory = $false, Position = 0)]
    [string] $buildConfig
)

$VerbosePreference = 'Continue'

if ([string]::IsNullOrEmpty($buildConfig))
{
	Write-Verbose "Setting build configuration to 'Release'"
	$buildConfig = 'Release'
}

Write-Verbose "Build configuration is set to $buildConfig"

$output = Join-Path $env:AzurePSRoot "src\Package\$buildConfig"
Write-Verbose "The output folder is set to $output"
$serviceManagementPath = Join-Path $output "ServiceManagement\Azure"
$resourceManagerPath = Join-Path $output "ResourceManager\AzureResourceManager"

Write-Verbose "Removing duplicated Resources folder"
Remove-Item -Recurse -Force $serviceManagementPath\Compute\Resources\ -ErrorAction SilentlyContinue
Remove-Item -Recurse -Force $serviceManagementPath\Sql\Resources\ -ErrorAction SilentlyContinue
Remove-Item -Recurse -Force $serviceManagementPath\Storage\Resources\ -ErrorAction SilentlyContinue
Remove-Item -Recurse -Force $serviceManagementPath\ManagedCache\Resources\ -ErrorAction SilentlyContinue

Write-Verbose "Removing generated NuGet folders from $output"
$resourcesFolders = @("de", "es", "fr", "it", "ja", "ko", "ru", "zh-Hans", "zh-Hant")
Get-ChildItem -Include $resourcesFolders -Recurse -Force -Path $output | Remove-Item -Force -Recurse -ErrorAction SilentlyContinue

Write-Verbose "Removing XML help files for helper dlls from $output"
$exclude = @("*.dll-Help.xml", "Scaffold.xml", "RoleSettings.xml", "WebRole.xml", "WorkerRole.xml")
$include = @("*.xml", "*.lastcodeanalysissucceeded", "*.dll.config", "*.pdb")
Get-ChildItem -Include $include -Exclude $exclude -Recurse -Path $output | Remove-Item -Force -Recurse

if (Get-Command "heat.exe" -ErrorAction SilentlyContinue)
{
	$azureFiles = Join-Path $env:AzurePSRoot 'setup\azurecmdfiles.wxi'
    heat dir $output -srd -sfrag -sreg -ag -g1 -cg azurecmdfiles -dr PowerShellFolder -var var.sourceDir -o $azureFiles
    
	# Replace <Wix> with <Include>
	(gc $azureFiles).replace('<Wix', '<Include') | Set-Content $azureFiles
	(gc $azureFiles).replace('</Wix' ,'</Include') | Set-Content $azureFiles
}
else
{
    Write-Error "Failed to execute heat.exe, the Wix bin folder is not in PATH"
}