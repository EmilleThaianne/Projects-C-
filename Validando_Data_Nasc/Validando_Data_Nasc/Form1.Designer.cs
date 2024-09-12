namespace Validando_Data_Nasc
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.msk_data = new System.Windows.Forms.MaskedTextBox();
            this.btn_validar = new System.Windows.Forms.Button();
            this.btn_resetar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // msk_data
            // 
            this.msk_data.Location = new System.Drawing.Point(230, 198);
            this.msk_data.Mask = "00/00/0000";
            this.msk_data.Name = "msk_data";
            this.msk_data.Size = new System.Drawing.Size(219, 20);
            this.msk_data.TabIndex = 0;
            this.msk_data.ValidatingType = typeof(System.DateTime);
            this.msk_data.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.msk_data_MaskInputRejected);
            // 
            // btn_validar
            // 
            this.btn_validar.Location = new System.Drawing.Point(241, 262);
            this.btn_validar.Name = "btn_validar";
            this.btn_validar.Size = new System.Drawing.Size(75, 23);
            this.btn_validar.TabIndex = 1;
            this.btn_validar.Text = "Validar";
            this.btn_validar.UseVisualStyleBackColor = true;
            this.btn_validar.Click += new System.EventHandler(this.btn_validar_Click);
            // 
            // btn_resetar
            // 
            this.btn_resetar.Location = new System.Drawing.Point(369, 262);
            this.btn_resetar.Name = "btn_resetar";
            this.btn_resetar.Size = new System.Drawing.Size(70, 23);
            this.btn_resetar.TabIndex = 2;
            this.btn_resetar.Text = "Resetar";
            this.btn_resetar.UseVisualStyleBackColor = true;
            this.btn_resetar.Click += new System.EventHandler(this.btn_resetar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_resetar);
            this.Controls.Add(this.btn_validar);
            this.Controls.Add(this.msk_data);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox msk_data;
        private System.Windows.Forms.Button btn_validar;
        private System.Windows.Forms.Button btn_resetar;
    }
}

