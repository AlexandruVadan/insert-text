using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3ex5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Label lbl = new Label();
            lbl.Text = textBox1.Text.ToString();

            int x,y;
            x = Convert.ToInt32(textBox2.Text);
            y = Convert.ToInt32(textBox3.Text);
            
            lbl.Location = new System.Drawing.Point(x, y);

            this.Controls.Add(lbl);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
