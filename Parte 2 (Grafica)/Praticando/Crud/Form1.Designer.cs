namespace Crud
{
    partial class F_Cadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_obter = new System.Windows.Forms.Button();
            this.lv_lista = new System.Windows.Forms.ListView();
            this.col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_endereco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtp_nascimento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(29, 50);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(251, 20);
            this.tb_nome.TabIndex = 1;
            // 
            // tb_endereco
            // 
            this.tb_endereco.Location = new System.Drawing.Point(390, 50);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.Size = new System.Drawing.Size(254, 20);
            this.tb_endereco.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dt Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Endereço";
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(29, 93);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(156, 23);
            this.btn_adicionar.TabIndex = 7;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(488, 93);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(156, 23);
            this.btn_remover.TabIndex = 8;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Location = new System.Drawing.Point(339, 93);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(143, 23);
            this.btn_atualizar.TabIndex = 9;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_obter
            // 
            this.btn_obter.Location = new System.Drawing.Point(191, 93);
            this.btn_obter.Name = "btn_obter";
            this.btn_obter.Size = new System.Drawing.Size(142, 23);
            this.btn_obter.TabIndex = 10;
            this.btn_obter.Text = "Buscar";
            this.btn_obter.UseVisualStyleBackColor = true;
            this.btn_obter.Click += new System.EventHandler(this.btn_obter_Click);
            // 
            // lv_lista
            // 
            this.lv_lista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_id,
            this.col_nome,
            this.col_data,
            this.col_endereco});
            this.lv_lista.FullRowSelect = true;
            this.lv_lista.HideSelection = false;
            this.lv_lista.Location = new System.Drawing.Point(29, 143);
            this.lv_lista.MultiSelect = false;
            this.lv_lista.Name = "lv_lista";
            this.lv_lista.Size = new System.Drawing.Size(615, 490);
            this.lv_lista.TabIndex = 11;
            this.lv_lista.UseCompatibleStateImageBehavior = false;
            this.lv_lista.View = System.Windows.Forms.View.Details;
            // 
            // col_id
            // 
            this.col_id.Text = "ID";
            this.col_id.Width = 29;
            // 
            // col_nome
            // 
            this.col_nome.Text = "Nome Completo";
            this.col_nome.Width = 264;
            // 
            // col_data
            // 
            this.col_data.Text = "Dt Nascimento";
            this.col_data.Width = 105;
            // 
            // col_endereco
            // 
            this.col_endereco.Text = "Endereço";
            this.col_endereco.Width = 206;
            // 
            // dtp_nascimento
            // 
            this.dtp_nascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_nascimento.Location = new System.Drawing.Point(286, 49);
            this.dtp_nascimento.MaxDate = new System.DateTime(2022, 10, 19, 14, 58, 32, 0);
            this.dtp_nascimento.Name = "dtp_nascimento";
            this.dtp_nascimento.Size = new System.Drawing.Size(98, 20);
            this.dtp_nascimento.TabIndex = 12;
            this.dtp_nascimento.Value = new System.DateTime(2022, 9, 20, 0, 0, 0, 0);
            // 
            // F_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 658);
            this.Controls.Add(this.dtp_nascimento);
            this.Controls.Add(this.lv_lista);
            this.Controls.Add(this.btn_obter);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_endereco);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_endereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_obter;
        private System.Windows.Forms.ListView lv_lista;
        private System.Windows.Forms.ColumnHeader col_id;
        private System.Windows.Forms.ColumnHeader col_nome;
        private System.Windows.Forms.ColumnHeader col_data;
        private System.Windows.Forms.ColumnHeader col_endereco;
        private System.Windows.Forms.DateTimePicker dtp_nascimento;
    }
}

