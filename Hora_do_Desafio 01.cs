using System;

class Program {
static void Main() {

  double rendimento = 12;
  double tempo = double.Parse(Console.ReadLine());
  double velocidade = double.Parse(Console.ReadLine());
  double consumoCombustivel = (tempo*velocidade)/rendimento;
  
  consumoCombustivel = Math.Round(consumoCombustivel, 3);
  Console.WriteLine(consumoCombustivel);


   }
   
    }

  
