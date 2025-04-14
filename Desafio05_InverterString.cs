using System;

class Program
{
    static void Main()
    {
        // Definindo uma string
        string input = "Exemplo de string";
        
        // Chama a função para inverter a string
        string reversed = InverterString(input);
        
        // Exibe o resultado
        Console.WriteLine("String original: " + input);
        Console.WriteLine("String invertida: " + reversed);
    }

    static string InverterString(string str)
    {
        // Converte a string para um array de caracteres
        char[] caracteres = str.ToCharArray();
        
        // Declara um array para armazenar a string invertida
        char[] invertida = new char[caracteres.Length];
        
        // Inverte a string manualmente
        int j = 0;
        for (int i = caracteres.Length - 1; i >= 0; i--)
        {
            invertida[j] = caracteres[i];
            j++;
        }
        
        // Retorna a string invertida
        return new string(invertida);
    }
}
