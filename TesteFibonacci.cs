﻿using System;

class TesteFibonacci
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            bool pertence = PertenceFibonacci(numero);
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
            Console.WriteLine("Número inválido");
        }
    }

    static bool PertenceFibonacci(int numero)
    {
        if (numero == 0){
return true;
            
        } 
        if (numero == 1){
return true;

        } 

        int a = 0, b = 1;
        while (b < numero)
        {
            int temp = a + b;
            a = b;
            b = temp;
        }
        return b == numero;
    }
}