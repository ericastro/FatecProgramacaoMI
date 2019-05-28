namespace WindowsFormsExe36
{
    partial class FormExe36
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
            this.rtbPrincipal = new System.Windows.Forms.RichTextBox();
            this.btnGerarNumeros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbPrincipal
            // 
            this.rtbPrincipal.Location = new System.Drawing.Point(12, 12);
            this.rtbPrincipal.Name = "rtbPrincipal";
            this.rtbPrincipal.Size = new System.Drawing.Size(380, 340);
            this.rtbPrincipal.TabIndex = 0;
            this.rtbPrincipal.Text = "";
            // 
            // btnGerarNumeros
            // 
            this.btnGerarNumeros.Location = new System.Drawing.Point(139, 377);
            this.btnGerarNumeros.Name = "btnGerarNumeros";
            this.btnGerarNumeros.Size = new System.Drawing.Size(109, 45);
            this.btnGerarNumeros.TabIndex = 1;
            this.btnGerarNumeros.Text = "button1";
            this.btnGerarNumeros.UseVisualStyleBackColor = true;
            this.btnGerarNumeros.Click += new System.EventHandler(this.btnGerarNumeros_Click);
            // 
            // FormExe36
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 450);
            this.Controls.Add(this.btnGerarNumeros);
            this.Controls.Add(this.rtbPrincipal);
            this.Name = "FormExe36";
            this.Text = "Exercício 36";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbPrincipal;
        private System.Windows.Forms.Button btnGerarNumeros;
    }
}

