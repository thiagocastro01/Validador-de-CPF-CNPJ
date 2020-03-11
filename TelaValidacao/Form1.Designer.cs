namespace TelaValidacao
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
            this.BtnValida = new System.Windows.Forms.Button();
            this.BtnCPF = new System.Windows.Forms.RadioButton();
            this.BtnCNPJ = new System.Windows.Forms.RadioButton();
            this.msk = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // BtnValida
            // 
            this.BtnValida.Location = new System.Drawing.Point(111, 125);
            this.BtnValida.Name = "BtnValida";
            this.BtnValida.Size = new System.Drawing.Size(75, 23);
            this.BtnValida.TabIndex = 0;
            this.BtnValida.Text = "VALIDAR";
            this.BtnValida.UseVisualStyleBackColor = true;
            this.BtnValida.Click += new System.EventHandler(this.BtnValida_Click);
            // 
            // BtnCPF
            // 
            this.BtnCPF.AutoSize = true;
            this.BtnCPF.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCPF.Location = new System.Drawing.Point(57, 37);
            this.BtnCPF.Name = "BtnCPF";
            this.BtnCPF.Size = new System.Drawing.Size(49, 20);
            this.BtnCPF.TabIndex = 1;
            this.BtnCPF.TabStop = true;
            this.BtnCPF.Text = "CPF";
            this.BtnCPF.UseVisualStyleBackColor = true;
            this.BtnCPF.CheckedChanged += new System.EventHandler(this.BtnCPF_CheckedChanged);
            // 
            // BtnCNPJ
            // 
            this.BtnCNPJ.AutoSize = true;
            this.BtnCNPJ.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCNPJ.Location = new System.Drawing.Point(204, 37);
            this.BtnCNPJ.Name = "BtnCNPJ";
            this.BtnCNPJ.Size = new System.Drawing.Size(58, 20);
            this.BtnCNPJ.TabIndex = 2;
            this.BtnCNPJ.TabStop = true;
            this.BtnCNPJ.Text = "CNPJ";
            this.BtnCNPJ.UseVisualStyleBackColor = true;
            this.BtnCNPJ.CheckedChanged += new System.EventHandler(this.BtnCNPJ_CheckedChanged);
            // 
            // msk
            // 
            this.msk.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.msk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk.Location = new System.Drawing.Point(101, 82);
            this.msk.Name = "msk";
            this.msk.Size = new System.Drawing.Size(100, 22);
            this.msk.TabIndex = 3;
            this.msk.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.msk.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.msk_MaskInputRejected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(312, 172);
            this.Controls.Add(this.msk);
            this.Controls.Add(this.BtnCNPJ);
            this.Controls.Add(this.BtnCPF);
            this.Controls.Add(this.BtnValida);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnValida;
        private System.Windows.Forms.RadioButton BtnCPF;
        private System.Windows.Forms.RadioButton BtnCNPJ;
        private System.Windows.Forms.MaskedTextBox msk;
    }
}

