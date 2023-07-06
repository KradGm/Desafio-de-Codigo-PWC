using System;
using System.Collections.Generic;

class Program
{
    static string ReverseString(string input)
    {
        char[] characters = input.ToCharArray();
        Array.Reverse(characters);
        return new string(characters);
    }

    static void Main(string[] args)
    {
        string normalString = "racecar";
        string reversedString = ReverseString(normalString);
        Console.WriteLine("Frase invertida: " + reversedString);

        Console.WriteLine(verifyPalindrome(normalString, reversedString));


        Console.WriteLine("Digite uma frase:");
        string input = Console.ReadLine();
        string reversedInput = ReverseString(input);
        Console.WriteLine("Frase invertida: " + reversedInput);
        Console.WriteLine(verifyPalindrome(input, reversedInput));
    }
    static bool verifyPalindrome(string input, string reversedInput)
    {
        bool result = false;
        if (input.Replace(" ", "").ToLower() == reversedInput.Replace(" ", "").ToLower())
        {
            result = true;

        }
        else
        {
            result = false;
        }
        return result;
    }

}