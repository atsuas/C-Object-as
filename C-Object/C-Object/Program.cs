using System;

namespace C_Object
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmptyClass2 c2 = new EmptyClass2();
            MessageBox.Show(c2.GetAAA().ToString());
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            int value = 0;
            if (!int.TryParse(this.Text, out value))
            {
                this.Text = "0";
            }
        }
    }
}
