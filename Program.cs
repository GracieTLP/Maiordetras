// Programa: MaiordeTrês
// Objetivo: Ler três números e mostrar qual é o maior

using System;

class MaiordeTrês
{
    static void Main()
    {
        Console.WriteLine("=== Descobrindo o Maior Número ===\n");

        Console.Write("Informe o 1º valor: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Informe o 2º valor: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Informe o 3º valor: ");
        int numero3 = Convert.ToInt32(Console.ReadLine());

        int maior;

        if (numero1 > numero2)
        {
            if (numero1 > numero3)
            {
                maior = numero1;
            }
            else
            {
                maior = numero3;
            }
        }
        else
        {
            if (numero2 > numero3)
            {
                maior = numero2;
            }
            else
            {
                maior = numero3;
            }
        }

        Console.WriteLine($"\nO maior valor digitado foi: {maior}");
    }
}

