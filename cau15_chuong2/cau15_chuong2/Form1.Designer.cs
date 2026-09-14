namespace cau15_chuong2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblColor = new Label();
            dudColor = new DomainUpDown();
            lblSize = new Label();
            nudSize = new NumericUpDown();
            lblSampleText = new Label();
            ((System.ComponentModel.ISupportInitialize)nudSize).BeginInit();
            SuspendLayout();
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(62, 52);
            lblColor.Text = "Color:";
            // 
            // dudColor
            // 
            dudColor.Items.Add("Red");
            dudColor.Items.Add("Green");
            dudColor.Items.Add("Blue");
            dudColor.Items.Add("Purple");
            dudColor.Items.Add("Orange");
            dudColor.Location = new Point(200, 48);
            dudColor.Size = new Size(150, 27);
            dudColor.Text = "Green";
            dudColor.SelectedItemChanged += dudColor_SelectedItemChanged;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(62, 112);
            lblSize.Text = "Size:";
            // 
            // nudSize
            // 
            nudSize.Location = new Point(200, 108);
            nudSize.Maximum = new decimal(new int[] { 72, 0, 0, 0 });
            nudSize.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            nudSize.Size = new Size(150, 27);
            nudSize.Value = new decimal(new int[] { 16, 0, 0, 0 });
            nudSize.ValueChanged += nudSize_ValueChanged;
            // 
            // lblSampleText
            // 
            lblSampleText.AutoSize = true;
            lblSampleText.Font = new Font("Segoe UI", 16F);
            lblSampleText.Location = new Point(132, 190);
            lblSampleText.Text = "Sample Text";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 290);
            Controls.Add(lblSampleText);
            Controls.Add(nudSize);
            Controls.Add(lblSize);
            Controls.Add(dudColor);
            Controls.Add(lblColor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ex1 - DomainUpDown and NumericUpDown";
            ((System.ComponentModel.ISupportInitialize)nudSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblColor;
        private DomainUpDown dudColor;
        private Label lblSize;
        private NumericUpDown nudSize;
        private Label lblSampleText;

        #endregion
    }
}
