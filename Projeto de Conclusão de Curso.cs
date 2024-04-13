using System;


    class Program
{
    static void Main(string[] args)
    {
        string[] choices = { "Pedra", "Papel", "Tesoura" };
        Random random = new Random();

        Console.WriteLine("Jogo de Jokenpô (Pedra-Papel-Tesoura)");
        Console.WriteLine("Escolha: Pedra, Papel ou Tesoura");
        string playerChoice = Console.ReadLine();

        if (!Array.Exists(choices, element => element.Equals(playerChoice, StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine("Escolha inválida.");
            return;
        }

        int computerChoiceIndex = random.Next(choices.Length);
        string computerChoice = choices[computerChoiceIndex];

        Console.WriteLine($"O computador escolheu: {computerChoice}");

        if (playerChoice.Equals(computerChoice, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Empate!");
        }
        else if (playerChoice.Equals("Pedra", StringComparison.OrdinalIgnoreCase) && computerChoice == "Tesoura" ||
                 playerChoice.Equals("Papel", StringComparison.OrdinalIgnoreCase) && computerChoice == "Pedra" ||
                 playerChoice.Equals("Tesoura", StringComparison.OrdinalIgnoreCase) && computerChoice == "Papel")
        {
            Console.WriteLine("Você venceu!");
        }
        else
        {
            Console.WriteLine("Você perdeu!");
        }
    }
}


