namespace cau15_chuong2
{
    partial class Form2
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
            lblInstruction = new Label();
            monthCalendar = new MonthCalendar();
            lblStartDate = new Label();
            lblEndDate = new Label();
            lblLaunchDate = new Label();
            datePicker = new DateTimePicker();
            radioLongDate = new RadioButton();
            radioShortDate = new RadioButton();
            SuspendLayout();
            // 
            // lblInstruction
            // 
            lblInstruction.AutoSize = true;
            lblInstruction.Location = new Point(20, 18);
            lblInstruction.Text = "Select the days you will travel:";
            // 
            // monthCalendar
            // 
            monthCalendar.Location = new Point(20, 48);
            monthCalendar.MaxSelectionCount = 31;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(330, 58);
            lblStartDate.Size = new Size(180, 45);
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(330, 125);
            lblEndDate.Size = new Size(180, 45);
            // 
            // lblLaunchDate
            // 
            lblLaunchDate.AutoSize = true;
            lblLaunchDate.Location = new Point(20, 270);
            lblLaunchDate.Text = "Product Launch Date:";
            // 
            // datePicker
            // 
            datePicker.Format = DateTimePickerFormat.Long;
            datePicker.Location = new Point(20, 295);
            datePicker.Size = new Size(280, 27);
            datePicker.Value = new DateTime(2002, 6, 8);
            // 
            // radioLongDate
            // 
            radioLongDate.AutoSize = true;
            radioLongDate.Checked = true;
            radioLongDate.Location = new Point(20, 335);
            radioLongDate.Text = "Long Date";
            // 
            // radioShortDate
            // 
            radioShortDate.AutoSize = true;
            radioShortDate.Location = new Point(145, 335);
            radioShortDate.Text = "Short Date";
            // 
            // Form2
            // 
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 390);
            Controls.Add(radioShortDate);
            Controls.Add(radioLongDate);
            Controls.Add(datePicker);
            Controls.Add(lblLaunchDate);
            Controls.Add(lblEndDate);
            Controls.Add(lblStartDate);
            Controls.Add(monthCalendar);
            Controls.Add(lblInstruction);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ex2 - MonthCalendar and DateTimePicker";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblInstruction;
        private MonthCalendar monthCalendar;
        private Label lblStartDate;
        private Label lblEndDate;
        private Label lblLaunchDate;
        private DateTimePicker datePicker;
        private RadioButton radioLongDate;
        private RadioButton radioShortDate;
    }
}
