namespace Componentes
{
    partial class F_ComboBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_mostrarSelecionado = new System.Windows.Forms.Button();
            this.btn_limparElementos = new System.Windows.Forms.Button();
            this.btn_resetarElementos = new System.Windows.Forms.Button();
            this.tb_transporte = new System.Windows.Forms.TextBox();
            this.btn_adicionarVeiculo = new System.Windows.Forms.Button();
            this.cb_transportes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_mostrarSelecionado
            // 
            this.btn_mostrarSelecionado.Location = new System.Drawing.Point(264, 9);
            this.btn_mostrarSelecionado.Name = "btn_mostrarSelecionado";
            this.btn_mostrarSelecionado.Size = new System.Drawing.Size(204, 23);
            this.btn_mostrarSelecionado.TabIndex = 1;
            this.btn_mostrarSelecionado.Text = "Mostrar Selecionado";
            this.btn_mostrarSelecionado.UseVisualStyleBackColor = true;
            this.btn_mostrarSelecionado.Click += new System.EventHandler(this.btn_mostrarSelecionado_Click);
            // 
            // btn_limparElementos
            // 
            this.btn_limparElementos.Location = new System.Drawing.Point(264, 40);
            this.btn_limparElementos.Name = "btn_limparElementos";
            this.btn_limparElementos.Size = new System.Drawing.Size(204, 23);
            this.btn_limparElementos.TabIndex = 2;
            this.btn_limparElementos.Text = "Limpar Elementos";
            this.btn_limparElementos.UseVisualStyleBackColor = true;
            this.btn_limparElementos.Click += new System.EventHandler(this.btn_limparElementos_Click);
            // 
            // btn_resetarElementos
            // 
            this.btn_resetarElementos.Location = new System.Drawing.Point(264, 69);
            this.btn_resetarElementos.Name = "btn_resetarElementos";
            this.btn_resetarElementos.Size = new System.Drawing.Size(204, 23);
            this.btn_resetarElementos.TabIndex = 3;
            this.btn_resetarElementos.Text = "Resetar Elementos";
            this.btn_resetarElementos.UseVisualStyleBackColor = true;
            this.btn_resetarElementos.Click += new System.EventHandler(this.btn_resetarElementos_Click);
            // 
            // tb_transporte
            // 
            this.tb_transporte.Location = new System.Drawing.Point(264, 125);
            this.tb_transporte.Name = "tb_transporte";
            this.tb_transporte.Size = new System.Drawing.Size(204, 20);
            this.tb_transporte.TabIndex = 4;
            // 
            // btn_adicionarVeiculo
            // 
            this.btn_adicionarVeiculo.Location = new System.Drawing.Point(264, 151);
            this.btn_adicionarVeiculo.Name = "btn_adicionarVeiculo";
            this.btn_adicionarVeiculo.Size = new System.Drawing.Size(204, 23);
            this.btn_adicionarVeiculo.TabIndex = 5;
            this.btn_adicionarVeiculo.Text = "Adicionar Veículo";
            this.btn_adicionarVeiculo.UseVisualStyleBackColor = true;
            this.btn_adicionarVeiculo.Click += new System.EventHandler(this.btn_adicionarVeiculo_Click);
            // 
            // cb_transportes
            // 
            this.cb_transportes.FormattingEnabled = true;
            this.cb_transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ônibus",
            "Trem"});
            this.cb_transportes.Location = new System.Drawing.Point(13, 10);
            this.cb_transportes.Name = "cb_transportes";
            this.cb_transportes.Size = new System.Drawing.Size(222, 21);
            this.cb_transportes.TabIndex = 6;
            this.cb_transportes.SelectedIndexChanged += new System.EventHandler(this.cb_transportes_SelectedIndexChanged);
            // 
            // F_ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.cb_transportes);
            this.Controls.Add(this.btn_adicionarVeiculo);
            this.Controls.Add(this.tb_transporte);
            this.Controls.Add(this.btn_resetarElementos);
            this.Controls.Add(this.btn_limparElementos);
            this.Controls.Add(this.btn_mostrarSelecionado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_ComboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mostrarSelecionado;
        private System.Windows.Forms.Button btn_limparElementos;
        private System.Windows.Forms.Button btn_resetarElementos;
        private System.Windows.Forms.TextBox tb_transporte;
        private System.Windows.Forms.Button btn_adicionarVeiculo;
        private System.Windows.Forms.ComboBox cb_transportes;
    }
}