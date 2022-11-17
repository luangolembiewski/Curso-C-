namespace Componentes
{
    partial class F_tabControl
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
            this.tc_tabs = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_novaTab = new System.Windows.Forms.TextBox();
            this.btn_addTab = new System.Windows.Forms.Button();
            this.btn_removerTab = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_posicaoTab = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tc_tabs.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tc_tabs
            // 
            this.tc_tabs.Controls.Add(this.tabPage2);
            this.tc_tabs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tc_tabs.Location = new System.Drawing.Point(0, 99);
            this.tc_tabs.Name = "tc_tabs";
            this.tc_tabs.SelectedIndex = 0;
            this.tc_tabs.Size = new System.Drawing.Size(800, 351);
            this.tc_tabs.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 325);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Componentes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb_novaTab
            // 
            this.tb_novaTab.Location = new System.Drawing.Point(13, 13);
            this.tb_novaTab.Name = "tb_novaTab";
            this.tb_novaTab.Size = new System.Drawing.Size(118, 20);
            this.tb_novaTab.TabIndex = 1;
            // 
            // btn_addTab
            // 
            this.btn_addTab.Location = new System.Drawing.Point(137, 13);
            this.btn_addTab.Name = "btn_addTab";
            this.btn_addTab.Size = new System.Drawing.Size(110, 23);
            this.btn_addTab.TabIndex = 2;
            this.btn_addTab.Text = "Adicionar Tab";
            this.btn_addTab.UseVisualStyleBackColor = true;
            this.btn_addTab.Click += new System.EventHandler(this.btn_addTab_Click);
            // 
            // btn_removerTab
            // 
            this.btn_removerTab.Location = new System.Drawing.Point(253, 13);
            this.btn_removerTab.Name = "btn_removerTab";
            this.btn_removerTab.Size = new System.Drawing.Size(119, 23);
            this.btn_removerTab.TabIndex = 3;
            this.btn_removerTab.Text = "Remover Tab";
            this.btn_removerTab.UseVisualStyleBackColor = true;
            this.btn_removerTab.Click += new System.EventHandler(this.btn_removerTab_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(13, 53);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // btn_posicaoTab
            // 
            this.btn_posicaoTab.Location = new System.Drawing.Point(140, 53);
            this.btn_posicaoTab.Name = "btn_posicaoTab";
            this.btn_posicaoTab.Size = new System.Drawing.Size(75, 23);
            this.btn_posicaoTab.TabIndex = 5;
            this.btn_posicaoTab.Text = "Posicionar";
            this.btn_posicaoTab.UseVisualStyleBackColor = true;
            this.btn_posicaoTab.Click += new System.EventHandler(this.btn_posicaoTab_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Principal";
            // 
            // F_tabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_posicaoTab);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_removerTab);
            this.Controls.Add(this.btn_addTab);
            this.Controls.Add(this.tb_novaTab);
            this.Controls.Add(this.tc_tabs);
            this.Name = "F_tabControl";
            this.Text = "F_tabControl";
            this.tc_tabs.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tc_tabs;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_novaTab;
        private System.Windows.Forms.Button btn_addTab;
        private System.Windows.Forms.Button btn_removerTab;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_posicaoTab;
        private System.Windows.Forms.Label label1;
    }
}