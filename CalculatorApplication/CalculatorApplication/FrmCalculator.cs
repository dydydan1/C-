using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {

        private CalculatorClass cal;
        public FrmCalculator()
        {
            InitializeComponent();

            cal = new CalculatorClass();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtBoxInput1.Text);
            double num2 = double.Parse(txtBoxInput2.Text);

            // Subscribe first
            cal.CalculateEvent += CalculatorClass.GetSum;

            // Now call Execute (this will trigger the delegate)
            double result = cal.Execute(num1, num2);

            // Show result
            lblDisplayTotal.Text = result.ToString();

            
        }
    }
}