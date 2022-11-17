namespace Componentes
{
    partial class F_secundario
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
            this.tb_lista = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_lista
            // 
            this.tb_lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_lista.Location = new System.Drawing.Point(12, 12);
            this.tb_lista.Multiline = true;
            this.tb_lista.Name = "tb_lista";
            this.tb_lista.Size = new System.Drawing.Size(356, 426);
            this.tb_lista.TabIndex = 0;
            // 
            // F_secundario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.tb_lista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_secundario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Veículos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_secundario_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_lista;
    }
}