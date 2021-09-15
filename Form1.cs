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
            TB_Output.Text = CalBtn.Text != "=" ? TB_Output.Text + CalBtn.Text : dt.Compute(TB_Output.Text, "").ToString();
        }
    }
}
