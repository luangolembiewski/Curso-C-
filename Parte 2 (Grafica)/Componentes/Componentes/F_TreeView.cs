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
    public partial class F_TreeView : Form
    {
        public F_TreeView()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textBox2.Clear();
            textBox1.Text = treeView1.SelectedNode.Text;
            if(treeView1.SelectedNode.Tag != null)
            {
                textBox2.Text = treeView1.SelectedNode.Tag.ToString();
            }
            
        }
        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            TreeNode tnPai = treeView1.Nodes.Add(textBox1.Text);
            tnPai.Name=textBox1.Text.ToLower();
            TreeNode tnFilho = tnPai.Nodes.Add(textBox2.Text);
            tnFilho.Name=textBox2.Text.ToLower();
        }
        private void btn_remover_Click(object sender, EventArgs e)
        {
            try
            {
                treeView1.Nodes.Remove(treeView1.SelectedNode);

            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao remover nó. "+ex.Message);
            }
        }
    }
}
