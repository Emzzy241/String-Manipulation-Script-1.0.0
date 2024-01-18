using System;
using System.Collections.Generic;
using System.Linq;

    
    public class Program
    {
        public static void Main()
        {
            // A C# script hat takes in a string, and Mainpulates it; e.g: reverses it, returns the occurences of some letters

            Console.WriteLine("Enter the String you will like to manipuulate");

            string userString = Console.ReadLine();

            // First things first; a try...catch since I am collecting value from user

            try
            {

                // char counter
                static int CharCounter(string word)
                {
                    char[] myCharArray = word.ToCharArray();

                    if(word.Length == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("There are 0 characters in the word inputted");
                        return 0;
                    }
                    else
                    {
                        int charCount = 0;
                        foreach (char item in myCharArray)
                        {
                            charCount++;
                        }
                        return charCount;

                    }
                } 

                // Method to find top three characters
                static Dictionary<char, int> GetTopCharacters(string input, int count)
                {
                    var frequency = input
                        .Where(char.IsLetterOrDigit)
                        .GroupBy(c => c)
                        .ToDictionary(group => group.Key, group => group.Count());

                    return frequency.OrderByDescending(pair => pair.Value)
                                    .Take(count)
                                    .ToDictionary(pair => pair.Key, pair => pair.Value);
                }

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

                Console.WriteLine($"The reversed version is: {newString}");
                Console.WriteLine();
                Console.WriteLine();
                int noOfCharactersInword = CharCounter(newString);
                Console.WriteLine($"And the no of characters in word is {noOfCharactersInword}");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("And the top three characters that appeared in word are: ");
                
                Dictionary<char, int> topCharacters = GetTopCharacters(userString, 3);

                foreach (var kvp in topCharacters)
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value} occurrences");
                }

                


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
