﻿using NBAManager.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBAManager
{
    public partial class IntroForm : Form
    {
        public IntroForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            SelectionForm formGame = new SelectionForm();
            this.Hide();
            formGame.ShowDialog();
        }
    }
}
