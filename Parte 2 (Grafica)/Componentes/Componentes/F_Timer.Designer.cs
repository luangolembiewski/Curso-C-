namespace Componentes
{
    partial class F_Timer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Timer));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_iniciar_t1 = new System.Windows.Forms.Button();
            this.btn_parar_t1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.img_carro = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_carro)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_iniciar_t1
            // 
            this.btn_iniciar_t1.Location = new System.Drawing.Point(29, 22);
            this.btn_iniciar_t1.Name = "btn_iniciar_t1";
            this.btn_iniciar_t1.Size = new System.Drawing.Size(75, 23);
            this.btn_iniciar_t1.TabIndex = 0;
            this.btn_iniciar_t1.Text = "Iniciar";
            this.btn_iniciar_t1.UseVisualStyleBackColor = true;
            this.btn_iniciar_t1.Click += new System.EventHandler(this.btn_iniciar_t1_Click);
            // 
            // btn_parar_t1
            // 
            this.btn_parar_t1.Location = new System.Drawing.Point(110, 22);
            this.btn_parar_t1.Name = "btn_parar_t1";
            this.btn_parar_t1.Size = new System.Drawing.Size(75, 23);
            this.btn_parar_t1.TabIndex = 1;
            this.btn_parar_t1.Text = "Parar";
            this.btn_parar_t1.UseVisualStyleBackColor = true;
            this.btn_parar_t1.Click += new System.EventHandler(this.btn_parar_t1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Reiniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Iniciar Carro";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // img_carro
            // 
            this.img_carro.Image = ((System.Drawing.Image)(resources.GetObject("img_carro.Image")));
            this.img_carro.Location = new System.Drawing.Point(29, 163);
            this.img_carro.Name = "img_carro";
            this.img_carro.Size = new System.Drawing.Size(133, 124);
            this.img_carro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_carro.TabIndex = 5;
            this.img_carro.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(110, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Parar Carro";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // F_Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 630);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.img_carro);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_parar_t1);
            this.Controls.Add(this.btn_iniciar_t1);
            this.Name = "F_Timer";
            this.Text = "F_Timer";
            this.Load += new System.EventHandler(this.F_Timer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_carro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_iniciar_t1;
        private System.Windows.Forms.Button btn_parar_t1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox img_carro;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button3;
    }
}