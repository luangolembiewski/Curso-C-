﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula61
{
    public partial class f_Principal : Form
    {
        public f_Principal()
        {
            InitializeComponent();
        }

        private void btn_copiar_Click(object sender, EventArgs e)
        {
            lb_texto.Text= tb_texto.Text;
        }
    }
}
