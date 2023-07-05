// See https://aka.ms/new-console-template for more information
//DESAFIO 1:
string texto1 = "Hello, World! OpenAi is amazing.";
Console.WriteLine("Esse é o texto que sera invertido: " + texto1);

string[] texto1Array = texto1.Split(" ");

Console.WriteLine(texto1Array[4] + " " + texto1Array[3] + " " + texto1Array[2] + " " + texto1Array[1] + " " + texto1Array[0]);

//DESAFIO 2:
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
Console.WriteLine(resultado);

