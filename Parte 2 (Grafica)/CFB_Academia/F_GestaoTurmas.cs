using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CFB_Academia
{
    public partial class F_GestaoTurmas : Form
    {
        string idSelecionado;
        int modo = 1; //1=Edição, 2=Inserção
        string vqueryDGV;

        public F_GestaoTurmas()
        {
            InitializeComponent();
        }
        private void F_GestaoTurmas_Load(object sender, EventArgs e)
        {
            vqueryDGV = $@"
                SELECT
                    N_IDTURMA as 'ID',
                    T_DSCTURMA as 'Turma',
                    T_DSCHORARIO as 'Horário'
                FROM
                    tb_turmas as tbt
                INNER JOIN
                    tb_horarios as tbh on tbh.N_IDHORARIO = tbt.N_IDHORARIO            
            ";
            dgv_turmas.DataSource = Banco.dql(vqueryDGV);
            dgv_turmas.Columns[0].Width = 40;
            dgv_turmas.Columns[1].Width = 200;
            dgv_turmas.Columns[2].Width = 90;

            //Popular ComboBox Professores
            string vqueryProfessores = $@"
                SELECT
                    N_IDPROFESSOR,
                    T_NOMEPROFESSOR
                FROM
                    tb_professores
                ORDER BY
                    N_IDPROFESSOR 
            ";
            cb_professor.Items.Clear();
            cb_professor.DataSource=Banco.dql(vqueryProfessores);
            cb_professor.DisplayMember = "T_NOMEPROFESSOR";
            cb_professor.ValueMember = "N_IDPROFESSOR";

            //Popular comboBox Status(Ativa=A, Paralisada=P, Cancelada=C)
            Dictionary<string, string> st = new Dictionary<string, string>();
            st.Add("A", "Ativa");
            st.Add("P", "Paralisada");
            st.Add("C", "Cancelada");
            cb_status.Items.Clear();
            cb_status.DataSource = new BindingSource (st,null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";

            //Popular ComboBox Horarios
            string vqueryHorarios = $@"
                SELECT
                    *
                FROM
                    tb_horarios
                ORDER BY
                    T_DSCHORARIO 
            ";
            cb_horario.Items.Clear();
            cb_horario.DataSource = Banco.dql(vqueryHorarios);
            cb_horario.DisplayMember = "T_DSCHORARIO";
            cb_horario.ValueMember = "N_IDHORARIO";
        }
        private void dgv_turmas_SelectionChanged(object sender, EventArgs e)
        {
            modo = 1;
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if(contLinhas> 0)
            {
                modo = 1;
                idSelecionado = dgv_turmas.Rows[dgv_turmas.SelectedRows[0].Index].Cells[0].Value.ToString();
                string vqueryCampos = $@"
                    SELECT
                        T_DSCTURMA,
                        N_IDPROFESSOR,
                        N_IDHORARIO,
                        N_MAXALUNOS,
                        T_STATUS
                    FROM
                        tb_turmas
                    WHERE           
                        N_IDTURMA={idSelecionado}
                ";
                DataTable dt = Banco.dql(vqueryCampos);
                tb_nomeTurma.Text = dt.Rows[0].Field<string>("T_DSCTURMA");
                cb_professor.SelectedValue=dt.Rows[0].Field<Int64>("N_IDPROFESSOR").ToString();
                n_maxAlunos.Value = dt.Rows[0].Field<Int64>("N_MAXALUNOS");
                cb_status.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");
                cb_horario.SelectedValue = dt.Rows[0].Field<Int64>("N_IDHORARIO");
                CalcularVagas();
            }
        }
        private string CalcularVagas()
        {
            //Calculo de Vagas
            string queryVagas = $@"
                    SELECT
                        count(N_IDALUNO) as 'contVagas'
                    FROM
                        tb_alunos
                    WHERE
                        T_STATUS='A' and N_IDTURMA={idSelecionado}
                ";
            DataTable dt;
            dt = Banco.dql(queryVagas);
            int vagas = Int32.Parse(Math.Round(n_maxAlunos.Value, 0).ToString());
            vagas -= Int32.Parse(dt.Rows[0].Field<Int64>("contVagas").ToString());
            tb_vagas.Text = vagas.ToString();
            n_maxAlunos.Minimum = (n_maxAlunos.Value - Int32.Parse(tb_vagas.Text));
            return vagas.ToString();
        }
        private void btn_novo_Click(object sender, EventArgs e)
        {
            dgv_turmas.ClearSelection();
            tb_nomeTurma.Clear();
            cb_professor.SelectedIndex = -1;
            n_maxAlunos.Value = 0;
            cb_status.SelectedIndex = -1;
            cb_horario.SelectedIndex = -1;
            tb_nomeTurma.Focus();
            modo = 2;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (modo != 0)
            {
                string queryTurma;
                string msg;
                if (modo==1)
                {
                    queryTurma = $@"
                        UPDATE
                            tb_turmas
                        SET 
                            T_DSCTURMA='{tb_nomeTurma.Text}',
                            N_IDPROFESSOR={cb_professor.SelectedValue},
                            N_IDHORARIO={cb_horario.SelectedValue},
                            N_MAXALUNOS={Int32.Parse(Math.Round(n_maxAlunos.Value, 0).ToString())},
                            T_STATUS='{cb_status.SelectedValue}'
                        WHERE
                            N_IDTURMA={idSelecionado}
                    ";
                    int linha = dgv_turmas.SelectedRows[0].Index;
                    dgv_turmas[1, linha].Value = tb_nomeTurma.Text;
                    dgv_turmas[2, linha].Value = cb_horario.Text;
                    Banco.dml(queryTurma);
                    msg = "Turma Atualizada!";
                }
                else
                {
                    queryTurma = $@"
                        INSERT INTO
                            tb_turmas
                        (T_DSCTURMA,N_IDPROFESSOR,N_IDHORARIO,N_MAXALUNOS,T_STATUS)
                        VALUES
                        ('{tb_nomeTurma.Text}',{cb_professor.SelectedValue},{cb_horario.SelectedValue},{Int32.Parse(Math.Round(n_maxAlunos.Value, 0).ToString())},'{cb_status.SelectedValue}')
                    ";
                    
                    tb_nomeTurma.Clear();
                    cb_professor.SelectedIndex = -1;
                    n_maxAlunos.Value = 0;
                    cb_status.SelectedIndex = -1;
                    cb_horario.SelectedIndex = -1;
                    
                    Banco.dml(queryTurma);
                    dgv_turmas.DataSource = Banco.dql(vqueryDGV);
                    msg = "Turma Inserida!";
                }
                tb_vagas.Text = CalcularVagas();
                MessageBox.Show(msg);
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma exclusão?", "Excluir", MessageBoxButtons.YesNo);
            if (DialogResult.Yes==res)
            {
                string queryExcluirTurma = $@"
                    DELETE
                    FROM
                        tb_turmas
                    WHERE
                        N_IDTURMA={idSelecionado}
                ";
                Banco.dml(queryExcluirTurma);
                dgv_turmas.Rows.Remove(dgv_turmas.CurrentRow);
                MessageBox.Show("Dados Excluídos!");
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            string nomeArquivo = Globais.caminho + @"\turma.pdf";    //caminho e nome do pdf
            FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

            #region aprendendo manipular PDF
            /*
                //inserir imagem
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Globais.caminho + @"\logocfb.jpg");
                logo.ScaleToFit(140f, 120f);
                logo.Alignment = Element.ALIGN_LEFT;
                //logo.SetAbsolutePosition(100f, 700f);


                string dados = "";
                //Primeiro Paragrafo
                Paragraph paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int)System.Drawing.FontStyle.Bold));
                paragrafo1.Alignment = Element.ALIGN_CENTER;
                paragrafo1.Add("CFB Cursos\n");
                paragrafo1.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Italic);
                paragrafo1.Alignment = Element.ALIGN_CENTER;
                paragrafo1.Add("Curso de C#\n");
                string texto = "youtube.com/cfbcursos";
                paragrafo1.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Italic);
                paragrafo1.Alignment = Element.ALIGN_CENTER;
                paragrafo1.Add(texto+"\n");

                //Segundo Paragrafo
                Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
                paragrafo2.Alignment = Element.ALIGN_LEFT;
                texto = "Este é o texto do segundo parágrafo\n\n";
                paragrafo2.Add(texto+"\n");

                //Inserir tabela
                PdfPTable tabela = new PdfPTable(3);//3colunas
                tabela.DefaultCell.FixedHeight = 20;

                //Opção 1 = Permite Personalizar celula
                PdfPCell celula = new PdfPCell(new Phrase("tabela de Preços"));
                celula.Colspan = 3;  //Linha 1 mesclada
                celula.Rotation = 90;
                tabela.AddCell(celula);

                celula.Phrase.Add("tabela de Preços");
                celula.Rotation = 0;
                celula.Colspan = 3;
                celula.FixedHeight = 35;
                celula.HorizontalAlignment = Element.ALIGN_CENTER;
                celula.VerticalAlignment = Element.ALIGN_MIDDLE;
                tabela.AddCell(celula);

                //Opção 2 = Cria direto sem personalização
                tabela.AddCell("Código");
                tabela.AddCell("Produto");
                tabela.AddCell("Preço");

                tabela.AddCell("01");
                tabela.AddCell("Mouse");
                tabela.AddCell("25,00");

                tabela.AddCell("02");
                tabela.AddCell("Teclado");
                tabela.AddCell("65,00");

                //Inserir Imagem dentro da tabela
                PdfPCell celulaImg = new PdfPCell();
                celulaImg.Colspan = 3;  //Linha 1 mesclada
                celulaImg.AddElement(logo);
                tabela.AddCell(celulaImg);

                doc.Open();             //Abrir documento pra inserir conteúdo
                doc.Add(logo);          //Inserir conteudo de imagem
                doc.Add(paragrafo1);    //Inserir conteudo de paragrafo
                doc.Add(paragrafo2);    //Inserir conteudo de paragrafo
                doc.Add(tabela);        //Inserir conteudo de tabela
                doc.Close();            //Fecha o documento
            */
            #endregion aprendendo manipular PDF

            string dados = "";
            Paragraph paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int)System.Drawing.FontStyle.Bold));
            paragrafo1.Alignment = Element.ALIGN_CENTER;
            paragrafo1.Add("Relatório de Turmas\n\n");

            Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int)System.Drawing.FontStyle.Bold));
            paragrafo2.Alignment = Element.ALIGN_CENTER;
            paragrafo2.Add("CFB Cursos - Curso de C#");

            PdfPTable tabela = new PdfPTable(3); // 3 colunas
            tabela.DefaultCell.FixedHeight = 20;

            tabela.AddCell("ID Turma");
            tabela.AddCell("Turma");
            tabela.AddCell("Horário");

            DataTable dtTurmas = Banco.dql(vqueryDGV);
            for(int i = 0; i < dtTurmas.Rows.Count; i++)
            {
                tabela.AddCell(dtTurmas.Rows[i].Field<Int64>("ID").ToString());
                tabela.AddCell(dtTurmas.Rows[i].Field<string>("Turma"));
                tabela.AddCell(dtTurmas.Rows[i].Field<string>("Horário"));
            }
            doc.Open();
            doc.Add(paragrafo1);
            doc.Add(tabela);
            doc.Add(paragrafo2);
            doc.Close();

            DialogResult res = MessageBox.Show("Deseja abrir o Relatorio?", "Abrir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult.Yes == res)
            {
                System.Diagnostics.Process.Start(Globais.caminho + @"\turma.pdf");
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
