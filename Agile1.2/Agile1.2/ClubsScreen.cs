using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//test
namespace Agile1._2
{
    public partial class ClubsScreen : Form
    {
        public ClubsScreen()
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

        private void ClubBtn_Click(object sender, EventArgs e)
        {
            ExampleClubSecreen myForm = new ExampleClubSecreen();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
