using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = new int[12, 12];
        Random random = new Random();

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                matriz[i, j] = random.Next(101);
            }
        }

        Console.WriteLine("Matriz 12x12 com números aleatórios:");
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Digite o número da linha (0 a 11):");
        int linha = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a operação a ser realizada (S para soma, M para média):");
        char operacao = Convert.ToChar(Console.ReadLine());

        int soma = 0;

        for (int j = 0; j < 12; j++)
        {
            soma += matriz[linha, j];
        }

        double media = (double)soma / 12;

        if (operacao == 'S')
        {
            Console.WriteLine($"A soma dos elementos da linha {linha} é: {soma}");
        }
        else if (operacao == 'M')
        {
            Console.WriteLine($"A média dos elementos da linha {linha} é: {media:F1}");
        }
        else
        {
            Console.WriteLine("Operação inválida!");
        }
    }
}