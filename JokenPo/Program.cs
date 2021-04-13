using System;

namespace JokenPo {
    class Program {
        static void Main(string[] args) {
            Random random = new Random();
            int opcaoComputador, opcaoJogador;
            opcaoComputador = random.Next(3);
            Console.WriteLine("Qual você quer jogar?");
            Console.WriteLine("----------------------");
            Console.WriteLine("[0] Pedra");
            Console.WriteLine("[1] Papel");
            Console.WriteLine("[2] Tesoura");
            Console.WriteLine("----------------------");
            Console.Write("Escolha uma opção: ");
            opcaoJogador = Convert.ToInt32(Console.ReadLine());
            if (opcaoJogador >= 3 || opcaoJogador < 0) {
                Console.WriteLine("Impossível");
            }
            else {
                switch (opcaoComputador) {
                    case 0:
                        Console.WriteLine("Computador joga pedra");
                        if (opcaoJogador == 0) {
                            Console.WriteLine("EMPATE");
                        }
                        else if (opcaoJogador == 1) {
                            Console.WriteLine("VITÓRIA");
                        }
                        else {
                            Console.WriteLine("DERROTA");
                        }

                        break;
                    case 1:
                        Console.WriteLine("Computador joga papel");
                        if (opcaoJogador == 1) {
                            Console.WriteLine("EMPATE");
                        }
                        else if (opcaoJogador == 2) {
                            Console.WriteLine("VITÓRIA");
                        }
                        else {
                            Console.WriteLine("DERROTA");
                        }

                        break;
                    case 2:
                        Console.WriteLine("Computador joga tesoura");
                        if (opcaoJogador == 2) {
                            Console.WriteLine("EMPATE");
                        }
                        else if (opcaoJogador == 0) {
                            Console.WriteLine("VITÓRIA");
                        }
                        else {
                            Console.WriteLine("DERROTA");
                        }

                        break;
                    default:
                        Console.WriteLine("Impossível");
                        break;
                }
            }
        }
    }
}