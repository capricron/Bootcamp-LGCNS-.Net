using System;
using System.Windows.Forms;

namespace SimpleFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You entered: " + textBox1.Text);
        }
    }
}
