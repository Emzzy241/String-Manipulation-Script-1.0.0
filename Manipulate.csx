using System;
using System.Collections.Generic;

    
    public class ManipulateString
    {
        public static void Main()
        {
            // A C# script hat takes in a string, and Mainpulates it; e.g: reverses it, returns the occurences of some letters

            Console.WriteLine("Enter the String you will like to manipuulate");

            string userString = Console.ReadLine();

            // First things first; a try...catch since I am collecting value from user

            try
            {
                char[] charArray = userString.ToCharArray();
                // Confirming if it works 
                // foreach (var character in charArray)
                // {
                //     Console.WriteLine(character);
                // }

                // After confirming it, let us now reverse it
                // Array.reverse() method returns void; all it does is to reverse string from last character to first character.
                Array.Reverse(charArray);
                string newString = new string(charArray);

                Console.WriteLine(newString);

                // After the aboveis successful, now let us start its manipulation
            }
            catch
            {
                Console.WriteLine("The error came from the value you inputted; please enter only alphabets");
                Console.WriteLine("Lets give that another try");
                Main();
            }
        }   
    }
