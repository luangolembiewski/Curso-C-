using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Aula83_EditorDeTexto
{
    public partial class Form1 : Form
    {
        StringReader leitura = null;           //usado na impressão
        public Form1()
        {
            InitializeComponent();
        }

        //Funções
        #region Arquivo
        private void novo()
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }
        private void salvar()
        {
            try
            {
                if(this.saveFileDialog1.ShowDialog()== DialogResult.OK)
                {
                    FileStream arquivo = new FileStream(saveFileDialog1.FileName,FileMode.OpenOrCreate,FileAccess.Write); //criou o arquivo
                    StreamWriter escritor = new StreamWriter(arquivo);                                                    //criou o escritor
                    escritor.Flush();                                           //Atualizar o buffer
                    escritor.BaseStream.Seek(0,SeekOrigin.Begin);               //Informou de onde começar a escrever no arquivo
                    escritor.Write(richTextBox1.Text);                          //Informa oque vai ser escrito
                    escritor.Flush();                                           //Atualizar o buffer
                    escritor.Close();                                           //Fechar a escrita
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na gravação: " + ex.Message, "Erro ao gravar!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void imprimir()
        {
            printDialog1.Document = printDocument1;                   //setar o documento de impressão
            string txt = this.richTextBox1.Text;
            leitura = new StringReader(txt);
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }
        #endregion Arquivo

        #region Editar
        private void abrir()
        {
            this.openFileDialog1.Title = "Abrir Arquivo";
            openFileDialog1.InitialDirectory = @"C:\\Users\\Luan\\Documents\\C#\\Aulas\\Parte 2 (Grafica)\\Aula83-EditorDeTexto\";
            openFileDialog1.Filter = "(*.TXT)|*.TXT";       //Filtro do que abrir
            
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    FileStream arquivo = new FileStream(saveFileDialog1.FileName, FileMode.Open, FileAccess.Read); //criou o arquivo
                    StreamReader leitor = new StreamReader(arquivo);            //criou o leitor
                    leitor.BaseStream.Seek(0,SeekOrigin.Begin);                 //Informou de onde começar a ler no arquivo
                    this.richTextBox1.Text = "";                                //Limpa o richTextBox
                    string linha = leitor.ReadLine();                           //lê a primeira linha do arquivo e joga na variavel
                    while (linha != null)                                       //Enquanto houver coisa na linha
                    {
                        this.richTextBox1.Text += linha + "\n";                 //Passa o valor da linha
                        linha = leitor.ReadLine();                              //Informa proxima linha            
                    }
                    leitor.Close();                                             //Fecha leitura

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro de leitura: " + ex.Message, "Erro ao Ler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void copiar()
        {
            if(richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }
        private void colar()
        {
            richTextBox1.Paste();
        }
        #endregion Editar

        #region Formatar
        private void negrito()
        {
            string nomeDaFonte = null;
            float tamanhoDaFonte = 0;
            bool n,i,s = false;
            nomeDaFonte = richTextBox1.Font.Name;
            tamanhoDaFonte = richTextBox1.Font.Size;
            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;

            richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Regular);
            if (n==false)
            {
                if (i == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if(i==false& s == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Bold | FontStyle.Underline);
                }
                else if (i == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Bold | FontStyle.Italic);
                }
                else if (i == false & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Bold);
                }

            }
            else
            {
                if (i == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Italic | FontStyle.Underline);
                }
                else if (i == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Underline);
                }
                else if (i == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Italic);
                }
            }
        }
        private void italico()
        {
            string nomeDaFonte = null;
            float tamanhoDaFonte = 0;
            bool n, i, s = false;
            nomeDaFonte = richTextBox1.Font.Name;
            tamanhoDaFonte = richTextBox1.Font.Size;
            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;

            richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Regular);
            if (i == false)
            {
                if (n == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Bold | FontStyle.Italic);
                }
                else if (n == false & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Italic);
                }

            }
            else
            {
                if (n == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Bold | FontStyle.Underline);
                }
                else if (n == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Underline);
                }
                else if (n == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Bold);
                }
            }
        }
        private void sublinhado()
        {
            string nomeDaFonte = null;
            float tamanhoDaFonte = 0;
            bool n, i, s = false;
            nomeDaFonte = richTextBox1.Font.Name;
            tamanhoDaFonte = richTextBox1.Font.Size;
            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;

            richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Regular);
            if (s == false)
            {
                if (i == true & n == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (i == false & n == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Bold | FontStyle.Underline);
                }
                else if (i == true & n == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Underline | FontStyle.Italic);
                }
                else if (i == false & n == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Underline);
                }

            }
            else
            {
                if (i == true & n == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Italic | FontStyle.Bold);
                }
                else if (i == false & n == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Bold);
                }
                else if (i == true & n == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Italic);
                }
            }
        }
        #endregion Formatar

        #region Alinhamento
        private void alinharEsquerda()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }
        private void alinharDireita()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }
        private void alinharCentro()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }
        #endregion Alinhamento


        //atribuições
        #region Arquivo
        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            novo();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            novo();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void btn_abrir_Click(object sender, EventArgs e)
        {
            abrir();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir();
        }
        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imprimir();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float linhasPagina = 0;
            float posY = 0;
            int cont = 0;
            float margemEsquerda = e.MarginBounds.Left - 50;
            float margemSuperior = e.MarginBounds.Top - 50;
            if (margemEsquerda < 5)
            {
                margemEsquerda = 20;
            }
            if (margemSuperior < 5)
            {
                margemSuperior = 20;
            }
            string linha = null;
            Font fonte = this.richTextBox1.Font;
            SolidBrush pincel = new SolidBrush(Color.Black);
            linhasPagina = e.MarginBounds.Height / fonte.GetHeight(e.Graphics);     //Calcula qtd de linhas cabem na pagina atraves da fonte
            linha = leitura.ReadLine();
            while(cont < linhasPagina)
            {
                posY = (margemSuperior + (cont * fonte.GetHeight(e.Graphics)));
                e.Graphics.DrawString(linha,fonte,pincel,margemEsquerda,posY,new StringFormat());  //desenha linha
                cont++;
                linha = leitura.ReadLine();
            }
            if(linha!= null)                //verifica se ja acabou 
            {
                e.HasMorePages = true;      //adiciona outra pagina
            }
            else
            {
                e.HasMorePages = false;
            }
            pincel.Dispose();
        }
        #endregion Arquivo

        #region Editar
        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copiar();
        }

        private void btn_copiar_Click(object sender, EventArgs e)
        {
            copiar();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colar();
        }

        private void btn_colar_Click(object sender, EventArgs e)
        {
            colar();
        }
        #endregion Editar

        #region Formatar
        private void btn_negrito_Click(object sender, EventArgs e)
        {
            negrito();
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            negrito();
        }

        private void btn_italico_Click(object sender, EventArgs e)
        {
            italico();
        }

        private void italicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            italico();
        }

        private void btn_sublinhado_Click(object sender, EventArgs e)
        {
            sublinhado();
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sublinhado();
        }


        #endregion Formatar

        #region Alinhamento
        private void btn_esquerda_Click(object sender, EventArgs e)
        {
            alinharEsquerda();
        }
        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alinharEsquerda();
        }

        private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alinharDireita();
        }

        private void btn_direita_Click(object sender, EventArgs e)
        {
            alinharDireita();
        }

        private void centralizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alinharCentro();
        }
        private void btn_centro_Click(object sender, EventArgs e)
        {
            alinharCentro();
        }

        #endregion Alinhamento

        
    }
}
