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
    public partial class F_checkBox : Form
    {
        List<CheckBox> transp = new List<CheckBox>();
        public F_checkBox()
        {
            InitializeComponent();
            transp.Add(cb_carro);
            transp.Add(cb_aviao);
            transp.Add(cb_navio);
            transp.Add(cb_onibus);
        }

        private void btn_transportes_marcados_Click(object sender, EventArgs e)
        {
            String txt = "";
            //if (cb_carro.Checked)                             //Forma maior
            //{
            //    txt += cb_carro.Text + ", ";
            //}
            //if (cb_aviao.Checked)
            //{
            //    txt += cb_aviao.Text + ", ";
            //}
            //if (cb_navio.Checked)
            //{
            //    txt += cb_navio.Text + ", ";
            //}
            //if (cb_onibus.Checked)
            //{
            //    txt += cb_onibus.Text + ", ";
            //}

            foreach(CheckBox t in transp)                       //Forma mais compacta
            {
                if (t.Checked)
                {
                    txt += t.Text + ", ";
                }
            }
            MessageBox.Show(txt);
        }

        private void cb_patinete_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_patinete.Checked)
            {
                MessageBox.Show("Patinete Marcado");
            }
        }

        private void btn_form_filho_Click(object sender, EventArgs e)
        {
            F_FilhoCheckBox f_FilhoCheckBox = new F_FilhoCheckBox();
            f_FilhoCheckBox.ShowDialog();
        }
    }
}
