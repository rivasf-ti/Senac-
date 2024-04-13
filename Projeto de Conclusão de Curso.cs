using System;


    class Program
{
    static void Main(string[] args)
    {
        string[] escolha = { "Pedra", "Papel", "Tesoura" };
        Random random = new Random();

        Console.WriteLine("Jogo de Jokenpô (Pedra-Papel-Tesoura)");
        Console.WriteLine("Escolha: Pedra, Papel ou Tesoura");
        string jogadorEscolha = Console.ReadLine();

        if (!Array.Exists(escolha, element => element.Equals(jogadorEscolha, StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine("Escolha inválida.");
            return;
        }

        int computadorEscolhaIndex = random.Next(escolha.Length);
        string computadorEscolha = escolha[computadorEscolhaIndex];

        Console.WriteLine($"O computador escolheu: {computadorEscolha}");

        if (jogadorEscolha.Equals(computadorEscolha, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Empate!");
        }
      else if (jogadorEscolha.Equals("Pedra", StringComparison.OrdinalIgnoreCase) && computadorEscolha == "Tesoura" ||
                 jogadorEscolha.Equals("Papel", StringComparison.OrdinalIgnoreCase) && computadorEscolha == "Pedra" ||
                 jogadorEscolha.Equals("Tesoura", StringComparison.OrdinalIgnoreCase) && computadorEscolha == "Papel")
        {
            Console.WriteLine("Você venceu!");
        }
        else
        {
            Console.WriteLine("Você perdeu!");
        }
    }
}

