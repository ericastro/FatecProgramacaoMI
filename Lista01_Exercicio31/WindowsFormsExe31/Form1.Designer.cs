namespace WindowsFormsExe31
{
    partial class FormPrincipal
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
            this.btnGerarFor = new System.Windows.Forms.Button();
            this.btnGerarWhile = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbExibir = new System.Windows.Forms.RichTextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGerarFor
            // 
            this.btnGerarFor.Location = new System.Drawing.Point(12, 346);
            this.btnGerarFor.Name = "btnGerarFor";
            this.btnGerarFor.Size = new System.Drawing.Size(100, 50);
            this.btnGerarFor.TabIndex = 0;
            this.btnGerarFor.Text = "Gerar por For";
            this.btnGerarFor.UseVisualStyleBackColor = true;
            this.btnGerarFor.Click += new System.EventHandler(this.btnGerarFor_Click);
            // 
            // btnGerarWhile
            // 
            this.btnGerarWhile.Location = new System.Drawing.Point(141, 346);
            this.btnGerarWhile.Name = "btnGerarWhile";
            this.btnGerarWhile.Size = new System.Drawing.Size(100, 50);
            this.btnGerarWhile.TabIndex = 1;
            this.btnGerarWhile.Text = "Gerar por While";
            this.btnGerarWhile.UseVisualStyleBackColor = true;
            this.btnGerarWhile.Click += new System.EventHandler(this.btnGerarWhile_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(270, 346);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 50);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Exiba todos os números pares dentro da seguinte faixa: 53 até 521. ";
            // 
            // rtbExibir
            // 
            this.rtbExibir.Location = new System.Drawing.Point(12, 42);
            this.rtbExibir.Name = "rtbExibir";
            this.rtbExibir.Size = new System.Drawing.Size(489, 287);
            this.rtbExibir.TabIndex = 4;
            this.rtbExibir.Text = "";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(399, 346);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(100, 50);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 419);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.rtbExibir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGerarWhile);
            this.Controls.Add(this.btnGerarFor);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerarFor;
        private System.Windows.Forms.Button btnGerarWhile;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbExibir;
        private System.Windows.Forms.Button btnFechar;
    }
}

