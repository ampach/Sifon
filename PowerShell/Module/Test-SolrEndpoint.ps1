function Test-SolrEndpoint($Url)
{
    Try { add-type @"
        using System.Net;
        using System.Net.Security;
        using System.Security.Cryptography.X509Certificates;

        public static class CustomCertificateValidationCallback {
            public static void Install() 
            {
                ServicePointManager.ServerCertificateValidationCallback += CustomCertificateValidationCallback.CheckValidationResult;
            }
            public static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
            {
                return true;
            }
        }
"@
    } Catch { }
    [CustomCertificateValidationCallback]::Install()

    $RestError = $null
    [System.Uri]$Url = "$Url/admin/info/system?wt=json"
    $list = New-Object 'System.Collections.Generic.List[String[]]'  

    Try {
        $response = Invoke-RestMethod -Uri $Url -Method Get -ErrorVariable RestError -ErrorAction SilentlyContinue -TimeoutSec 5
    } Catch {
        $RestError = $_
    }

    if ($RestError)
    {
        $HttpStatusCode = $RestError.ErrorRecord.Exception.Response.StatusCode.value__
        $HttpStatusDescription = $RestError.ErrorRecord.Exception.Response.StatusDescription
    }
    else {

        $path = $response.solr_home
        $version = $response.lucene | Select-Object -Property solr-spec-version 
        
        [string[]]$arr = $Url.Port,$version,$path
        $list.Add($arr)

        return $list 
    }    
}
