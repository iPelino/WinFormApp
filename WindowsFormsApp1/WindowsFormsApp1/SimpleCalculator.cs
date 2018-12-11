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
    public partial class SimpleCalculator : Form
    {
        

        public SimpleCalculator()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var firstNumber = Convert.ToDouble(textBoxFirstNumber.Text) ;
            var secondNumber = Convert.ToDouble(textBoxSecondNumber.Text);
            textBoxResult.Text = (firstNumber + secondNumber).ToString();

            //textBoxResult.Text = Calculator.Add(firstNumber, secondNumber);
        }
    }
}
