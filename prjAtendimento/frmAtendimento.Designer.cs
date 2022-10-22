
namespace WindowsFormsApp1
{
    partial class frmAtendimento
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
            this.btnGerar = new System.Windows.Forms.Button();
            this.lstSenhas = new System.Windows.Forms.ListBox();
            this.btnLstSenhas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQtdGuiche = new System.Windows.Forms.Label();
            this.btnAdicionarGuiche = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGuiche = new System.Windows.Forms.TextBox();
            this.btnChamar = new System.Windows.Forms.Button();
            this.lstAtendimento = new System.Windows.Forms.ListBox();
            this.btnAtendimento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(21, 12);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(120, 23);
            this.btnGerar.TabIndex = 0;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // lstSenhas
            // 
            this.lstSenhas.FormattingEnabled = true;
            this.lstSenhas.Location = new System.Drawing.Point(21, 53);
            this.lstSenhas.Name = "lstSenhas";
            this.lstSenhas.Size = new System.Drawing.Size(120, 95);
            this.lstSenhas.TabIndex = 1;
            // 
            // btnLstSenhas
            // 
            this.btnLstSenhas.Location = new System.Drawing.Point(21, 171);
            this.btnLstSenhas.Name = "btnLstSenhas";
            this.btnLstSenhas.Size = new System.Drawing.Size(120, 23);
            this.btnLstSenhas.TabIndex = 2;
            this.btnLstSenhas.Text = "Listar Senhas";
            this.btnLstSenhas.UseVisualStyleBackColor = true;
            this.btnLstSenhas.Click += new System.EventHandler(this.btnLstSenhas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Qtde. de Guiche:";
            // 
            // lblQtdGuiche
            // 
            this.lblQtdGuiche.AutoSize = true;
            this.lblQtdGuiche.Location = new System.Drawing.Point(172, 118);
            this.lblQtdGuiche.Name = "lblQtdGuiche";
            this.lblQtdGuiche.Size = new System.Drawing.Size(0, 13);
            this.lblQtdGuiche.TabIndex = 4;
            // 
            // btnAdicionarGuiche
            // 
            this.btnAdicionarGuiche.Location = new System.Drawing.Point(175, 134);
            this.btnAdicionarGuiche.Name = "btnAdicionarGuiche";
            this.btnAdicionarGuiche.Size = new System.Drawing.Size(85, 23);
            this.btnAdicionarGuiche.TabIndex = 5;
            this.btnAdicionarGuiche.Text = "Adicionar";
            this.btnAdicionarGuiche.UseVisualStyleBackColor = true;
            this.btnAdicionarGuiche.Click += new System.EventHandler(this.btnAdicionarGuiche_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Guiche:";
            // 
            // txtGuiche
            // 
            this.txtGuiche.Location = new System.Drawing.Point(357, 15);
            this.txtGuiche.Name = "txtGuiche";
            this.txtGuiche.Size = new System.Drawing.Size(66, 20);
            this.txtGuiche.TabIndex = 7;
            // 
            // btnChamar
            // 
            this.btnChamar.Location = new System.Drawing.Point(440, 13);
            this.btnChamar.Name = "btnChamar";
            this.btnChamar.Size = new System.Drawing.Size(119, 23);
            this.btnChamar.TabIndex = 8;
            this.btnChamar.Text = "Chamar";
            this.btnChamar.UseVisualStyleBackColor = true;
            this.btnChamar.Click += new System.EventHandler(this.btnChamar_Click);
            // 
            // lstAtendimento
            // 
            this.lstAtendimento.FormattingEnabled = true;
            this.lstAtendimento.Location = new System.Drawing.Point(310, 62);
            this.lstAtendimento.Name = "lstAtendimento";
            this.lstAtendimento.Size = new System.Drawing.Size(249, 95);
            this.lstAtendimento.TabIndex = 9;
            // 
            // btnAtendimento
            // 
            this.btnAtendimento.Location = new System.Drawing.Point(310, 171);
            this.btnAtendimento.Name = "btnAtendimento";
            this.btnAtendimento.Size = new System.Drawing.Size(249, 23);
            this.btnAtendimento.TabIndex = 10;
            this.btnAtendimento.Text = "Listar Atendimento";
            this.btnAtendimento.UseVisualStyleBackColor = true;
            this.btnAtendimento.Click += new System.EventHandler(this.btnAtendimento_Click);
            // 
            // frmAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 206);
            this.Controls.Add(this.btnAtendimento);
            this.Controls.Add(this.lstAtendimento);
            this.Controls.Add(this.btnChamar);
            this.Controls.Add(this.txtGuiche);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdicionarGuiche);
            this.Controls.Add(this.lblQtdGuiche);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLstSenhas);
            this.Controls.Add(this.lstSenhas);
            this.Controls.Add(this.btnGerar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmAtendimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atendimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.ListBox lstSenhas;
        private System.Windows.Forms.Button btnLstSenhas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQtdGuiche;
        private System.Windows.Forms.Button btnAdicionarGuiche;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGuiche;
        private System.Windows.Forms.Button btnChamar;
        private System.Windows.Forms.ListBox lstAtendimento;
        private System.Windows.Forms.Button btnAtendimento;
    }
}

