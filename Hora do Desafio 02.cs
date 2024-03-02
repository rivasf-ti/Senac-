using System;


    class Program {
        static void Main(string[] args) {
            int Cod, Quant;
            double Valor, ValorFinal;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("        LANCHES DONA FLORINDA        ");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("COD | ESPECIFICACAO   | PRECO");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("[1] | CACHORRO QUENTE | R$ 4.00");
            Console.WriteLine("[2] | X - SALADA      | R$ 4.50");
            Console.WriteLine("[3] | X - BACON       | R$ 5.00");
            Console.WriteLine("[4] | TORRADA SIMPLES | R$ 2.00");
            Console.WriteLine("[5] | REFRIGERANTE    | R$ 1.50");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");

            Console.Write("ESCOLHA UMA OPCAO: ");
            Cod = int.Parse(Console.ReadLine());

            Console.Write("ESCOLHA UMA QUANTIDADE: ");
            Quant = int.Parse(Console.ReadLine());

            switch (Cod) {
                    case 1:
                        Valor = 4.00;
                    break;
                    case 2:
                        Valor = 4.50;
                    break;
                    case 3:
                        Valor = 5.00;
                    break;
                    case 4:
                        Valor = 2.00;
                    break;
                    case 5:
                        Valor = 1.50;
                    break;
                default:
                    Console.WriteLine("ESCOLHA UMA DAS OPCOES DISPONIVEIS NO CARDAPIO");
                    return;
            }

            ValorFinal = Valor * Quant;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"TOTAL R$ {ValorFinal:0.00}");
            Console.WriteLine("--------------------------------------");
        }
    }
