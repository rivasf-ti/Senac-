using System;

class Program {
  public static void Main (string[] args) {

    int Num;
    int V1 = 0;
    int V2 = 1;
    int V3;
    int i;
    
    Console.Write("Digite um número: ");
    Num = int.Parse(Console.ReadLine());
    Console.Write(V1 + " ");
    Console.Write(V2 + " ");
    
    for(i = 2; i < Num; i++){
      V3 = V1 + V2;
      Console.Write(" " + V3);
      V1 = V2;
      V2 = V3;
      
    }
  }
}