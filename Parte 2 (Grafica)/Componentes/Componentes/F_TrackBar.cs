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
    public partial class F_TrackBar : Form
    {
        public F_TrackBar()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            tb_valor.Text = trackBar1.Value.ToString();
            label1.Text = trackBar1.Value.ToString();
        }

        private void btn_definir_Click(object sender, EventArgs e)
        {
            if (int.Parse(tb_valor.Text) < trackBar1.Minimum)
            {
                MessageBox.Show("Valor deve ser maior que: " + trackBar1.Minimum);
            }
            if (int.Parse(tb_valor.Text) > trackBar1.Maximum)
            {
                MessageBox.Show("Valor deve ser menor que: " + trackBar1.Maximum);
            }
            else
            {
                trackBar1.Value = int.Parse(tb_valor.Text);
                label1.Text = trackBar1.Value.ToString();
            }
        }

        private void F_TrackBar_Load(object sender, EventArgs e)
        {
            tb_valor.Text = trackBar1.Value.ToString();
            label1.Text = trackBar1.Value.ToString();
        }
    }
}
