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
        Console.WriteLine("Digite uma frase:");
        string input = Console.ReadLine();

        string reversedString = ReverseString(input);
        Console.WriteLine("Frase invertida: " + reversedString);

        if (input.Replace(" ", "").ToLower() == reversedString.Replace(" ", "").ToLower())
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }

}