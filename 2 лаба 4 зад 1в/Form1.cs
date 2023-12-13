using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_лаба_4_зад_1в
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y;

            if (x > 3) y = 1 / (x * x * x + 1);
            else y = x * x - 3 * x + 9;
            label2.Text = "y = " + Convert.ToString(y);
        }
    }
}
