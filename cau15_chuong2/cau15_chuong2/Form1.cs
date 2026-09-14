namespace cau15_chuong2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dudColor_SelectedItemChanged(object? sender, EventArgs e)
        {
            DomainUpDown dudColor = (DomainUpDown)sender!;
            lblSampleText.ForeColor = Color.FromName(dudColor.Text);
        }

        private void nudSize_ValueChanged(object? sender, EventArgs e)
        {
            NumericUpDown nudSize = (NumericUpDown)sender!;
            lblSampleText.Font = new Font(lblSampleText.Font.FontFamily, (float)nudSize.Value);
        }
    }
}
