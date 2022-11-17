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
    public partial class F_FilhoCheckBox : Form
    {
        public F_checkBox f_checkBox;
        public F_FilhoCheckBox()
        {
            InitializeComponent();
            f_checkBox = Application.OpenForms["F_checkBox"] as F_checkBox;         //OpenForms
            cb_carro.Checked = f_checkBox.cb_carro.Checked;
            cb_aviao.Checked = f_checkBox.cb_aviao.Checked;
            cb_navio.Checked = f_checkBox.cb_navio.Checked;
            cb_onibus.Checked = f_checkBox.cb_onibus.Checked;
        }

        private void cb_carro_CheckedChanged(object sender, EventArgs e)
        {
            f_checkBox.cb_carro.Checked = cb_carro.Checked;
        }

        private void cb_aviao_CheckedChanged(object sender, EventArgs e)
        {
            f_checkBox.cb_aviao.Checked = cb_aviao.Checked;
        }

        private void cb_navio_CheckedChanged(object sender, EventArgs e)
        {
            f_checkBox.cb_navio.Checked = cb_navio.Checked;
        }

        private void cb_onibus_CheckedChanged(object sender, EventArgs e)
        {
            f_checkBox.cb_onibus.Checked = cb_onibus.Checked;
        }
    }
}
