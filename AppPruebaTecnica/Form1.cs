﻿using AppPruebaTecnica.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPruebaTecnica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEstados_Click(object sender, EventArgs e)
        {
            frmEstados frm = new frmEstados();
            frm.Show();
        }
    }
}
