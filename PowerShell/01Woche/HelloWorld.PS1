Write-Output "Hello There!"

$fruits = "Apple", "Pear", "Banana", "Orange"

$fruits += "Kivi", "Melon", "Raspberry", "Cocos"

$fruits

$process = Get-Process

for (($i = 0); $i -lt 3; $i++)
{
    "`$process:$i"+"$process[$i]"
}

$dateiNamen = Get-FileStorageTier
for (($i = 0); $i -lt 3; $i++)
{
    "`$process:$i"+"$dateiNamen[$i]"
}