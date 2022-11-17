namespace aula61
{
    partial class f_Principal
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
            this.btn_copiar = new System.Windows.Forms.Button();
            this.lb_texto = new System.Windows.Forms.Label();
            this.tb_texto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_copiar
            // 
            this.btn_copiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_copiar.Location = new System.Drawing.Point(12, 48);
            this.btn_copiar.Name = "btn_copiar";
            this.btn_copiar.Size = new System.Drawing.Size(195, 23);
            this.btn_copiar.TabIndex = 0;
            this.btn_copiar.Text = "COPIAR";
            this.btn_copiar.UseVisualStyleBackColor = true;
            this.btn_copiar.Click += new System.EventHandler(this.btn_copiar_Click);
            // 
            // lb_texto
            // 
            this.lb_texto.AutoSize = true;
            this.lb_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_texto.Location = new System.Drawing.Point(7, 88);
            this.lb_texto.Name = "lb_texto";
            this.lb_texto.Size = new System.Drawing.Size(137, 25);
            this.lb_texto.TabIndex = 1;
            this.lb_texto.Text = "Seu texto aqui";
            // 
            // tb_texto
            // 
            this.tb_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_texto.Location = new System.Drawing.Point(12, 12);
            this.tb_texto.Name = "tb_texto";
            this.tb_texto.Size = new System.Drawing.Size(195, 30);
            this.tb_texto.TabIndex = 2;
            // 
            // f_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 450);
            this.Controls.Add(this.tb_texto);
            this.Controls.Add(this.lb_texto);
            this.Controls.Add(this.btn_copiar);
            this.Name = "f_Principal";
            this.Text = "Primeiro App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_copiar;
        private System.Windows.Forms.Label lb_texto;
        private System.Windows.Forms.TextBox tb_texto;
    }
}

