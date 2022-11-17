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
    public partial class F_NumericUpDown : Form
    {
        public F_NumericUpDown()
        {
            InitializeComponent();
        }

        private void tb_incremetador_TextChanged(object sender, EventArgs e)
        {
            try
            {
                nud_contador.Increment = Convert.ToDecimal(tb_incremetador.Text);
            }
            catch
            {
                MessageBox.Show("Valor de incrementação invalido!");
            }
            
        }
    }
}
