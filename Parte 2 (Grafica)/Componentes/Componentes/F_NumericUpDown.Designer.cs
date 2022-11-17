namespace Componentes
{
    partial class F_NumericUpDown
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
            this.nud_contador = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_incremetador = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_contador)).BeginInit();
            this.SuspendLayout();
            // 
            // nud_contador
            // 
            this.nud_contador.Location = new System.Drawing.Point(12, 29);
            this.nud_contador.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nud_contador.Name = "nud_contador";
            this.nud_contador.Size = new System.Drawing.Size(69, 20);
            this.nud_contador.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Incrementação:";
            // 
            // tb_incremetador
            // 
            this.tb_incremetador.Location = new System.Drawing.Point(139, 28);
            this.tb_incremetador.Name = "tb_incremetador";
            this.tb_incremetador.Size = new System.Drawing.Size(78, 20);
            this.tb_incremetador.TabIndex = 2;
            this.tb_incremetador.TextChanged += new System.EventHandler(this.tb_incremetador_TextChanged);
            // 
            // F_NumericUpDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 105);
            this.Controls.Add(this.tb_incremetador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_contador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_NumericUpDown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NumericUpDown";
            ((System.ComponentModel.ISupportInitialize)(this.nud_contador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud_contador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_incremetador;
    }
}