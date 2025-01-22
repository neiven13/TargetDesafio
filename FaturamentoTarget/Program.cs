using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

string pathJson = @"C:\Users\aurus.soares\Documents\CSharp\FaturamentoTarget\dados.json";
;

try
{
    // Lendo o JSON do arquivo
    string json = File.ReadAllText(pathJson);

    var dados = JsonSerializer.Deserialize<List<Dictionary<string, JsonElement>>>(json);

    if (dados != null)
    {
        var faturamentos = dados.Where(item => item["valor"].GetDouble() > 0).Select(item => item["valor"].GetDouble()).ToList();

        if (faturamentos.Count > 0)
        {
            double menorValor = faturamentos.Min();
            double maiorValor = faturamentos.Max();
            double media = faturamentos.Average();

            int diasAcimaMedia = faturamentos.Count(valorDia => valorDia > media);

            Console.WriteLine($"Menor valor: {menorValor}\nMaior valor: {maiorValor}\nQuantidade de dias acima da média: {diasAcimaMedia}");
        }
        else
        {
            Console.WriteLine("Sem faturamentos válidos no JSON");
        }
    }
    else
    {
        Console.WriteLine("O JSON é inválido ou está vazio.");
    }
}
catch (Exception e)
{
    Console.WriteLine($"Erro ao processar o arquivo JSON: {e.Message}");
}
