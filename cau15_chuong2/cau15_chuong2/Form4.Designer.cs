namespace cau15_chuong2
{
    partial class Form4
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
            tabOptions = new TabControl();
            tabMessage = new TabPage("Message");
            tabButtons = new TabPage("Buttons");
            tabIcon = new TabPage("Icon");
            txtMessage = new TextBox();
            txtCaption = new TextBox();
            lblMessage = new Label();
            lblCaption = new Label();
            radioOk = new RadioButton();
            radioOkCancel = new RadioButton();
            radioRetryCancel = new RadioButton();
            radioYesNo = new RadioButton();
            radioYesNoCancel = new RadioButton();
            radioError = new RadioButton();
            radioInformation = new RadioButton();
            radioNone = new RadioButton();
            radioQuestion = new RadioButton();
            radioWarning = new RadioButton();
            btnShow = new Button();
            groupLayout = new GroupBox();
            radioLeft = new RadioButton();
            radioRight = new RadioButton();
            radioTop = new RadioButton();
            radioBottom = new RadioButton();
            tabOptions.SuspendLayout();
            tabMessage.SuspendLayout();
            tabButtons.SuspendLayout();
            tabIcon.SuspendLayout();
            groupLayout.SuspendLayout();
            SuspendLayout();
            // 
            // lblInstruction
            // 
            lblInstruction.AutoSize = true;
            lblInstruction.Location = new Point(18, 15);
            lblInstruction.Text = "Select options to create a message box:";
            // 
            // tabOptions
            // 
            tabOptions.Controls.Add(tabMessage);
            tabOptions.Controls.Add(tabButtons);
            tabOptions.Controls.Add(tabIcon);
            tabOptions.Location = new Point(18, 42);
            tabOptions.Size = new Size(365, 190);
            // 
            // tabMessage
            // 
            tabMessage.Controls.Add(txtCaption);
            tabMessage.Controls.Add(txtMessage);
            tabMessage.Controls.Add(lblCaption);
            tabMessage.Controls.Add(lblMessage);
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(15, 15);
            lblMessage.Text = "Enter the message to display:";
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(15, 38);
            txtMessage.Multiline = true;
            txtMessage.Size = new Size(320, 58);
            txtMessage.Text = "Sample Message";
            // 
            // lblCaption
            // 
            lblCaption.AutoSize = true;
            lblCaption.Location = new Point(15, 107);
            lblCaption.Text = "Enter a Caption for MessageBox:";
            // 
            // txtCaption
            // 
            txtCaption.Location = new Point(15, 130);
            txtCaption.Size = new Size(320, 27);
            txtCaption.Text = "TabControl Demo";
            // 
            // tabButtons
            // 
            tabButtons.Controls.Add(radioYesNoCancel);
            tabButtons.Controls.Add(radioYesNo);
            tabButtons.Controls.Add(radioRetryCancel);
            tabButtons.Controls.Add(radioOkCancel);
            tabButtons.Controls.Add(radioOk);
            radioOk.AutoSize = true;
            radioOk.Checked = true;
            radioOk.Location = new Point(18, 18);
            radioOk.Text = "OK";
            radioOkCancel.AutoSize = true;
            radioOkCancel.Location = new Point(18, 45);
            radioOkCancel.Text = "OK and Cancel";
            radioRetryCancel.AutoSize = true;
            radioRetryCancel.Location = new Point(18, 72);
            radioRetryCancel.Text = "Retry and Cancel";
            radioYesNo.AutoSize = true;
            radioYesNo.Location = new Point(18, 99);
            radioYesNo.Text = "Yes and No";
            radioYesNoCancel.AutoSize = true;
            radioYesNoCancel.Location = new Point(18, 126);
            radioYesNoCancel.Text = "Yes, No and Cancel";
            // 
            // tabIcon
            // 
            tabIcon.Controls.Add(radioWarning);
            tabIcon.Controls.Add(radioQuestion);
            tabIcon.Controls.Add(radioNone);
            tabIcon.Controls.Add(radioInformation);
            tabIcon.Controls.Add(radioError);
            radioError.AutoSize = true;
            radioError.Location = new Point(18, 18);
            radioError.Text = "Error";
            radioInformation.AutoSize = true;
            radioInformation.Checked = true;
            radioInformation.Location = new Point(18, 45);
            radioInformation.Text = "Information";
            radioNone.AutoSize = true;
            radioNone.Location = new Point(18, 72);
            radioNone.Text = "None";
            radioQuestion.AutoSize = true;
            radioQuestion.Location = new Point(18, 99);
            radioQuestion.Text = "Question";
            radioWarning.AutoSize = true;
            radioWarning.Location = new Point(18, 126);
            radioWarning.Text = "Warning";
            // 
            // btnShow
            // 
            btnShow.Location = new Point(150, 245);
            btnShow.Size = new Size(95, 32);
            btnShow.Text = "Show!";
            btnShow.Click += btnShow_Click;
            // 
            // groupLayout
            // 
            groupLayout.Controls.Add(radioBottom);
            groupLayout.Controls.Add(radioTop);
            groupLayout.Controls.Add(radioRight);
            groupLayout.Controls.Add(radioLeft);
            groupLayout.Location = new Point(18, 295);
            groupLayout.Size = new Size(365, 82);
            groupLayout.Text = "Tab Layout";
            radioLeft.AutoSize = true;
            radioLeft.Location = new Point(15, 25);
            radioLeft.Text = "Left";
            radioLeft.CheckedChanged += SetTabAlignment;
            radioRight.AutoSize = true;
            radioRight.Location = new Point(180, 25);
            radioRight.Text = "Right";
            radioRight.CheckedChanged += SetTabAlignment;
            radioTop.AutoSize = true;
            radioTop.Checked = true;
            radioTop.Location = new Point(15, 52);
            radioTop.Text = "Top";
            radioTop.CheckedChanged += SetTabAlignment;
            radioBottom.AutoSize = true;
            radioBottom.Location = new Point(180, 52);
            radioBottom.Text = "Bottom";
            radioBottom.CheckedChanged += SetTabAlignment;
            // 
            // Form4
            // 
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 400);
            Controls.Add(groupLayout);
            Controls.Add(btnShow);
            Controls.Add(tabOptions);
            Controls.Add(lblInstruction);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ex4 - TabControl";
            tabOptions.ResumeLayout(false);
            tabMessage.ResumeLayout(false);
            tabMessage.PerformLayout();
            tabButtons.ResumeLayout(false);
            tabButtons.PerformLayout();
            tabIcon.ResumeLayout(false);
            tabIcon.PerformLayout();
            groupLayout.ResumeLayout(false);
            groupLayout.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblInstruction;
        private TabControl tabOptions;
        private TabPage tabMessage;
        private TabPage tabButtons;
        private TabPage tabIcon;
        private TextBox txtMessage;
        private TextBox txtCaption;
        private Label lblMessage;
        private Label lblCaption;
        private RadioButton radioOk;
        private RadioButton radioOkCancel;
        private RadioButton radioRetryCancel;
        private RadioButton radioYesNo;
        private RadioButton radioYesNoCancel;
        private RadioButton radioError;
        private RadioButton radioInformation;
        private RadioButton radioNone;
        private RadioButton radioQuestion;
        private RadioButton radioWarning;
        private Button btnShow;
        private GroupBox groupLayout;
        private RadioButton radioLeft;
        private RadioButton radioRight;
        private RadioButton radioTop;
        private RadioButton radioBottom;
    }
}
