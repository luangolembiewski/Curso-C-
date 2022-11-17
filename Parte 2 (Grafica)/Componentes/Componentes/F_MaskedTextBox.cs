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
    public partial class F_MaskedTextBox : Form
    {
        public F_MaskedTextBox()
        {
            InitializeComponent();
        }

        private void btn_mostrarSenha_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mtb_senha.Text);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
            else
            {
                maskedTextBox1.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
            MessageBox.Show(maskedTextBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(maskedTextBox2.Text);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(maskedTextBox3.Text);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                mtb_senha.PasswordChar = '\0';
            }
            else
            {
                mtb_senha.PasswordChar = '*';
            }
        }

    }
}
