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
    public partial class F_LinkLabel : Form
    {
        public F_LinkLabel()
        {
            InitializeComponent();
            ll_multiplos.Links.Add(0,6,"www.google.com");
            ll_multiplos.Links.Add(9, 8, "www.facebook.com");
            ll_multiplos.Links.Add(20, 7, "www.youtube.com");

            ll_multiplos.Links[2].Enabled=false;                                    //Desabilitar
        }

        private void ll_youtube_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://youtube.com");

            LinkLabel ll = sender as LinkLabel;
            ll.LinkVisited = true;
        }

        private void ll_calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void ll_multiplos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            e.Link.Visited = true;
        }
    }
}
