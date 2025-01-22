using System;

class Faturamento
{
    static void Main(string[] args)
    {
        var faturamentoMensalEstado = new Dictionary<string, double>
            {
                {"SP",67836.43},
                {"RJ",36678.66},
                {"MG",29229.88},
                {"ES",27165.48},
                {"Outros",19849.53}
            };

        double faturamentoTotal = faturamentoMensalEstado.Values.Sum();

        foreach (var estado in faturamentoMensalEstado)
        {
            double porcentagem = (estado.Value / faturamentoTotal) * 100;
            Console.WriteLine($"{estado.Key} teve {porcentagem:F2} de representação no valor total do faturamento.");
        }
    }
}

