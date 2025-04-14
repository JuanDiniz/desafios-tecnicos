// Desafio 1 - Soma com laço WHILE
using System;

class Desafio1
{
    static void Main()
    {
        int INDICE = 13, SOMA = 0, K = 0;

        while (K < INDICE)
        {
            K = K + 1;
            SOMA = SOMA + K;
        }

        Console.WriteLine("Valor final da variável SOMA: " + SOMA);
    }
}
