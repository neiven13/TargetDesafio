using System;

class InversorString
{
    static void Main()
    {
        string textoInicial = "String a ser invertida";
        string textoInvertido = "";

        for (int i = textoInicial.Length - 1; i >= 0; i--)
        {
            textoInvertido += textoInicial[i];
        }

        Console.WriteLine($"Original: {textoInicial}\nInvertido: {textoInvertido}");
    }
}
