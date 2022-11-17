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
    public partial class F_PictureBox_ArquivoDeRecursos : Form
    {
        public F_PictureBox_ArquivoDeRecursos()
        {
            InitializeComponent();
        }

        private void F_PictureBox_ArquivoDeRecursos_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Resources.NomePessoa;                          //Atribuir a label a string de properties
            label2.Text = Properties.Resources.Youtube;
        }
    }
}
