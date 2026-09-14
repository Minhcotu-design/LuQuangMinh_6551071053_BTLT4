namespace cau15_chuong2
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblProgress = new Label();
            progressIndicator = new ProgressBar();
            lblPercentage = new Label();
            separator = new Label();
            lblSpeed = new Label();
            trackBarSpeed = new TrackBar();
            processingTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)trackBarSpeed).BeginInit();
            SuspendLayout();
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Location = new Point(28, 28);
            lblProgress.Text = "Progress Indicator:";
            // 
            // progressIndicator
            // 
            progressIndicator.Location = new Point(28, 58);
            progressIndicator.Size = new Size(320, 29);
            progressIndicator.Maximum = 100;
            progressIndicator.Value = 45;
            // 
            // lblPercentage
            // 
            lblPercentage.AutoSize = true;
            lblPercentage.Location = new Point(28, 103);
            lblPercentage.Text = "Percentage Complete: 45%";
            // 
            // separator
            // 
            separator.BorderStyle = BorderStyle.Fixed3D;
            separator.Location = new Point(10, 145);
            separator.Size = new Size(355, 2);
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.Location = new Point(28, 168);
            lblSpeed.Text = "Slide the TrackBar to control processing speed:";
            // 
            // trackBarSpeed
            // 
            trackBarSpeed.Location = new Point(25, 205);
            trackBarSpeed.Maximum = 100;
            trackBarSpeed.Minimum = 1;
            trackBarSpeed.TickFrequency = 10;
            trackBarSpeed.Value = 50;
            trackBarSpeed.Size = new Size(325, 45);
            trackBarSpeed.Scroll += trackBarSpeed_Scroll;
            // 
            // processingTimer
            // 
            processingTimer.Interval = 255;
            processingTimer.Tick += processingTimer_Tick;
            // 
            // Form3
            // 
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 275);
            Controls.Add(trackBarSpeed);
            Controls.Add(lblSpeed);
            Controls.Add(separator);
            Controls.Add(lblPercentage);
            Controls.Add(progressIndicator);
            Controls.Add(lblProgress);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ex3 - Timer, TrackBar, and ProgressBar";
            ((System.ComponentModel.ISupportInitialize)trackBarSpeed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblProgress;
        private ProgressBar progressIndicator;
        private Label lblPercentage;
        private Label separator;
        private Label lblSpeed;
        private TrackBar trackBarSpeed;
        private System.Windows.Forms.Timer processingTimer;
    }
}
