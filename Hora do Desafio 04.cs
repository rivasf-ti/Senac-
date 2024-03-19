using System;

class Program {
  public static void Main (string[] args) {

    int[] X = new int[10];
    
    for (int i = 0; i < 10; i++)
    {
        Console.Write("Digite um valor para o vetor X[] : ");
        int Valor = int.Parse(Console.ReadLine());
        X[i] = Valor;
    }

    for (int i = 0; i < 10; i++)
    {
        if (X[i] <= 0)
        {
            X[i] = 1;
        }
    }
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"X[{i}] = {X[i]}");
    }
   
  }
}

