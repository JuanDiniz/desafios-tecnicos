// Desafio 2 - Verifica se número pertence à sequência de Fibonacci
using System;

class Desafio2
{
    static void Main()
    {
        Console.Write("Informe um número: ");
        int numero = int.Parse(Console.ReadLine());

        bool pertence = VerificaFibonacci(numero);

        if (pertence)
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci.");
        }
    }

    static bool VerificaFibonacci(int numero)
    {
        int a = 0;
        int b = 1;

        while (a <= numero)
        {
            if (a == numero) return true;

            int temp = a;
            a = b;
            b = temp + b;
        }

        return false;
    }
}

