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
    public partial class F_principal : Form
    {
        public int num;
        public F_principal()
        {
            InitializeComponent();
            num = 0;
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (tb_informe.Text == "")
            {
                MessageBox.Show("Informe um veiculo!");
                tb_informe.Focus();
                return;
            }
            else
            {
                tb_lista.Text+=tb_informe.Text+", ";
                tb_informe.Clear();
                tb_informe.Focus();
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_lista.Clear();
            tb_informe.Clear();
            tb_informe.Focus();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            F_secundario f_Secundario = new F_secundario(tb_lista.Text,this);         //permitir filho manipular pai
            f_Secundario.ShowDialog();
        }

        private void btn_variavel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }
        private void MenuNotificacoes_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name.ToString() == "tsmi_fechar")
            {
                this.Close();
            }
            else if (e.ClickedItem.Name.ToString() == "tsmi_restaurar")
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (e.ClickedItem.Name.ToString() == "tsmi_mensagem")
            {
                MessageBox.Show("Programa do Luan");
            }
        }

        private void mn_componentes_checkbox_Click(object sender, EventArgs e)
        {
            F_checkBox f_checkBox = new F_checkBox();
            f_checkBox.ShowDialog();
        }

        private void mn_Componentes_CheckedListBox_Click(object sender, EventArgs e)
        {
            F_CheckedListBox f_CheckedListBox = new F_CheckedListBox();
            f_CheckedListBox.ShowDialog();
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ComboBox f_ComboBox = new F_ComboBox();
            f_ComboBox.ShowDialog();
        }

        private void mn_componentes_dateTimePicker_Click(object sender, EventArgs e)
        {
            F_DateTimePicker f_DateTimePicker = new F_DateTimePicker();
            f_DateTimePicker.ShowDialog();
        }

        private void linkLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_LinkLabel f_LinkLabel = new F_LinkLabel();    
            f_LinkLabel.ShowDialog();
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListBox f_ListBox = new F_ListBox();  
            f_ListBox.ShowDialog();
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListView f_ListView = new F_ListView();
            f_ListView.ShowDialog();
        }

        private void maskedTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_MaskedTextBox f_MaskedTextBox = new F_MaskedTextBox();
            f_MaskedTextBox.ShowDialog();
        }

        private void monthCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_MonthCalendar f_MonthCalendar = new F_MonthCalendar();
            f_MonthCalendar.ShowDialog();
        }

        private void numericUpDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NumericUpDown fnud = new F_NumericUpDown();
            fnud.ShowDialog();
        }

        private void pictureBoxArquivosDeRecursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_PictureBox_ArquivoDeRecursos fpb = new F_PictureBox_ArquivoDeRecursos();
            fpb.ShowDialog();
        }

        private void progressBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ProgressBar f_ProgressBar = new F_ProgressBar();
            f_ProgressBar.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_RadioButton f_RadioButton = new F_RadioButton();
            f_RadioButton.ShowDialog();
        }

        private void trackBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_TrackBar f_TrackBar = new F_TrackBar();
            f_TrackBar.ShowDialog();
        }

        private void treeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_TreeView f_TreeView = new F_TreeView();
            f_TreeView.ShowDialog();
        }

        private void webBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_WebBrowser f_WebBrowser = new F_WebBrowser();
            f_WebBrowser.ShowDialog();
        }

        private void splitContainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_SplitContainer f_splitContainer = new F_SplitContainer();
            f_splitContainer.ShowDialog();
        }

        private void tabControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_tabControl f_TabControl = new F_tabControl();
            f_TabControl.ShowDialog();

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            F_TableLayoutPanel f_TableLayoutPanel = new F_TableLayoutPanel();
            f_TableLayoutPanel.ShowDialog();
        }

        private void toolStripContainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ToolStripContainer f_ToolStripContainer = new F_ToolStripContainer();
            f_ToolStripContainer.ShowDialog();
        }

        private void backgroundWorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_BackgroundWorker f_BackgroundWorker = new F_BackgroundWorker();
            f_BackgroundWorker.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            F_Timer f_timer = new F_Timer();
            f_timer.ShowDialog();
        }
    }
}
