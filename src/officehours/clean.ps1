Set-Location $PSScriptRoot
Write-Host Remove Videos and Slides
Get-ChildItem * -Include *.mp4 -Recurse | Remove-Item
Get-ChildItem * -Include *.PNG -Recurse | Remove-Item
Write-Host Remove PPTX
Get-ChildItem * -Include *.pptx -Recurse | Remove-Item
Write-Host Remove Captions
Get-ChildItem * -Include *.srt -Recurse | Remove-Item
Get-ChildItem * -Include *.vtt -Recurse | Remove-Item
Write-Host Remove Projects
Get-ChildItem * -Include *.clipchamp -Recurse | Remove-Item
Write-Host Remove Times
Get-ChildItem * -Include times.txt -Recurse | Remove-Item
Pop-Location