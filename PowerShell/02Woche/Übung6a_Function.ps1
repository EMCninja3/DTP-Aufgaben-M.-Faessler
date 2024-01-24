<#
Übung 6a: - Schreibe eine Funktion die ein Logfile in deinem Übungsverzeichnis schreibt.
            Als Parameter soll die Lognachricht, der Nachrichttyp(Info oder Error) mitgegeben werden.
            Die Lognachricht soll folgendes Format haben: 22.08.2023 07:16 - Info - Das ist die Lognachricht
Übung 6b: - Schreibe die Dateiennamen eures %TEMP% Verzeichnisses mit Hilfe der Funktion in das Logfile.
#>

# 6a)
function Write-Log {
    param(
        [string]$LogMessage,
        [string]$MessageType
    )

    $LogDirectory = $PSScriptRoot
    $TimeStamp = Get-Date -Format "dd.MM.yyyy HH:mm"
    $FormattedLogMessage = "{0} - {1} - {2}" -f $TimeStamp, $MessageType, $LogMessage

    # Pfad zum Logfile
    $LogFilePath = Join-Path -Path $LogDirectory -ChildPath "Logfile.txt"

    # Schreibe die Lognachricht in das Logfile
    Add-Content -Path $LogFilePath -Value $FormattedLogMessage
}

# Tests
Write-Log -LogMessage "Tu estas aqui!" -MessageType "Info"

Write-Log -LogMessage "Aqui estare" -MessageType "Error"

Write-Log -LogMessage "A donde ire sin ti" -MessageType "Info"
