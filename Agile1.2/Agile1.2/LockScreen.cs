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
    public partial class LockScreen : Form
    {
        public LockScreen()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            HomeScreen myForm = new HomeScreen();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}

