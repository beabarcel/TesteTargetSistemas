using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma palavra para inverter:");
        string palavra = Console.ReadLine();

        string palavraInvertida = InverterString(palavra);

        Console.WriteLine($"{palavra}: {palavraInvertida}");
    }

    static string InverterString(string str)
    {
        char[] letras = str.ToCharArray();

        int inicio = 0;
        int fim = letras.Length - 1;

        while (inicio < fim)
        {
            char temp = letras[inicio];
            letras[inicio] = letras[fim];
            letras[fim] = temp;

            inicio++;
            fim--;
        }

        return new string(letras);
    }
}
