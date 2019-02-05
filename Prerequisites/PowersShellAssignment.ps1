param(
[Parameter(Mandatory = $true, Position = 0)]
[int]$number1,
[Parameter(Mandatory = $true, Position = 1)]
[int]$number2
 
)

# ask for the operation

function Division
{

#Try- Catch Block
try
{
   
    #resulting number
    [int]$result = ($number1 / $number2)
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
function Subtraction
{

#Try- Catch Block
try
{
   
    #resulting number
    [int] $result =  ($number1 - $number2)
   
    #print result
    Write-Host 'The result is ' $result
}
catch
{
    #details of error
    Write-Error $_
}
}
function Multiplication
{

#Try- Catch Block
try
{
   
    #resulting number
    [int]$result = ($number1 * $number2)
    
    #print result
    Write-Host 'The result is ' $result
}
catch
{
    #details of error
    Write-Error $_
}
}
function Addition
{

#Try- Catch Block
try
{
   
    #resulting number
   [int] $result = ($number1 + $number2)
    
    Write-Host 'The result is ' $result
}
catch
{
    #details of error
    Write-Error $_
}
} 
$condation = Read-host 'Enter 1 for division, 2 for multiplication, 3 for subtraction, 4 for addition'
switch($condation)
{
 1
  {Division}
 2
 {Subtraction}
 3
 {Multiplication}
 4
 {Addition}
} 
 Division