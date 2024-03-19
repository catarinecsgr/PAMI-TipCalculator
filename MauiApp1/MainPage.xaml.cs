namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnFifteenPercentMethod(object sender, EventArgs e)
        {
            if (AmountEntry.Text.ToString() == "")
            {
                return;
            }
            SliderTipPercent.Value = 15;
            double tip = CalculateTip();
            double amount = Double.Parse(AmountEntry.Text.ToString());
            double totalValue = tip + amount;

            TotalTip.Text = $"R$ {tip.ToString()}";
            AmountTotal.Text = $"R$ {totalValue.ToString()}";
        }

        private void OnTwentyPercentMethod(object sender, EventArgs e)
        {
            if (AmountEntry.Text.ToString() == "")
            {
                return;
            }
            SliderTipPercent.Value = 20;
            double tip = CalculateTip();
            double amount = Double.Parse(AmountEntry.Text.ToString());
            double totalValue = tip + amount;

            TotalTip.Text = $"R$ {tip.ToString()}";
            AmountTotal.Text = $"R$ {totalValue.ToString()}";
        }

        private void OnRoundDownMethod(object sender, EventArgs e)
        {
            if (AmountEntry.Text.ToString() == "")
            {
                return;
            }
            double tip = CalculateTip();
            double amount = Double.Parse(AmountEntry.Text.ToString());
            double roundedResult = Math.Floor(tip);
            double totalValue = roundedResult + amount;

            TipPercentage.Text = $"{roundedResult.ToString()}%";
            TotalTip.Text = $"R$ {roundedResult.ToString()}";
            AmountTotal.Text = $"R$ {totalValue.ToString()}";
        }

        private void OnRoundUpMethod(object sender, EventArgs e)
        {
            if (AmountEntry.Text.ToString() == "")
            {
                return;
            }
            double tip = CalculateTip();
            double amount = Double.Parse(AmountEntry.Text.ToString());
            double roundedResult = Math.Ceiling(tip);
            double totalValue = roundedResult + amount;

            TipPercentage.Text = $"{roundedResult.ToString()}%";
            TotalTip.Text = $"R$ {roundedResult.ToString()}";
            AmountTotal.Text = $"R$ {totalValue.ToString()}";
        }

        private double CalculateTip()
        {
            if (AmountEntry.Text.ToString() == "")
            {
                return 0;
            }
            double percent = SliderTipPercent.Value;
            double amount = Double.Parse(AmountEntry.Text.ToString());
            double tip = amount * (percent / 100);
            return tip;
        }

        private void OnValueChange(object sender, EventArgs e)
        {
            TipPercentage.Text = $"{Math.Round(SliderTipPercent.Value).ToString()}%";
        }
    }
}