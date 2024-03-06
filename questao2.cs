using System;
class Program
{
    static bool IsFibonacci(int number)
    {
        int a = 0, b = 1;
        
        while (a <= number)
        {
            if (a == number)
            {
                return true;
            }
            
            int temp = a;
            a = b;
            b = temp + b;
        }
        
        return false;
    }

    static void Main()
    {
        try
        {
            Console.Write("Informe um número: ");
            int userInput = int.Parse(Console.ReadLine());

            if (IsFibonacci(userInput))
            {
                Console.WriteLine($"{userInput} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"{userInput} não pertence à sequência de Fibonacci.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Por favor, insira um número válido.");
        }
    }
}