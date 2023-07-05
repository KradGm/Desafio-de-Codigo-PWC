using System.Globalization;
using System.Text.RegularExpressions;

//DESAFIO 4 (in english)
class Program
{
    static void Main(String[] args)
    {
        string phrase = "hello. how are you? i'm fine, thank you";
        Console.WriteLine("Esta é a frase inicial: " + phrase);
        string result = TransformFirstLetter(phrase);

        Console.WriteLine("Digite qual sera a frase adicional a ser transformada: ");
        string phrase2 = Console.ReadLine();
        string result2 = TransformFirstLetter(phrase2);
        Console.WriteLine("Frase transformada: "+result2);
        Console.WriteLine("Frase transformada: "+result);
    }
    static string TransformFirstLetter(string phrase)
    {
        TextInfo textInformation = CultureInfo.CurrentCulture.TextInfo;
        string[] sentences = Regex.Split(phrase, "(?<=[.!?])"); ;

        for (int i = 0; i < sentences.Length; i++)
        {
            string sentence = sentences[i].Trim();
            if (!string.IsNullOrEmpty(sentence))
            {
                char firstChar = sentence[0];
                string transformedSentence = textInformation.ToUpper(firstChar) + sentence.Substring(1);
                sentences[i] = transformedSentence;
            }
        }
        return string.Join(" ", sentences);
    }
}