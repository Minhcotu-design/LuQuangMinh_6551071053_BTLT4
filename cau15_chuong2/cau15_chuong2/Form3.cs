namespace cau15_chuong2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            processingTimer.Start();
        }

        private void processingTimer_Tick(object? sender, EventArgs e)
        {
            if (progressIndicator.Value < progressIndicator.Maximum)
                progressIndicator.Value++;
            else
                progressIndicator.Value = 0;

            lblPercentage.Text = $"Percentage Complete: {progressIndicator.Value}%";
        }

        private void trackBarSpeed_Scroll(object? sender, EventArgs e)
        {
            processingTimer.Interval = Math.Max(10, 510 - trackBarSpeed.Value * 5);
        }
    }
}
