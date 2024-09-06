using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class Program
{
    public class Faturamento
    {
        public int Dia { get; set; }
        public double Valor { get; set; }
    }

    static void Main()
    {
        string filePath = "dados.json";

        var jsonData = File.ReadAllText(filePath);

        var faturamentoList = JsonConvert.DeserializeObject<List<Faturamento>>(jsonData);

        double[] faturamentos = new double[faturamentoList.Count];
        for (int i = 0; i < faturamentoList.Count; i++)
        {
            faturamentos[i] = faturamentoList[i].Valor;
        }

        double menorFaturamento = double.MaxValue;
        double maiorFaturamento = double.MinValue;
        double somaFaturamento = 0;
        int diasComFaturamento = 0;

        foreach (var valor in faturamentos)
        {
            if (valor > 0)
            {
                if (valor < menorFaturamento)
                    menorFaturamento = valor;

                if (valor > maiorFaturamento)
                    maiorFaturamento = valor;

                somaFaturamento += valor;
                diasComFaturamento++;
            }
        }

        double mediaMensal = somaFaturamento / diasComFaturamento;

        int diasAcimaDaMedia = 0;

        foreach (var valor in faturamentos)
        {
            if (valor > mediaMensal)
                diasAcimaDaMedia++;
        }

        Console.WriteLine($"Menor valor de faturamento: R$ {menorFaturamento.ToString("F2")}");
        Console.WriteLine($"Maior valor de faturamento: R$ {maiorFaturamento.ToString("F2")}");
        Console.WriteLine($"Numero de dias acima da media mensal: {diasAcimaDaMedia}");
    }
}
