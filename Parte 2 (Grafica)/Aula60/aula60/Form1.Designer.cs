namespace aula60
{
    partial class jnl_inicial
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
            this.btn_botao = new System.Windows.Forms.Button();
            this.lb_luan = new System.Windows.Forms.Label();
            this.tb_texto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_botao
            // 
            this.btn_botao.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_botao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_botao.Location = new System.Drawing.Point(12, 65);
            this.btn_botao.Name = "btn_botao";
            this.btn_botao.Size = new System.Drawing.Size(126, 38);
            this.btn_botao.TabIndex = 0;
            this.btn_botao.Text = "Botão";
            this.btn_botao.UseVisualStyleBackColor = false;
            // 
            // lb_luan
            // 
            this.lb_luan.AutoSize = true;
            this.lb_luan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_luan.Location = new System.Drawing.Point(7, 26);
            this.lb_luan.Name = "lb_luan";
            this.lb_luan.Size = new System.Drawing.Size(56, 25);
            this.lb_luan.TabIndex = 1;
            this.lb_luan.Text = "Luan";
            this.lb_luan.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_texto
            // 
            this.tb_texto.Location = new System.Drawing.Point(12, 128);
            this.tb_texto.Name = "tb_texto";
            this.tb_texto.Size = new System.Drawing.Size(126, 20);
            this.tb_texto.TabIndex = 2;
            this.tb_texto.TextChanged += new System.EventHandler(this.tb_texto_TextChanged);
            // 
            // jnl_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 642);
            this.Controls.Add(this.tb_texto);
            this.Controls.Add(this.lb_luan);
            this.Controls.Add(this.btn_botao);
            this.Name = "jnl_inicial";
            this.Text = "Curso de C# - CFB Cursos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_botao;
        private System.Windows.Forms.Label lb_luan;
        private System.Windows.Forms.TextBox tb_texto;
    }
}

