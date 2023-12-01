// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ETProgramteste
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensagemDeBoasVindas = "Bem vindos ao Screen Sound";

            //Criação da lista para armazenamento das bandas
            //List<string> listaDasBandas = new List<string> {"U2", "Eva", "Beatles" };

            //Agora estrutura de dicionários
            Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
            bandasRegistradas.Add("Linking Park", new List<int> { 10, 8, 6 });
            bandasRegistradas.Add("The Beatles", new List<int> { });

            Console.WriteLine(mensagemDeBoasVindas);
            ExibirOpcoesDoMenu();


            void ExibirLogo()
            {
                Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");

            }

            void ExibirOpcoesDoMenu()
            {
                ExibirLogo();
                Console.WriteLine("\nDigite 1 para registrar uma banda");
                Console.WriteLine("Digite 2 para mostrar todas as bandas");
                Console.WriteLine("Digite 3 para avaliar uma banda");
                Console.WriteLine("Digite 4 para exibir a média de uma banda");
                Console.WriteLine("Digite -1 para sair");

                Console.Write("\nDigite a sua opção: ");
                string opcaoEscolhida = Console.ReadLine()!;
                int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

                switch (opcaoEscolhidaNumerica)
                {
                    case 1:
                        RegistrarBanda();
                        break;
                    case 2:
                        MostrarBandasRegistradas();
                        break;
                    case 3:
                        AvaliarUmaBanda();
                        break;
                    case 4:
                        ExibirMedia();
                        break;
                    case -1:
                        Console.WriteLine("Tchau Tchau");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            }

            void RegistrarBanda()
            {
                Console.Clear();
                ExibirTituloDaOpcao("Registro de Bandas");

                //Console.WriteLine("*********");
                //Console.WriteLine("Registro de Bandas");
                //Console.WriteLine("*********");
                Console.Write("Digite o nome da banda que deseja registrar: ");
                string nomeDaBanda = Console.ReadLine()!;

                //listaDasBandas.Add(nomeDaBanda);
                bandasRegistradas.Add(nomeDaBanda, new List<int>());

                Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
                Thread.Sleep(2000);
                Console.Clear();
                ExibirOpcoesDoMenu();

            }

            void MostrarBandasRegistradas()
            {
                Console.Clear();
                ExibirTituloDaOpcao("Exibindo as bandas registradas");
                //Console.WriteLine("**********");
                //Console.WriteLine("Exibindo as bandas registradas");
                //Console.WriteLine("**********\n");

                //for (int i = 0; i < listaDasBandas.Count; i++)
                //{
                //    Console.WriteLine($"Banda : {listaDasBandas[i]}");
                //}

                foreach (string banda in bandasRegistradas.Keys)
                {
                    Console.WriteLine($"Banda: {banda}");
                }

                Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
                ExibirOpcoesDoMenu();
            }

            void ExibirTituloDaOpcao(string titulo)
            {
                int quantidadeDeLetras = titulo.Length;
                string asteriscos = string.Empty.PadLeft(quantidadeDeLetras);
                Console.WriteLine(asteriscos);
                Console.WriteLine(titulo);
                Console.WriteLine(asteriscos + "\n");
            }

            void AvaliarUmaBanda()
            {
                //Digitat uma banda que deseja avaliar
                //Sea banda existir --> atribuir uma nota
                //Senão, diz que não existe e volta ao menu principal

                Console.Clear();
                ExibirTituloDaOpcao("Avaliar Banda");
                Console.WriteLine("Digite o nome da banda que deseja avaliar:");
                string nomeDaBanda = Console.ReadLine()!;

                if (bandasRegistradas.ContainsKey(nomeDaBanda))
                {
                    Console.Write($"Qual a nota que a banda {nomeDaBanda} merece:");
                    int nota = int.Parse(Console.ReadLine()!);
                    bandasRegistradas[nomeDaBanda].Add(nota);
                    Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");

                    Thread.Sleep(2000);
                    Console.Clear();
                    ExibirOpcoesDoMenu();

                }
                else
                {
                    Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada");
                    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                    Console.ReadLine();
                    Console.Clear();
                    ExibirOpcoesDoMenu();
                }

            }
                void ExibirMedia()
                {
                    Console.Clear();
                    ExibirTituloDaOpcao("Exibir média da banda");
                    Console.Write("Digite o nome da banda que deseja exibir média:");
                    string nomeDaBanda = Console.ReadLine()!;

                    if(bandasRegistradas.ContainsKey(nomeDaBanda))
                    {
                        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
                        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {notasDaBanda.Average()}");
                        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                        Console.ReadKey();
                        Console.Clear();
                        ExibirOpcoesDoMenu();

                    }else{
                    Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada");
                    Console.WriteLine("Digite u a tecla pra voltar ao menu principal");
                    Console.ReadKey();
                    Console.Clear();
                    ExibirOpcoesDoMenu();
                    }
                    

                }
                //Thread.Sleep(3000);

            }

        } 
    }
