function Install-Solr
(
	[string]$Version = "8.4.0",
	[string]$Folder = "c:\solr",
	[string]$Port = "8840",
	[string]$Hostname = "localhost",
	[bool]$Uninstall = $false
)
{
	[bool]$folderExists = Test-Path ($Folder + '\solr-' + $Version)

	if($folderExists)
	{
		if($false -eq $Uninstall){
			return $false
		}
	}

	if(!($folderExists))
	{
		if($true -eq $Uninstall){
			return $false
		}
	}

	$moduleName = 'SharedInstallationUtilities'
	Install-ModuleFromGithub -ModuleName $moduleName -UriBase "https://raw.githubusercontent.com/Sitecore/Sitecore.HabitatHome.Utilities/master/Shared/assets/modules/SharedInstallationUtilities/SharedInstallationUtilities.psm1"
	Import-Module -Name $moduleName
	
	$sif = Get-Module -ListAvailable -Name 'SitecoreInstallFramework'
	if ($sif)
	{
		Import-SitecoreInstallFramework -version $sif.Version -repositoryName "SitecoreGallery" -repositoryUrl "https://sitecore.myget.org/F/sc-powershell/api/v2/"    

 		$jsonName = $MyInvocation.MyCommand.Name + '.json'
				
		Invoke-RestMethod 'https://raw.githubusercontent.com/Sitecore/Sitecore.HabitatHome.Utilities/master/XP/install/assets/configuration/XP0/Solr-SingleDeveloper.json' -OutFile $jsonName

		$solrInstallConfigurationPath = Resolve-Path $jsonName

		$params = @{
			SolrVersion       = $Version
			SolrDomain        = $Hostname
			SolrPort          = $Port
			SolrInstallRoot   = $Folder
			SolrServicePrefix = ""
		}

		if ($Uninstall){
			Install-SitecoreConfiguration -Path $solrInstallConfigurationPath @params -Uninstall
		}
		else {
			Install-SitecoreConfiguration -Path $solrInstallConfigurationPath @params
		}

		Remove-Item  $jsonName -Force
		
		Remove-Item -LiteralPath "c:\Program Files\WindowsPowerShell\Modules\$moduleName" -Force -Recurse
		return $true
	}
	else
	{
		return $false
	}
}
