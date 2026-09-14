namespace cau15_chuong2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object? sender, EventArgs e)
        {
            MessageBoxButtons buttons = radioOk.Checked ? MessageBoxButtons.OK
                : radioOkCancel.Checked ? MessageBoxButtons.OKCancel
                : radioRetryCancel.Checked ? MessageBoxButtons.RetryCancel
                : radioYesNo.Checked ? MessageBoxButtons.YesNo
                : MessageBoxButtons.YesNoCancel;

            MessageBoxIcon icon = radioError.Checked ? MessageBoxIcon.Error
                : radioInformation.Checked ? MessageBoxIcon.Information
                : radioQuestion.Checked ? MessageBoxIcon.Question
                : radioWarning.Checked ? MessageBoxIcon.Warning
                : MessageBoxIcon.None;

            MessageBox.Show(txtMessage.Text, txtCaption.Text, buttons, icon);
        }

        private void SetTabAlignment(object? sender, EventArgs e)
        {
            if (radioLeft.Checked)
                tabOptions.Alignment = TabAlignment.Left;
            else if (radioRight.Checked)
                tabOptions.Alignment = TabAlignment.Right;
            else if (radioBottom.Checked)
                tabOptions.Alignment = TabAlignment.Bottom;
            else
                tabOptions.Alignment = TabAlignment.Top;
        }
    }
}
