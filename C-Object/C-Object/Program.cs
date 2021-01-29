using System;

namespace C_Object
{
    class Program
    {
        private void ShowButton_Click()
        {
            var val = GetAmount();
            ShowLabel.Text = (val * 1.08m).ToString() + "円";
        }

        private decimal GetAmount()
        {
            return 100m;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var money = new Money(GetAmount());
            ShowLabel.Text = money.TaxValue + "円";
        }
    }
}
