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
    public partial class F_ListBox : Form
    {
        List<string> carros = new List<string>();
        public F_ListBox()
        {
            InitializeComponent();
            carros.Add("HRV");
            carros.Add("Focus");
            carros.Add("Fusion");

            lb_carros.DataSource=carros;
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if(tb_carro.Text != "")
            {
                carros.Add(tb_carro.Text);
                atualizarListaCarros(lb_carros, carros);
                tb_carro.Clear();
            }
            else
            {
                MessageBox.Show("Informe um carro!");
                tb_carro.Focus();
            }
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            carros.RemoveAt(lb_carros.SelectedIndex);
            atualizarListaCarros(lb_carros, carros);
        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            tb_carro.Text = carros[lb_carros.SelectedIndex];
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            carros.Clear();
            atualizarListaCarros(lb_carros,carros);
        }
        private void atualizarListaCarros(ListBox lb,List<string>l)
        {
            lb.DataSource = null;
            lb.DataSource = l;
        }
    }
}
