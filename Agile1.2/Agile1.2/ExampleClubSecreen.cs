﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agile1._2
{
    public partial class ExampleClubSecreen : Form
    {
        public ExampleClubSecreen()
        {
            InitializeComponent();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            HomeScreen myForm = new HomeScreen();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void ClubsBtn_Click(object sender, EventArgs e)
        {
            ClubsScreen myForm = new ClubsScreen();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
