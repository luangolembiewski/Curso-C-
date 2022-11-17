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
    public partial class F_secundario : Form
    {
        F_principal f_Principal;                                                    //declarar para usar na classe toda
        public F_secundario(string s,F_principal f_Principal)
        {
            InitializeComponent();
            this.f_Principal = f_Principal;
            tb_lista.Text = s;
            f_Principal.num = 15;
        }

        private void F_secundario_FormClosed(object sender, FormClosedEventArgs e)
        {
            f_Principal.tb_lista.Text = tb_lista.Text;
        }
    }
}
