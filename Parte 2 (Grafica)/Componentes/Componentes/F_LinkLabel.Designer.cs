namespace Componentes
{
    partial class F_LinkLabel
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ll_calculadora = new System.Windows.Forms.LinkLabel();
            this.ll_youtube = new System.Windows.Forms.LinkLabel();
            this.ll_multiplos = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite seu Nome";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // ll_calculadora
            // 
            this.ll_calculadora.AutoSize = true;
            this.ll_calculadora.Location = new System.Drawing.Point(96, 87);
            this.ll_calculadora.Name = "ll_calculadora";
            this.ll_calculadora.Size = new System.Drawing.Size(63, 13);
            this.ll_calculadora.TabIndex = 2;
            this.ll_calculadora.TabStop = true;
            this.ll_calculadora.Text = "Calculadora";
            this.ll_calculadora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_calculadora_LinkClicked);
            // 
            // ll_youtube
            // 
            this.ll_youtube.AutoSize = true;
            this.ll_youtube.Location = new System.Drawing.Point(12, 87);
            this.ll_youtube.Name = "ll_youtube";
            this.ll_youtube.Size = new System.Drawing.Size(47, 13);
            this.ll_youtube.TabIndex = 3;
            this.ll_youtube.TabStop = true;
            this.ll_youtube.Text = "Youtube";
            this.ll_youtube.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_youtube_LinkClicked);
            // 
            // ll_multiplos
            // 
            this.ll_multiplos.AutoSize = true;
            this.ll_multiplos.Location = new System.Drawing.Point(10, 123);
            this.ll_multiplos.Name = "ll_multiplos";
            this.ll_multiplos.Size = new System.Drawing.Size(147, 13);
            this.ll_multiplos.TabIndex = 4;
            this.ll_multiplos.TabStop = true;
            this.ll_multiplos.Text = "Google - Facebook - Youtube";
            this.ll_multiplos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_multiplos_LinkClicked);
            // 
            // F_LinkLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 450);
            this.Controls.Add(this.ll_multiplos);
            this.Controls.Add(this.ll_youtube);
            this.Controls.Add(this.ll_calculadora);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_LinkLabel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LinkLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel ll_calculadora;
        private System.Windows.Forms.LinkLabel ll_youtube;
        private System.Windows.Forms.LinkLabel ll_multiplos;
    }
}