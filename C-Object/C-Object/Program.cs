using System;

namespace C_Object
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text = LoginInfo.Member.GetName();
        }

        private void ExecutionButton_Click(object sender, EventArgs e)
        {

            if(SilverRadioButton.Checked)
            {
                LoginInfo.Member = new SilverMember();
            }
            else if(GoldRadioButton.Checked)
            {
                LoginInfo.Member = new GoldMember();

            }
            else (PlatinumRadioButton.Checked)
            {
                LoginInfo.Member = new PlatinumrMember();
            }

            using (var f = new Form1())
            {
                f.ShowDialog();
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

            ResultLabel.Text = (value * LoginInfo.member.Rate).ToString();
        }
    }
}
