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
    public partial class F_CheckedListBox : Form
    {
        public F_CheckedListBox()
        {
            InitializeComponent();
        }

        private void btn_mostrarSelecionados_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach(string s in clb_transportes.CheckedItems)
            {
                txt += s+", ";
            }
            MessageBox.Show(txt);
        }

        private void btn_limparLista_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();
        }

        private void btn_resetarLista_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();
            clb_transportes.Items.Add("Carro", false);                                                  //Adicionar uma por uma
            clb_transportes.Items.Add("Avião", false);
            clb_transportes.Items.Add("Navio", false);
            clb_transportes.Items.Add("Ônibus", false);
            clb_transportes.Items.Add("Trem", false);

            clb_transportes.Items.Clear();
            List<string>tr=new List<string>() { "Carro", "Avião", "Navio", "Ônibus", "Trem" };
            clb_transportes.Items.AddRange(tr.ToArray());                                               //Adicionar varias
        }

        private void btn_adicionarTransporte_Click(object sender, EventArgs e)
        {
            if(tb_novoTransporte.Text != "")
            {
                clb_transportes.Items.Add(tb_novoTransporte.Text,false);
                tb_novoTransporte.Clear();
                tb_novoTransporte.Focus();
            }
            else
            {
                MessageBox.Show("Informe um novo Veículo!");
            }
            
        }
    }
}
