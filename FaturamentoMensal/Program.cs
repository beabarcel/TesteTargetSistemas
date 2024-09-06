using System;

class Program
{
    static void Main()
    {

        string[] estados = { "SP", "RJ", "MG", "ES", "Outros" };
        double[] faturamento = { 67836.43, 36678.66, 29229.88, 27165.48, 19849.53 };

        double totalFaturamento = 0;
        foreach (var valor in faturamento)
        {
            totalFaturamento += valor;
        }

        Console.WriteLine("Percentual mensal por estado:");
        for (int i = 0; i < estados.Length; i++)
        {
            double percentual = (faturamento[i] / totalFaturamento) * 100;
            Console.WriteLine($"{estados[i]}: {percentual.ToString("F2")}%");
        }
    }
}
