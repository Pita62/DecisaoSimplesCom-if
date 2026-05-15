// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // 1. Recebe a nota da prova 1
        Console.Write("Digite a nota da prova 1: ");
        double nota1 = double.Parse(Console.ReadLine());

        // 2. Recebe a nota da prova 2
        Console.Write("Digite a nota da prova 2: ");
        double nota2 = double.Parse(Console.ReadLine());

        // 3. Calcule a média das notas
        double media = (nota1 + nota2) / 2;

        // Exibe a média calculada
        Console.WriteLine($"Média do aluno: {media}");

        // 4. Verifica se foi aprovado ou reprovado
        if (media < 5)
        {
            Console.WriteLine("O aluno foi reprovado.");
        }
        else
        {
            Console.WriteLine("O aluno foi aprovado.");
        }
    }
}
