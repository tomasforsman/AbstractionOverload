# Set the path to the directory containing the .cs files
$directoryPath = ".\"

# Set the output file path
$outputFilePath = ".\allcode.cs.txt"

# Collect all .cs file contents and output to a single file
Get-ChildItem -Path $directoryPath -Filter *.cs -Recurse | 
    Get-Content | 
    Out-File -FilePath $outputFilePath

Write-Host "All .cs files have been concatenated into $outputFilePath"
