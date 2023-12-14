
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
            string opcaoinformada = Console.ReadLine()!;
            int salariobruto = int.Parse(opcaoinformada);

            Console.Write("\nInforme o número de dependentes que possui: ");
            string opcaoinformado = Console.ReadLine()!;
            int numdependent = int.Parse(opcaoinformado);

            double salarioliquido = calculo(salariobruto,numdependent);
            Console.WriteLine($"\nO seu salário Liquido é: {salarioliquido} ");
            Console.ReadKey();

            double calculo( double salariobruto_, int numdependent_){

                double inss = 0.14*salariobruto_;
                double impostoRetido;

                if ((salariobruto_ - inss) <= 2112.66 ){
                    impostoRetido = 0;

                } else if ((salariobruto_ - inss) <= 2826.60){
                    impostoRetido = (salariobruto_ - inss)*0.075-158.40;

                } else if ((salariobruto_ - inss) <= 3751.06){
                    impostoRetido = (salariobruto_ - inss)*0.15-370.40;

                } else if ((salariobruto_ - inss) <= 4664.68){
                    impostoRetido = (salariobruto_ - inss)*0.225-651.73;

                } else {
                    impostoRetido = (salariobruto_-inss)*0.275-884.96;
                }
                double descontoPlanoTotal = numdependent_*189;

                return salariobruto_-inss-impostoRetido-descontoPlanoTotal;      

                }
            }
        }
    }