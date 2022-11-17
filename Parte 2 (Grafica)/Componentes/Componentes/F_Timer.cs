using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_Timer : Form
    {
        int num=0;
        int px;
        int py;
        public F_Timer()
        {
            InitializeComponent();
        }

        private void F_Timer_Load(object sender, EventArgs e)
        {
            px=img_carro.Location.X;
            py=img_carro.Location.Y;
        }

        private void btn_iniciar_t1_Click(object sender, EventArgs e)
        {

            //timer1.Interval = 5000
            timer1.Start();
        }

        private void btn_parar_t1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            num++;
            label1.Text = num.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            num=0;
            label1.Text=num.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            px++;
            if (px >= 760)
            {
                px = 29;
            }
            img_carro.Location = new Point(px,py);
            px=img_carro.Location.X;
        }
    }
}
