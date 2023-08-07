using System;
using System.Linq;

namespace StringManipulation
{
    public static class StringProcessor
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the String Manipulation with C#");
            Console.WriteLine("Please input a word, and I'll let you know how many vowels it has, how many consonants, how it looks in uppercase and lowercase; plus what it is in reverse.");

            string input = Console.ReadLine();

            // Reversing the string
            string reversed = new string(input.Reverse().ToArray());

            // Counting vowels and consonants
            int vowels = input.Count(c => "AEIOUaeiou".Contains(c));
            int consonants = input.Length - vowels;

            // Converting to uppercase and lowercase
            string upper = input.ToUpper();
            string lower = input.ToLower();

            Console.WriteLine($"Reversed: {reversed}");
            Console.WriteLine($"Vowels: {vowels}, Consonants: {consonants}");
            Console.WriteLine($"Uppercase: {upper}");
            Console.WriteLine($"Lowercase: {lower}");
        }
    }
}

