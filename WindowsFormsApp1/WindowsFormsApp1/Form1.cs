using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You just clicked a button");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var firstName = textBoxFirstName.Text;
            MessageBox.Show(firstName == "" ? "Please Enter your first name" : firstName);
        }
    }
}
