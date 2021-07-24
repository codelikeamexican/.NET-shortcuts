using System;
using System.Text.RegularExpressions;

public class Test
{

    public static void Main ()
    {

        // Define a regular expression for repeated words.
        Regex rx = new Regex(@"\b(?<word>\w+)\s+(\k<word>)\b", RegexOptions.IgnoreCase);
        Regex rx = new Regex(@"\b(?<word>\w+)\s+(\k<word>)\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);
          
    }
}
// The second sentence example  will compile the code on the fly 
// Optimizing your code! <3 
