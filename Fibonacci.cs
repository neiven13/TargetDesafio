using System;
public class Fibonacci
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe um número:");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            if (PertenceFibonacci(numero))
            {
                Console.WriteLine($"O número {numero} pertence à sequência");
            }
            else
                Console.WriteLine($"O número {numero} não pertence à sequência");
        }
        else
        {
            Console.WriteLine("Insira um número válido.");
        }
    }

    static bool PertenceFibonacci(int numero)
    {
        if (numero < 0) return false;
        int anterior = 0;
        int proximo = 1;

        while (anterior <= numero)
        {
            if (anterior == numero) return true;

            int temporario = anterior;
            anterior = proximo;
            proximo += temporario;
        }

        return false;
    }
}


