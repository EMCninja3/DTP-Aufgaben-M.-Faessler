
function Write-NumberFile {
    param(
        [string]$MessageText
    )

    $LogDirectory = $PSScriptRoot
    #$TimeStamp = Get-Date -Format "dd.MM.yyyy HH:mm"
    $FormattedLogMessage = "This is Line {0}." -f $MessageText

    # Pfad zum Logfile
    $LogFilePath = Join-Path -Path $LogDirectory -ChildPath "LineNumbers.txt"

    # Schreibe die Lognachricht in das Logfile
    Add-Content -Path $LogFilePath -Value $FormattedLogMessage
}

for (($i = 1); $i -lt 101; $i++)
{
     Write-NumberFile $i
}