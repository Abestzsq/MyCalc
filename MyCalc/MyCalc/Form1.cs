using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxop1.Text);
            var y = int.Parse(this.textBoxop2.Text);
            var z = x + y;
            this.labelresult.Text = z.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxop1.Text);
            var y = int.Parse(this.textBoxop2.Text);
            var z = x - y;
            this.labelresult.Text = z.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxop1.Text);
            var y = int.Parse(this.textBoxop2.Text);
            var z = x *y;
            this.labelresult.Text = z.ToString();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxop1.Text);
            var y = int.Parse(this.textBoxop2.Text);
            if (y != 0)
            {
                var z = x / y;
                this.labelresult.Text = z.ToString();
            }
            else
            {
                this.labelresult.Text = "0不能作为除数";
            }
        }
    }
}
