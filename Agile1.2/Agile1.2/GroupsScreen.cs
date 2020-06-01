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
    public partial class GroupsScreen : Form
    {
        public GroupsScreen()
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

        private void GroupBtn_Click(object sender, EventArgs e)
        {
            ExampleGroupScreen myForm = new ExampleGroupScreen();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
