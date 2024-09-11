using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário um número
        Console.Write("Digite um número para verificar se pertence à sequência de Fibonacci: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            // Verifica se o número pertence à sequência de Fibonacci
            bool pertence = PertenceFibonacci(numero);
            
            // Exibe o resultado
            if (pertence)
            {
                Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
        }
    }

    static bool PertenceFibonacci(int numero)
    {
        // Casos base
        if (numero == 0) return true;
        if (numero == 1) return true;

        // Inicializa os primeiros dois números da sequência de Fibonacci
        int a = 0, b = 1;

        // Gera a sequência de Fibonacci até encontrar ou exceder o número
        while (b < numero)
        {
            int temp = a + b;
            a = b;
            b = temp;
        }

        // Verifica se o número é igual ao último número calculado na sequência
        return b == numero;
    }
}
