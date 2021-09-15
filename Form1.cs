using System;
using System.Data;
using System.Windows.Forms;

namespace OLCalc
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            Button CalBtn = ((Button)sender);
            textBox1.Text = CalBtn.Text != "=" ? textBox1.Text + CalBtn.Text : dt.Compute(textBox1.Text, "").ToString();
        }
    }
}
