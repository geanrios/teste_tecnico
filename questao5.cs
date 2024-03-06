using System;

class Programa
{
    static string InverterString(string input)
    {
        char[] caracteres = input.ToCharArray();
        int tamanho = caracteres.Length;

        for (int i = 0; i < tamanho / 2; i++)
        {
            // Trocar os caracteres simetricamente em relação ao centro
            char temp = caracteres[i];
            caracteres[i] = caracteres[tamanho - i - 1];
            caracteres[tamanho - i - 1] = temp;
        }

        return new string(caracteres);
    }

    static void Main()
    {
        Console.Write("Digite uma string: ");
        string entrada = Console.ReadLine();

        string resultado = InverterString(entrada);

        Console.WriteLine($"String original: {entrada}");
        Console.WriteLine($"String invertida: {resultado}");
    }
}