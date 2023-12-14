
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ImpostodeRenda{
    class Program{
        static void Main (string[] args){
            
            Console.Write("\nInforme o valor do seu salário bruto: ");
            string informadosalario = Console.ReadLine()!;
            int salariobruto = int.Parse(informadosalario);

            Console.Write("\nInforme o número de dependentes que possui: ");
            string informadodependentes = Console.ReadLine()!;
            int numdependent = int.Parse(informadodependentes);

            double salarioliquido = calculo(salariobruto,numdependent);
            Console.WriteLine($"\nO seu Salário Liquido é: {salarioliquido} ");
            Console.ReadKey();

            double calculo( double salariobruto_, int numdependent_){

                double inss = 0.14*salariobruto_;
                double impostoRetido;

                if ((salariobruto_ - inss) <= 2112){
                    impostoRetido = 0;

                } else if ((salariobruto_ - inss) <= 2826.66){
                    impostoRetido = (salariobruto_ - inss)*0.075-158.40;

                } else if ((salariobruto_ - inss) <= 3751.06){
                    impostoRetido = (salariobruto_ - inss)*0.15-370.40;

                } else if ((salariobruto_ - inss) <= 4664.68){
                    impostoRetido = (salariobruto_ - inss)*0.225-651.73;

                } else {
                    impostoRetido = (salariobruto_-inss)*0.275-884.96;
                }

                const double descontoPlanoSaudePorDependente = 189;
                double descontoPlanoTotal = numdependent_*descontoPlanoSaudePorDependente;

                return salariobruto_-inss-impostoRetido-descontoPlanoTotal;      

                }
            }
        }
    }