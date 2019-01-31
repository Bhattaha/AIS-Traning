param(
[Parameter(Mandatory = $true, Position = 0)]
[int]$number1,
[Parameter(Mandatory = $true, Position = 1)]
[int]$number2
 
)

function Division
{

#Try- Catch Block
try
{
    #input variables
    #[int]$number1 = Read-Host 'Enter the first number'
    #[int]$number2 = Read-Host 'Enter second number'
    #resulting number
    $result = $number1 / $number2
    [Math]::Floor($result)
    #print result
    Write-Host 'The result is ' $result
}
catch
{
    #details of error
    Write-Error $_
}
}
 Division