#powershell exercise for Variable Declaration, Conditional Statements, Looping

#Variable declarations:
$input = "TiT for TaT"

# Hold words in array
$words = $input.Split()
 
# stores the legth of the array
$count =$words.Length
 
#Try- Catch Block
try
{
    #defining a loop 
    for ($i = 0; $i -lt $count; $i++)
    {
        # Store each character of a word in an array    
        $charArray = $words[$i].ToCharArray()
    
        # Reverse the characters of a word in the array
        [array]::reverse($charArray)
    
        # Take each character in the charArray and join it to create word 
        $reversedWord = -join($charArray)
   
        # Using conditional statement to  compare the reversed word with the original word
        if($reversedWord -eq $words[$i])
        {
            write-host $words[$i] is palindrome!
        }
        else
        {
            write-host $words[$i] is not a palindrome!
        }

        # Intentional code to show try-catch block
        #$raiseError = 10/$i
    }

}
catch
{
    Write-Error $_
}