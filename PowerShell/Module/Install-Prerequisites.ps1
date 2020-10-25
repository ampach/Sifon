function Install-Prerequisites
{
    function Is-ChocoInstalled
    {
        try {
                choco -v
                return $true
        }
        catch {
            return $false
        }
    }

    function Install-Chocolatey 
    {    
        #[CmdletBinding(SupportsShouldProcess = $True)]
        param ()
        if (!(Is-ChocoInstalled))
        {
            try {
                iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1')) | Out-Null
                
                if (Is-ChocoInstalled)
                {
                    choco feature enable -n=allowGlobalConfirmation  | Out-Null
                    return $true
                }
            }
            catch {
                $_.Exception.Message
            }
        }
        else {
            return $true
        }
        return $false;
    }

    function Install-Git
    {
        choco install git.install -version 1.9.5.20150114 --force  | Out-Null
        return $true
    }

    $activity = "Installing prerequisites"

    Write-Progress -Activity "Installing Chocolatey" -Status $activity -PercentComplete 3;
    $Choco = Install-Chocolatey

    Write-Progress -Activity "Installing Git" -Status $activity -PercentComplete 62;
    $Git = Install-Git

    Write-Progress -Activity "Done" -Status $activity -PercentComplete 100;

    return [System.Tuple]::Create($Choco, $Git)
}