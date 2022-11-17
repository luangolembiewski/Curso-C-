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
    public partial class F_tabControl : Form
    {
        public F_tabControl()
        {
            InitializeComponent();
        }

        private void btn_addTab_Click(object sender, EventArgs e)
        {
            if(tb_novaTab.Text != "")
            {
                TabPage pagina = new TabPage();
                pagina.Text = tb_novaTab.Text;
                pagina.Name = "tb_" + tb_novaTab.Text;
                pagina.TabIndex = tc_tabs.TabPages.Count;
                tc_tabs.TabPages.Add(pagina);
                tb_novaTab.Clear();
                definirMaximo();
            }
            else
            {
                MessageBox.Show("Digite o nome da nova página!");
                tb_novaTab.Focus();
            }
        }

        private void btn_removerTab_Click(object sender, EventArgs e)
        {
            tc_tabs.TabPages.Remove(tc_tabs.SelectedTab);
            definirMaximo();
        }

        private void btn_posicaoTab_Click(object sender, EventArgs e)
        {
            tc_tabs.SelectedIndex = Int32.Parse(numericUpDown1.Value.ToString());
            
        }
        private void definirMaximo()
        {
            numericUpDown1.Maximum = tc_tabs.TabPages.Count;
        }
    }
}
