# String Manipulation in C Sharp

Welcome, and thank you for viewing my String Manipulator program in C#.

## Brief: 

A C# program that takes a string input from the user and performs various string manipulation tasks, such as reversing the string, counting the number of vowels and consonants, and converting the string to uppercase and lowercase. 

## Solution explained:

Namespace and Class Naming: the StringManipulation namespace is used to group the code, and the StringProcessor class indicates its purpose of processing strings.

Console.WriteLine: this method is used to print messages to the console.

Console.ReadLine: this method reads a line of input from the console. The return type is string.

String Reversal: the Reverse method from LINQ to reverse the string. Since the Reverse method returns an IEnumerable<char>, it converts it back to a string with the string constructor.

Counting Vowels and Consonants: the Count method from LINQ to count the number of characters in the string that match the given condition. For vowels, it checks if the character is in the string "AEIOUaeiou".

Uppercase and Lowercase: the ToUpper and ToLower methods of a string return the string converted to uppercase and lowercase, respectively.

### Note: 
The solution was created in Visual Studio IDE 2022 by Microsoft (Free) with C# V.7.0.



