namespace Calculator
{
    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal left = decimal.Parse(eLeft.Text);
            decimal right = decimal.Parse(eRight.Text);
            lbResult.Text = string.Format("{0}", left + right);
        }
    }
}
