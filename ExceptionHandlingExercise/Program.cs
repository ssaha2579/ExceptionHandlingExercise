using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // Objective: Iterate through a character array. Try to parse each character into an integer.
            // If you attempt to parse a letter into an integer, an exception will occur. 
            // Use a try-catch statement to avoid a run-time exception.
            // Below we will set this up.
            // ------------------------------------------------------------------------------



            //TODO START HERE:

            // 1) Create an char[], it must contain 6 numbers and 3 letters - name it arr
            var arr = new char[] { '4', '9', '1', '2', '5', '0', 'K', 'M', 'R' }; // char array with numbers and letters

            // 2) Create a list called numbers that will hold 
            List<int> numbers = new List<int>();  // list to store successfully parsed integers

            // 3) Create an string variable with an empty string initializer - name it str
            string str = ""; // temporary string to hold char as string

            // 4) Make a foreach loop to iterate through your character array            
            // 5) Create a try-catch inide of your foreach loop
            // 6) Inside the try block: 
            // 7) Set your string variable to each array element in your char[] to .ToString()
            // 8) Now, using int.Parse, parse your string variable and store in an int variable
            // 9) Then add each int to your list

            // 10) Inside the catch block:
            // 11) In the scope of your catch you can use the following code:                  
            // Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection

            foreach (var character in arr)  // iterate through each character
            {
                try
                {
                    str = character.ToString(); // convert char to strin
                    numbers.Add(int.Parse(str)); // parse string to int and add to list
                }
                catch (FormatException e) // catch parsing errors
                {
                    Console.WriteLine($"Unable to Parse '{character}'.{e.Message}"); // display character that couldn't be parsed
                }

                catch (Exception e) // catch any other unexpected exceptions
                {
                    Console.WriteLine(e.Message); // display general exception message
                }
                
            }


            // Uncomment the code below to see the numbers you successfully added to the numbers list: 
            foreach (var num in numbers) // iterate through successfully parsed numbers
            {
               Console.WriteLine(num); // print each number
            }
        }
    }
}
