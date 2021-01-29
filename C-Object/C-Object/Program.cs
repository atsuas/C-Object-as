using System;

namespace C_Object
{
    public partial class Program : Program1
    {
        public Program()
        {
            InitializeComponent();
        }

        private void ExecutionButton_Click(object sender, EventArgs e)
        {
            var value = Convert.ToInt32(InputTextBox.Text);
            if(SilverRadioButton.Checked)
            {
                ResultLabel.Text = value.ToString();
                return;
            }

            if(GoldRadioButton.Checked)
            {
                ResultLabel.Text = (value * 0.8f).ToString();
                return;
            }

            if(PlatinumRadioButton.Checked)
            {
                ResultLabel.Text = (value * 0.6f).ToString();
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var value = Convert.ToInt32(InputTextBox.Text);

            IMember menber;
            if (SilverRadioButton.Checked)
            {
                menber = new SilverMember();
            }
            else if (GoldRadioButton.Checked)
            {
                menber = new GoldrMember();
            }
            else
            {
                menber = new PlatinumMember();
            }

            ResultLabel.Text = (value * member.Rate).ToString();
        }
    }
}
