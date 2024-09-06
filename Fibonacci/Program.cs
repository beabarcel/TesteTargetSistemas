using System;

class Program
{
    static bool EhFibonacci(int num)
    {
        int a = 0, b = 1, c = 0;
        while (c < num)
        {
            c = a + b;
            a = b;
            b = c;
        }
        return num == c || num == 0;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero: ");
        int num = int.Parse(Console.ReadLine());

        if (EhFibonacci(num))
        {
            Console.WriteLine($"O numero {num} pertence a sequencia de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O numero {num} nno pertence a sequência de Fibonacci.");
        }
    }

}
