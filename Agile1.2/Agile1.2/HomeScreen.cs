using System;
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
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void SignOutBtn_Click(object sender, EventArgs e)
        {
            LockScreen myForm = new LockScreen();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            SettingsScreen myForm = new SettingsScreen();
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

        private void GroupsBtn_Click(object sender, EventArgs e)
        {
            GroupsScreen myForm = new GroupsScreen();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
    

