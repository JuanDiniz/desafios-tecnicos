
// Desafio 3 - Análise de faturamento diário
using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;

class Desafio3
{
    public class FaturamentoDiario
    {
        public string dia { get; set; }
        public double valor { get; set; }
    }

    static void Main()
    {
        string json = File.ReadAllText("faturamento.json");
        List<FaturamentoDiario> faturamento = JsonSerializer.Deserialize<List<FaturamentoDiario>>(json);

        var diasComValor = faturamento.Where(d => d.valor > 0).ToList();

        double menor = diasComValor.Min(d => d.valor);
        double maior = diasComValor.Max(d => d.valor);
        double media = diasComValor.Average(d => d.valor);
        int diasAcimaDaMedia = diasComValor.Count(d => d.valor > media);

        Console.WriteLine($"Menor valor de faturamento: R$ {menor:F2}");
        Console.WriteLine($"Maior valor de faturamento: R$ {maior:F2}");
        Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaDaMedia}");
    }
}
