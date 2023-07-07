
using System.Globalization;
using System.Text.RegularExpressions;

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
       
        bool saida=false;

    while(!saida){

            Console.WriteLine("Qual o desafio que você quer verificar, digite o numero correspondente: ");
            Console.WriteLine("1 - Invertendo a ordem de uma frase");
            Console.WriteLine("2 - Retirando caracteres repetidos");
            Console.WriteLine("3 - Encontrando partes palindromas em uma frase");
            Console.WriteLine("4 - Formatando a letra inicial das frases");
            Console.WriteLine("5 - Encontrando os anagramas palindromos em uma frase");
            Console.WriteLine("6 - Sair do programa");
            string caso = Console.ReadLine();
            Console.WriteLine(" ");

            switch (caso)
            {
                case "1":
                    Console.WriteLine("Desafio 1: Invertendo a ordem de uma frase");
                    string texto1 = "Hello, World! OpenAi is amazing.";
                    Console.WriteLine("Esse é o texto que sera invertido: " + texto1);

                    string[] texto1Array = texto1.Split(" ");

                    Console.WriteLine("Esse é o texto invertido: " + texto1Array[4] + " " + texto1Array[3] + " " + texto1Array[2] + " " + texto1Array[1] + " " + texto1Array[0]);
                    Console.WriteLine(" ");
                    break;
                case "2":
                    Console.WriteLine("Desafio 2: Retirando caracteres repetidos");
                    string textoDuplicado = "Hello, World!";
                    string resultado;
                    char[] chars = textoDuplicado.ToCharArray();
                    List<char> charList = new List<char>();

                    for (int i = 0; i < chars.Length; i++)
                    {
                        if (!charList.Contains(chars[i]))
                        {
                            charList.Add(chars[i]);
                        }
                    }

                    resultado = string.Join("", charList);
                    Console.WriteLine("Texto original: " + textoDuplicado);
                    Console.WriteLine("Texto apos retirar as letras repetidas: " + resultado);
                    Console.WriteLine(" ");
                    break;
                case "3":
                    Console.WriteLine("Desafio 3: Encontrando partes palindromas em uma frase");
                    string fraseTeste = "babad";
                    var palindromo2 = EncontrarPalindromos(fraseTeste);
                    Console.WriteLine("Palíndromos encontrados na palavra babad: ");
                    string resultadoPalindromo = Palindromos(palindromo2);

                    Console.WriteLine("Digite qual sera a palavra a ser verificada: ");
                    string fraseAlvo = Console.ReadLine();
                    var palindromos = EncontrarPalindromos(fraseAlvo);

                    Console.WriteLine("Palíndromos encontrados na sua frase de escolha: ");
                    string resultado2 = Palindromos(palindromos);
                    Console.WriteLine(" ");
                    break;
                case "4":
                    Console.WriteLine("Desafio 4: Formatando a letra inicial das frases");
                    string phrase = "hello. how are you? i'm fine, thank you";
                    Console.WriteLine("Esta é a frase inicial: " + phrase);
                    string result = TransformFirstLetter(phrase);

                    Console.WriteLine("Digite qual sera a frase adicional a ser transformada: ");
                    string phrase2 = Console.ReadLine();
                    string result2 = TransformFirstLetter(phrase2);
                    Console.WriteLine("Frase transformada: " + result2);
                    Console.WriteLine("Frase transformada: " + result);
                    Console.WriteLine(" ");
                    break;
                case "5":
                    Console.WriteLine("Desafio 5: Encontrando os anagramas palindromos em uma frase");
                    string normalString = "racecar";//roma me tem amor, mega bobagem são boas frases de teste.
                    string reversedString = ReverseString(normalString);
                    Console.WriteLine("Frase invertida: " + reversedString);

                    Console.WriteLine(verifyPalindrome(normalString, reversedString));


                    Console.WriteLine("Digite uma frase:");
                    string input = Console.ReadLine();
                    string reversedInput = ReverseString(input);
                    Console.WriteLine("Frase invertida: " + reversedInput);
                    Console.WriteLine(verifyPalindrome(input, reversedInput));
                    Console.WriteLine(" ");
                    break;
                case "6":
                    saida = true;
                    break;
                default:
                    Console.WriteLine("Parece que a opção digitada não existe, por favor, tente utilizar apenas teclas unicas que sejam de 1 ate 6.");
                    break;
            }
        }
    }

    static string Palindromos(string[] palindromos)
    {
        foreach (var palindromo in palindromos)
        {
            if (palindromo.Count() > 1)
            {
                Console.WriteLine(palindromo);
            }
        }
        return null;
    }
    static bool EhPalindromo(string palavras)
    {
        int inicio = 0;
        int fim = palavras.Length - 1;

        while (inicio < fim)
        {
            if (palavras[inicio] != palavras[fim])
            {
                return false;
            }

            inicio++;
            fim--;
        }

        return true;
    }

    static string[] EncontrarPalindromos(string frase)
    {
        var palindromos = new List<string>();

        for (int i = 0; i < frase.Length; i++)
        {
            for (int j = i + 1; j <= frase.Length; j++)
            {
                string subString = frase[i..j];

                if (EhPalindromo(subString))
                {
                    palindromos.Add(subString);
                }
            }
        }

        return palindromos.ToArray();
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