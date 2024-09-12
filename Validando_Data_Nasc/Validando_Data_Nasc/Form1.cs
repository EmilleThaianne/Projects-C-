// IFBA     Turma: 4º TI G1    Dupla: Davi Cunha e Emille Thaianne

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validando_Data_Nasc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void msk_data_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        
        }

        private void btn_validar_Click(object sender, EventArgs e)
        {
            string vConteudo;

            vConteudo = msk_data.Text;
            vConteudo = vConteudo.Replace(" ", "").Replace("/", "");
            vConteudo = vConteudo.Trim();
            Boolean validade = false;

            if (MessageBox.Show("Você realmente deseja validar sua data de nascimento?", "Mensagem de Validação",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (vConteudo == "")
                {
                    MessageBox.Show("Você deve digitar sua data de nascimento", "Mensagem de validação",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else

                    if (vConteudo.Length != 8)
                    {
                        MessageBox.Show("A data de nascimento deve ter 8 dígitos!", "Mensagem de Validação",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                else
                        

             if (vConteudo.Length == 8)
                {
                         validade = utilitarios.ValidarData(msk_data.Text);

                        if (validade == true)
                        {
                        MessageBox.Show("Data Válida", "Mensagem de Validação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (MessageBox.Show("Você deseja categorizar sua geração?", "Mensagem de Validação",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            utilitarios.ValidarGeracao(msk_data.Text);
                        }
                    } else {
                        MessageBox.Show("Data Inválido", "Mensagem de Validação",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                    }
                    
            }
        }
            private void btn_resetar_Click(object sender, EventArgs e)
        {
            msk_data.Text = "";
        }
    }
}
