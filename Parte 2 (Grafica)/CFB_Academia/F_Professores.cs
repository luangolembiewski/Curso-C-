using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFB_Academia
{
    public partial class F_Professores : Form
    {
        public F_Professores()
        {
            InitializeComponent();
        }
        private void F_Professores_Load(object sender, EventArgs e)
        {
            AtualizaDGV();
        }
        private void AtualizaDGV()
        {
            string vquery = @"
                    SELECT  
                        tbp.N_IDPROFESSOR as 'ID',
                        tbp.T_NOMEPROFESSOR as 'Nome',
                        tbp.T_TELEFONE as 'Telefone'
                    FROM    
                        tb_professores as 'tbp' 
                    ORDER BY
                        N_IDPROFESSOR
                    ";
            dgv_professores.DataSource = Banco.dql(vquery);
        }

        private void dgv_professores_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_professores.SelectedRows.Count > 0)
            {
                tb_id.Text = dgv_professores.SelectedRows[0].Cells[0].Value.ToString();
                tb_professor.Text = dgv_professores.SelectedRows[0].Cells[1].Value.ToString();
                mtb_telefone.Text = dgv_professores.SelectedRows[0].Cells[2].Value.ToString();
            }
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_id.Clear();
            tb_professor.Clear();
            mtb_telefone.Clear();
            tb_professor.Focus();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string vquery;
            if (tb_id.Text == "")
            {
                vquery = $@"
                    INSERT INTO
                        tb_professores(T_NOMEPROFESSOR,T_TELEFONE)
                    VALUES
                        ('{tb_professor.Text}','{mtb_telefone.Text}')
                ";
                Banco.dml(vquery);
            }else
            {
                vquery = $@"
                    UPDATE tb_professores SET 
                        T_NOMEPROFESSOR='{tb_professor.Text}',
                        T_TELEFONE='{mtb_telefone.Text}'
                    WHERE N_IDPROFESSOR={tb_id.Text}
                ";
                Banco.dml(vquery);
            }
            AtualizaDGV();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (dgv_professores.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Confirma Exclusão?", "Excluir", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string vquery = $@"
                    DELETE FROM
                        tb_professores
                    WHERE    
                        N_IDPROFESSOR = {tb_id.Text} ";
                    Banco.dml(vquery);
                    dgv_professores.Rows.Remove(dgv_professores.CurrentRow);
                    MessageBox.Show("Professor deletado!"); 
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro para excluir");
            }
            
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
