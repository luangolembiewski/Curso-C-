namespace Componentes
{
    partial class F_principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_principal));
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.tb_informe = new System.Windows.Forms.TextBox();
            this.lb_texto = new System.Windows.Forms.Label();
            this.tb_lista = new System.Windows.Forms.TextBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.btn_variavel = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.componentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_componentes_checkbox = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_Componentes_CheckedListBox = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_componentes_dateTimePicker = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maskedTextBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxArquivosDeRecursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuNotificacoes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_restaurar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_mensagem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_fechar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.MenuNotificacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionar.Location = new System.Drawing.Point(183, 68);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(99, 30);
            this.btn_adicionar.TabIndex = 0;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // tb_informe
            // 
            this.tb_informe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_informe.Location = new System.Drawing.Point(12, 68);
            this.tb_informe.Name = "tb_informe";
            this.tb_informe.Size = new System.Drawing.Size(159, 30);
            this.tb_informe.TabIndex = 1;
            // 
            // lb_texto
            // 
            this.lb_texto.AutoSize = true;
            this.lb_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_texto.Location = new System.Drawing.Point(12, 40);
            this.lb_texto.Name = "lb_texto";
            this.lb_texto.Size = new System.Drawing.Size(128, 20);
            this.lb_texto.TabIndex = 2;
            this.lb_texto.Text = "Digite um veículo";
            // 
            // tb_lista
            // 
            this.tb_lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_lista.Location = new System.Drawing.Point(12, 127);
            this.tb_lista.Multiline = true;
            this.tb_lista.Name = "tb_lista";
            this.tb_lista.ReadOnly = true;
            this.tb_lista.Size = new System.Drawing.Size(270, 223);
            this.tb_lista.TabIndex = 3;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(12, 367);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(270, 23);
            this.btn_limpar.TabIndex = 4;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(12, 397);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(270, 23);
            this.btn_mostrar.TabIndex = 5;
            this.btn_mostrar.Text = "Mostrar Veículos";
            this.btn_mostrar.UseMnemonic = false;
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // btn_variavel
            // 
            this.btn_variavel.Location = new System.Drawing.Point(12, 426);
            this.btn_variavel.Name = "btn_variavel";
            this.btn_variavel.Size = new System.Drawing.Size(270, 23);
            this.btn_variavel.TabIndex = 6;
            this.btn_variavel.Text = "Valor da variável NUM";
            this.btn_variavel.UseVisualStyleBackColor = true;
            this.btn_variavel.Click += new System.EventHandler(this.btn_variavel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componentesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(297, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // componentesToolStripMenuItem
            // 
            this.componentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_componentes_checkbox,
            this.mn_Componentes_CheckedListBox,
            this.comboBoxToolStripMenuItem,
            this.mn_componentes_dateTimePicker,
            this.linkLabelToolStripMenuItem,
            this.listBoxToolStripMenuItem,
            this.listViewToolStripMenuItem,
            this.maskedTextBoxToolStripMenuItem,
            this.monthCalendarToolStripMenuItem,
            this.numericUpDownToolStripMenuItem,
            this.pictureBoxArquivosDeRecursosToolStripMenuItem,
            this.progressBarToolStripMenuItem,
            this.toolStripMenuItem1,
            this.trackBarToolStripMenuItem,
            this.treeViewToolStripMenuItem,
            this.webBrowserToolStripMenuItem,
            this.splitContainerToolStripMenuItem,
            this.tabControlToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripContainerToolStripMenuItem,
            this.backgroundWorkerToolStripMenuItem,
            this.toolStripMenuItem3});
            this.componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            this.componentesToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.componentesToolStripMenuItem.Text = "Componentes";
            // 
            // mn_componentes_checkbox
            // 
            this.mn_componentes_checkbox.Name = "mn_componentes_checkbox";
            this.mn_componentes_checkbox.Size = new System.Drawing.Size(255, 22);
            this.mn_componentes_checkbox.Text = "CheckBox";
            this.mn_componentes_checkbox.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.mn_componentes_checkbox.Click += new System.EventHandler(this.mn_componentes_checkbox_Click);
            // 
            // mn_Componentes_CheckedListBox
            // 
            this.mn_Componentes_CheckedListBox.Name = "mn_Componentes_CheckedListBox";
            this.mn_Componentes_CheckedListBox.Size = new System.Drawing.Size(255, 22);
            this.mn_Componentes_CheckedListBox.Text = "CheckedListBox";
            this.mn_Componentes_CheckedListBox.Click += new System.EventHandler(this.mn_Componentes_CheckedListBox_Click);
            // 
            // comboBoxToolStripMenuItem
            // 
            this.comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            this.comboBoxToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.comboBoxToolStripMenuItem.Text = "ComboBox";
            this.comboBoxToolStripMenuItem.Click += new System.EventHandler(this.comboBoxToolStripMenuItem_Click);
            // 
            // mn_componentes_dateTimePicker
            // 
            this.mn_componentes_dateTimePicker.Name = "mn_componentes_dateTimePicker";
            this.mn_componentes_dateTimePicker.Size = new System.Drawing.Size(255, 22);
            this.mn_componentes_dateTimePicker.Text = "DateTimePicker";
            this.mn_componentes_dateTimePicker.Click += new System.EventHandler(this.mn_componentes_dateTimePicker_Click);
            // 
            // linkLabelToolStripMenuItem
            // 
            this.linkLabelToolStripMenuItem.Name = "linkLabelToolStripMenuItem";
            this.linkLabelToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.linkLabelToolStripMenuItem.Text = "Label / LinkLabel";
            this.linkLabelToolStripMenuItem.Click += new System.EventHandler(this.linkLabelToolStripMenuItem_Click);
            // 
            // listBoxToolStripMenuItem
            // 
            this.listBoxToolStripMenuItem.Name = "listBoxToolStripMenuItem";
            this.listBoxToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.listBoxToolStripMenuItem.Text = "ListBox";
            this.listBoxToolStripMenuItem.Click += new System.EventHandler(this.listBoxToolStripMenuItem_Click);
            // 
            // listViewToolStripMenuItem
            // 
            this.listViewToolStripMenuItem.Name = "listViewToolStripMenuItem";
            this.listViewToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.listViewToolStripMenuItem.Text = "ListView";
            this.listViewToolStripMenuItem.Click += new System.EventHandler(this.listViewToolStripMenuItem_Click);
            // 
            // maskedTextBoxToolStripMenuItem
            // 
            this.maskedTextBoxToolStripMenuItem.Name = "maskedTextBoxToolStripMenuItem";
            this.maskedTextBoxToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.maskedTextBoxToolStripMenuItem.Text = "MaskedTextBox";
            this.maskedTextBoxToolStripMenuItem.Click += new System.EventHandler(this.maskedTextBoxToolStripMenuItem_Click);
            // 
            // monthCalendarToolStripMenuItem
            // 
            this.monthCalendarToolStripMenuItem.Name = "monthCalendarToolStripMenuItem";
            this.monthCalendarToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.monthCalendarToolStripMenuItem.Text = "MonthCalendar";
            this.monthCalendarToolStripMenuItem.Click += new System.EventHandler(this.monthCalendarToolStripMenuItem_Click);
            // 
            // numericUpDownToolStripMenuItem
            // 
            this.numericUpDownToolStripMenuItem.Name = "numericUpDownToolStripMenuItem";
            this.numericUpDownToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.numericUpDownToolStripMenuItem.Text = "NumericUpDown";
            this.numericUpDownToolStripMenuItem.Click += new System.EventHandler(this.numericUpDownToolStripMenuItem_Click);
            // 
            // pictureBoxArquivosDeRecursosToolStripMenuItem
            // 
            this.pictureBoxArquivosDeRecursosToolStripMenuItem.Name = "pictureBoxArquivosDeRecursosToolStripMenuItem";
            this.pictureBoxArquivosDeRecursosToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.pictureBoxArquivosDeRecursosToolStripMenuItem.Text = "PictureBox / Arquivos de Recursos";
            this.pictureBoxArquivosDeRecursosToolStripMenuItem.Click += new System.EventHandler(this.pictureBoxArquivosDeRecursosToolStripMenuItem_Click);
            // 
            // progressBarToolStripMenuItem
            // 
            this.progressBarToolStripMenuItem.Name = "progressBarToolStripMenuItem";
            this.progressBarToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.progressBarToolStripMenuItem.Text = "ProgressBar / Sleep";
            this.progressBarToolStripMenuItem.Click += new System.EventHandler(this.progressBarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(255, 22);
            this.toolStripMenuItem1.Text = "RadioButton / GroupBox";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // trackBarToolStripMenuItem
            // 
            this.trackBarToolStripMenuItem.Name = "trackBarToolStripMenuItem";
            this.trackBarToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.trackBarToolStripMenuItem.Text = "TrackBar";
            this.trackBarToolStripMenuItem.Click += new System.EventHandler(this.trackBarToolStripMenuItem_Click);
            // 
            // treeViewToolStripMenuItem
            // 
            this.treeViewToolStripMenuItem.Name = "treeViewToolStripMenuItem";
            this.treeViewToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.treeViewToolStripMenuItem.Text = "TreeView";
            this.treeViewToolStripMenuItem.Click += new System.EventHandler(this.treeViewToolStripMenuItem_Click);
            // 
            // webBrowserToolStripMenuItem
            // 
            this.webBrowserToolStripMenuItem.Name = "webBrowserToolStripMenuItem";
            this.webBrowserToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.webBrowserToolStripMenuItem.Text = "WebBrowser";
            this.webBrowserToolStripMenuItem.Click += new System.EventHandler(this.webBrowserToolStripMenuItem_Click);
            // 
            // splitContainerToolStripMenuItem
            // 
            this.splitContainerToolStripMenuItem.Name = "splitContainerToolStripMenuItem";
            this.splitContainerToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.splitContainerToolStripMenuItem.Text = "SplitContainer";
            this.splitContainerToolStripMenuItem.Click += new System.EventHandler(this.splitContainerToolStripMenuItem_Click);
            // 
            // tabControlToolStripMenuItem
            // 
            this.tabControlToolStripMenuItem.Name = "tabControlToolStripMenuItem";
            this.tabControlToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.tabControlToolStripMenuItem.Text = "TabControl";
            this.tabControlToolStripMenuItem.Click += new System.EventHandler(this.tabControlToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(255, 22);
            this.toolStripMenuItem2.Text = "TableLayoutPanel";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripContainerToolStripMenuItem
            // 
            this.toolStripContainerToolStripMenuItem.Name = "toolStripContainerToolStripMenuItem";
            this.toolStripContainerToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.toolStripContainerToolStripMenuItem.Text = "ToolStripContainer";
            this.toolStripContainerToolStripMenuItem.Click += new System.EventHandler(this.toolStripContainerToolStripMenuItem_Click);
            // 
            // backgroundWorkerToolStripMenuItem
            // 
            this.backgroundWorkerToolStripMenuItem.Name = "backgroundWorkerToolStripMenuItem";
            this.backgroundWorkerToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.backgroundWorkerToolStripMenuItem.Text = "BackgroundWorker";
            this.backgroundWorkerToolStripMenuItem.Click += new System.EventHandler(this.backgroundWorkerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(255, 22);
            this.toolStripMenuItem3.Text = "Timer";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.MenuNotificacoes;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Programa do Luan";
            this.notifyIcon1.Visible = true;
            // 
            // MenuNotificacoes
            // 
            this.MenuNotificacoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_restaurar,
            this.tsmi_mensagem,
            this.tsmi_fechar});
            this.MenuNotificacoes.Name = "MenuNotificacoes";
            this.MenuNotificacoes.Size = new System.Drawing.Size(134, 70);
            this.MenuNotificacoes.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuNotificacoes_ItemClicked);
            // 
            // tsmi_restaurar
            // 
            this.tsmi_restaurar.Name = "tsmi_restaurar";
            this.tsmi_restaurar.Size = new System.Drawing.Size(133, 22);
            this.tsmi_restaurar.Text = "Restaurar";
            // 
            // tsmi_mensagem
            // 
            this.tsmi_mensagem.Name = "tsmi_mensagem";
            this.tsmi_mensagem.Size = new System.Drawing.Size(133, 22);
            this.tsmi_mensagem.Text = "Mensagem";
            // 
            // tsmi_fechar
            // 
            this.tsmi_fechar.Name = "tsmi_fechar";
            this.tsmi_fechar.Size = new System.Drawing.Size(133, 22);
            this.tsmi_fechar.Text = "Fechar";
            // 
            // F_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 459);
            this.Controls.Add(this.btn_variavel);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.tb_lista);
            this.Controls.Add(this.lb_texto);
            this.Controls.Add(this.tb_informe);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "F_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Componentes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MenuNotificacoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.TextBox tb_informe;
        private System.Windows.Forms.Label lb_texto;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.Button btn_variavel;
        public System.Windows.Forms.TextBox tb_lista;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem componentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mn_componentes_checkbox;
        private System.Windows.Forms.ToolStripMenuItem mn_Componentes_CheckedListBox;
        private System.Windows.Forms.ToolStripMenuItem comboBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mn_componentes_dateTimePicker;
        private System.Windows.Forms.ToolStripMenuItem linkLabelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maskedTextBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthCalendarToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip MenuNotificacoes;
        private System.Windows.Forms.ToolStripMenuItem tsmi_restaurar;
        private System.Windows.Forms.ToolStripMenuItem tsmi_mensagem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_fechar;
        private System.Windows.Forms.ToolStripMenuItem numericUpDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pictureBoxArquivosDeRecursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem progressBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem trackBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treeViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem splitContainerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripContainerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundWorkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}

