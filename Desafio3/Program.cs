//DESAFIO 3:

class Program
{
    static void Main(string[] args)
    {
        string fraseAlvo = "babad";
        var palindromos = EncontrarPalindromos(fraseAlvo);

        Console.WriteLine("Palíndromos encontrados:");
        foreach (var palindromo in palindromos)
        {
            if (palindromo.Count() > 1)
            {
                Console.WriteLine(palindromo);
            }
        }
    }

    static bool EhPalindromo(string palavra)
    {
        int inicio = 0;
        int fim = palavra.Length - 1;

        while (inicio < fim)
        {
            if (palavra[inicio] != palavra[fim])
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
                string subString = frase.Substring(i, j - i);

                if (EhPalindromo(subString))
                {
                    palindromos.Add(subString);
                }
            }
        }

        return palindromos.ToArray();
    }
}