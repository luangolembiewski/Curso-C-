using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Componentes
{
    public partial class F_ProgressBar : Form
    {
        public F_ProgressBar()
        {
            InitializeComponent();
        }

        private void btn_definir_Click(object sender, EventArgs e)
        {
            try
            {
                int txt = int.Parse(textBox1.Text);
                int pgbMin = progressBar1.Minimum;
                int pgbMax = progressBar1.Maximum;
                if (txt >=  pgbMin & txt <= pgbMax)
                {
                    progressBar1.Value = int.Parse(textBox1.Text);
                }
                else
                {
                    MessageBox.Show("Valor informado deve estar entre 0 e 100!");
                }
            }
            catch
            {
                MessageBox.Show("Valor informado é inválido");
            }
            
        }

        private void btn_preencher_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            try
            {
                progressBar1.Maximum = int.Parse(textBox2.Text);
            }
            catch 
            {
                progressBar1.Maximum = 100;
            }
            for (int i=0;i<=progressBar1.Maximum;i+=10)
            {
                label1.Text = i.ToString();
                progressBar1.Value=i;
                Thread.Sleep(1000);
            }
        }

        
    }
}
