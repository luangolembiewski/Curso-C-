using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud
{
    public partial class F_Cadastro : Form
    {
        List<Pessoa> pessoaList = new List<Pessoa>();
        Pessoa pessoa;
        string[] pr = new string[4];
        public F_Cadastro()
        {
            InitializeComponent();

        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (tb_nome.Text == "")
            {
                MessageBox.Show("Campo NOME não pode ser vazio!");
                tb_nome.Focus();
            }else if (dtp_nascimento.Text == "")
            {
                MessageBox.Show("Campo DT NASCIMENTO não pode ser vazio!");
                dtp_nascimento.Focus();
            }else if(tb_endereco.Text == "")
            {
                MessageBox.Show("Campo Endereço não pode ser vazio!");
                tb_endereco.Focus();
            }
            else
            {
                int id = 0;
                
                pessoa = new Pessoa(id,tb_nome.Text,dtp_nascimento.Text,tb_endereco.Text);
                pessoaList.Add(pessoa);
                tb_nome.Clear();
                dtp_nascimento.MaxDate = DateTime.Now;
                dtp_nascimento.Value = DateTime.Today;
                tb_endereco.Clear();
                atualizarLista();
            }
        }
        public void atualizarLista()
        {
            lv_lista.Items.Clear();

            foreach (Pessoa p in pessoaList)
            {
                pr[0] = p.id.ToString();
                pr[1] = p.nome;
                pr[2] = p.dtNascimento.ToString();
                pr[3] = p.endereco;
                ListViewItem l = new ListViewItem(pr);
                lv_lista.Items.Add(l);
            }
        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            try
            {
                int i = lv_lista.SelectedItems[0].Index;
                tb_nome.Text = pessoaList[i].nome;
                dtp_nascimento.Text = pessoaList[i].dtNascimento;
                tb_endereco.Text = pessoaList[i].endereco;
            }
            catch
            {
                MessageBox.Show("Selecione uma pessoa da lista!");
            }
            
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            atualizarLista();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            try
            {
                int i = lv_lista.SelectedItems[0].Index;
                pessoaList.RemoveAt(i);
                atualizarLista();
            }
            catch
            {
                MessageBox.Show("Selecione uma pessoa da lista para excluir!");
            }
        }
    }
    public class Pessoa
    {
        public int id;
        public string nome;
        public string dtNascimento;
        public string endereco;
        public Pessoa(int id, string nome, string dtNascimento, string endereco)
        {
            this.id = id;
            this.nome = nome;
            this.dtNascimento = dtNascimento;   
            this.endereco = endereco;
        }
       
    }
}
