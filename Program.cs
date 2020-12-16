using System;

namespace SomaDoisNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            // Algoritmos 2 - Leia dois numeros inteiros e escreva a soma deles
            int n1, n2, soma;

            Console.WriteLine("Escreva o primeiro numero");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o segundo numero");
            n2 = int.Parse(Console.ReadLine());

            soma = n1 + n2;

            Console.WriteLine("A soma de {0} e o {1} tem como resultado {2}", n1, n2, soma);
        }
    }
}
