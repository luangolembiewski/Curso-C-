using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Componentes
{
    public partial class F_ComboBox : Form
    {
        public F_ComboBox()
        {
            InitializeComponent();
        }

        private void btn_mostrarSelecionado_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_transportes.Text);
        }

        private void btn_limparElementos_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Clear();
        }

        private void btn_resetarElementos_Click(object sender, EventArgs e)
        {
            List<string>ls=new List<string>() { "Carro","Avião","Navio","Ônibus","Trem"};
            cb_transportes.Items.Clear();
            cb_transportes.Items.AddRange(ls.ToArray());
        }

        private void cb_transportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_transporte.Text = cb_transportes.Text;
        }

        private void btn_adicionarVeiculo_Click(object sender, EventArgs e)
        {
            if (tb_transporte.Text != "")
            {
                if (!cb_transportes.Items.Contains(tb_transporte.Text))
                {
                    cb_transportes.Items.Add(tb_transporte.Text);
                    tb_transporte.Clear();
                    tb_transporte.Focus();
                }
                else
                {
                    MessageBox.Show("Veiculo já existe!");
                    tb_transporte.Clear();
                    tb_transporte.Focus();
                }
                
            }
        }
    }
}
