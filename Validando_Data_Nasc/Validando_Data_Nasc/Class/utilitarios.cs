using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validando_Data_Nasc
{
    internal class utilitarios
    {
        public static bool ValidarData(string Data_Recibo)
        {
            Data_Recibo = Data_Recibo.Trim();
            Data_Recibo = Data_Recibo.Replace(" ", "").Replace("/", "");
            Boolean valida = false;

            int mes = int.Parse(Data_Recibo.Substring(2, 2));

            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
            {
                int dia = int.Parse(Data_Recibo.Substring(0, 2));
                if (dia <= 31)
                {
                    valida = true;
                }

            }
            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                int dia = int.Parse(Data_Recibo.Substring(0, 2));
                if (dia <= 30)
                {
                    valida = true;
                }
                
            }
            else if (mes == 2)
            {
                int ano = int.Parse(Data_Recibo.Substring(4, 4));
                if (ano % 4 == 0)
                {
                    int dia = int.Parse(Data_Recibo.Substring(0, 2));
                    if (dia <= 29)
                    {
                        valida = true;
                    }

                }
                else
                {
                    int dia = int.Parse(Data_Recibo.Substring(0, 2));
                    if (dia <= 28)
                    {
                        valida = true;
                    }

                }
            }

            if (valida == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
                public static void ValidarGeracao(string Data_Recibo)
                {
                    Data_Recibo = Data_Recibo.Trim();
                    Data_Recibo = Data_Recibo.Replace(" ", "").Replace("/", "");
                    int ano = int.Parse(Data_Recibo.Substring(4, 4));

                    if (ano >= 2010)
                    {
                        MessageBox.Show("Sua geração é categorizada com Geração Alfa.");
                    }
                    else if (ano >= 1997)
                    {
                        MessageBox.Show("Sua geração é categorizada com Geração Z.");
                    }
                    else if (ano >= 1981)
                    {
                        MessageBox.Show("Sua geração é categorizada com Geração Y ou Millennials.");
                    }
                    else if (ano >= 1965)
                    {
                        MessageBox.Show("Sua geração é categorizada com Geração X.");
                    }
                    else if (ano >= 1946 )
                    {
                        MessageBox.Show("Sua geração é categorizada com Geração Baby Boomers.");
                    }
                    else
                    {
                        MessageBox.Show("Sua geração é não está categorizada!");

                    }

                }
            }
        }
