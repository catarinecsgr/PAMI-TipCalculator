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
            SliderTipPercent.Value = 15;
            double tip = CalculateTip();
            double amount = Double.Parse(AmountEntry.Text.ToString());
            double totalValue = tip + amount;

            TotalTip.Text = $"R$ {tip.ToString()}";
            AmountTotal.Text = $"R$ {totalValue.ToString()}";
        }

        private void OnTwentyPercentMethod(object sender, EventArgs e)
        {
            SliderTipPercent.Value = 20;
            double tip = CalculateTip();
            double amount = Double.Parse(AmountEntry.Text.ToString());
            double totalValue = tip + amount;

            TotalTip.Text = $"R$ {tip.ToString()}";
            AmountTotal.Text = $"R$ {totalValue.ToString()}";
        }

        private void OnRoundDownMethod(object sender, EventArgs e)
        {
            double tip = CalculateTip();
            double roundedResult = Math.Floor(tip);
            double amount = Double.Parse(AmountEntry.Text.ToString());
            double totalValue = roundedResult + amount;

            TotalTip.Text = $"R$ {roundedResult.ToString()}";
            AmountTotal.Text = $"R$ {totalValue.ToString()}";
        }

        private void OnRoundUpMethod(object sender, EventArgs e)
        {
            double tip = CalculateTip();
            double roundedResult = Math.Ceiling(tip);
            double amount = Double.Parse(AmountEntry.Text.ToString());
            double totalValue = roundedResult + amount;

            TotalTip.Text = $"R$ {roundedResult.ToString()}";
            AmountTotal.Text = $"R$ {totalValue.ToString()}";
        }

        private double CalculateTip()
        {
            double percent = SliderTipPercent.Value;
            double amount = Double.Parse(AmountEntry.Text.ToString());

            double tip = amount * (percent / 100);
            return tip;
        }

        private void OnValueChange(object sender, EventArgs e)
        {
            TipPercentage.Text = $"{Math.Round(SliderTipPercent.Value).ToString()}%";
            double percent = SliderTipPercent.Value;
            double amount = Double.Parse(AmountEntry.Text.ToString());

            double tip = amount * (percent / 100);
            double totalValue = tip + amount;
            TotalTip.Text = $"R$ {tip.ToString()}";
            AmountTotal.Text = $"R$ {totalValue.ToString()}";
        }
    }
}