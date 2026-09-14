namespace cau14_chuong2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTen = new TextBox();
            cboLop = new ComboBox();
            btnCapNhat = new Button();
            lstLopA = new ListBox();
            lstLopB = new ListBox();
            btnMoveRight = new Button();
            btnMoveLeft = new Button();
            btnMoveRightAll = new Button();
            btnMoveLeftAll = new Button();
            btnDeleteA = new Button();
            btnDeleteB = new Button();
            btnExit = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            grpLopA = new GroupBox();
            grpLopB = new GroupBox();
            headerPanel = new Panel();
            lblMenuCapNhat = new Label();
            lblMenuHeThong = new Label();
            menuStrip1 = new MenuStrip();
            cậpNhậtToolStripMenuItem = new ToolStripMenuItem();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1.SuspendLayout();
            grpLopA.SuspendLayout();
            grpLopB.SuspendLayout();
            headerPanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(24, 76);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 9;
            label3.Text = "Tên SV:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(98, 72);
            txtTen.Margin = new Padding(3, 4, 3, 4);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(320, 27);
            txtTen.TabIndex = 1;
            // 
            // cboLop
            // 
            cboLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLop.Items.AddRange(new object[] { "Lớp A", "Lớp B" });
            cboLop.Location = new Point(430, 72);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(120, 28);
            cboLop.TabIndex = 2;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCapNhat.Location = new Point(566, 70);
            btnCapNhat.Margin = new Padding(3, 4, 3, 4);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(110, 32);
            btnCapNhat.TabIndex = 3;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += BtnCapNhat_Click;
            // 
            // lstLopA
            // 
            lstLopA.FormattingEnabled = true;
            lstLopA.Location = new Point(8, 26);
            lstLopA.Margin = new Padding(3, 4, 3, 4);
            lstLopA.Name = "lstLopA";
            lstLopA.SelectionMode = SelectionMode.MultiExtended;
            lstLopA.Size = new Size(284, 244);
            lstLopA.TabIndex = 4;
            // 
            // lstLopB
            // 
            lstLopB.FormattingEnabled = true;
            lstLopB.Location = new Point(8, 26);
            lstLopB.Margin = new Padding(3, 4, 3, 4);
            lstLopB.Name = "lstLopB";
            lstLopB.SelectionMode = SelectionMode.MultiExtended;
            lstLopB.Size = new Size(332, 244);
            lstLopB.TabIndex = 6;
            // 
            // btnMoveRight
            // 
            btnMoveRight.Location = new Point(338, 180);
            btnMoveRight.Margin = new Padding(3, 4, 3, 4);
            btnMoveRight.Name = "btnMoveRight";
            btnMoveRight.Size = new Size(40, 30);
            btnMoveRight.TabIndex = 7;
            btnMoveRight.Text = ">";
            btnMoveRight.UseVisualStyleBackColor = true;
            btnMoveRight.Click += BtnMoveRight_Click;
            // 
            // btnMoveLeft
            // 
            btnMoveLeft.Location = new Point(338, 220);
            btnMoveLeft.Margin = new Padding(3, 4, 3, 4);
            btnMoveLeft.Name = "btnMoveLeft";
            btnMoveLeft.Size = new Size(40, 30);
            btnMoveLeft.TabIndex = 8;
            btnMoveLeft.Text = "<";
            btnMoveLeft.UseVisualStyleBackColor = true;
            btnMoveLeft.Click += BtnMoveLeft_Click;
            // 
            // btnMoveRightAll
            // 
            btnMoveRightAll.Location = new Point(338, 260);
            btnMoveRightAll.Margin = new Padding(3, 4, 3, 4);
            btnMoveRightAll.Name = "btnMoveRightAll";
            btnMoveRightAll.Size = new Size(40, 30);
            btnMoveRightAll.TabIndex = 9;
            btnMoveRightAll.Text = ">>";
            btnMoveRightAll.UseVisualStyleBackColor = true;
            btnMoveRightAll.Click += BtnMoveRightAll_Click;
            // 
            // btnMoveLeftAll
            // 
            btnMoveLeftAll.Location = new Point(338, 300);
            btnMoveLeftAll.Margin = new Padding(3, 4, 3, 4);
            btnMoveLeftAll.Name = "btnMoveLeftAll";
            btnMoveLeftAll.Size = new Size(40, 30);
            btnMoveLeftAll.TabIndex = 10;
            btnMoveLeftAll.Text = "<<";
            btnMoveLeftAll.UseVisualStyleBackColor = true;
            btnMoveLeftAll.Click += BtnMoveLeftAll_Click;
            // 
            // btnDeleteA
            // 
            btnDeleteA.Location = new Point(24, 430);
            btnDeleteA.Margin = new Padding(3, 4, 3, 4);
            btnDeleteA.Name = "btnDeleteA";
            btnDeleteA.Size = new Size(120, 34);
            btnDeleteA.TabIndex = 12;
            btnDeleteA.Text = "Xóa Lớp A";
            btnDeleteA.UseVisualStyleBackColor = true;
            btnDeleteA.Click += BtnDeleteA_Click;
            // 
            // btnDeleteB
            // 
            btnDeleteB.Location = new Point(612, 430);
            btnDeleteB.Margin = new Padding(3, 4, 3, 4);
            btnDeleteB.Name = "btnDeleteB";
            btnDeleteB.Size = new Size(120, 34);
            btnDeleteB.TabIndex = 13;
            btnDeleteB.Text = "Xóa Lớp B";
            btnDeleteB.UseVisualStyleBackColor = true;
            btnDeleteB.Click += BtnDeleteB_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(338, 430);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(86, 34);
            btnExit.TabIndex = 14;
            btnExit.Text = "Kết Thúc";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += BtnExit_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(0, 192, 192);
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 475);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(740, 26);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 15;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.ForeColor = Color.White;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(50, 20);
            toolStripStatusLabel1.Text = "Ready";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            // 
            // grpLopA
            // 
            grpLopA.Controls.Add(lstLopA);
            grpLopA.Font = new Font("Segoe UI", 9F);
            grpLopA.Location = new Point(24, 120);
            grpLopA.Name = "grpLopA";
            grpLopA.Size = new Size(300, 290);
            grpLopA.TabIndex = 4;
            grpLopA.TabStop = false;
            grpLopA.Text = "Danh sách Lớp A";
            // 
            // grpLopB
            // 
            grpLopB.Controls.Add(lstLopB);
            grpLopB.Font = new Font("Segoe UI", 9F);
            grpLopB.Location = new Point(384, 120);
            grpLopB.Name = "grpLopB";
            grpLopB.Size = new Size(348, 290);
            grpLopB.TabIndex = 5;
            grpLopB.TabStop = false;
            grpLopB.Text = "Danh sách Lớp B";
            // 
            // headerPanel
            // 
            headerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            headerPanel.BackColor = Color.FromArgb(0, 192, 192);
            headerPanel.Controls.Add(lblMenuCapNhat);
            headerPanel.Controls.Add(lblMenuHeThong);
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(740, 48);
            headerPanel.TabIndex = 0;
            // 
            // lblMenuCapNhat
            // 
            lblMenuCapNhat.AutoSize = true;
            lblMenuCapNhat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMenuCapNhat.ForeColor = Color.White;
            lblMenuCapNhat.Location = new Point(12, 14);
            lblMenuCapNhat.Name = "lblMenuCapNhat";
            lblMenuCapNhat.Size = new Size(85, 23);
            lblMenuCapNhat.TabIndex = 0;
            lblMenuCapNhat.Text = "Cập Nhật";
            // 
            // lblMenuHeThong
            // 
            lblMenuHeThong.AutoSize = true;
            lblMenuHeThong.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMenuHeThong.ForeColor = Color.White;
            lblMenuHeThong.Location = new Point(120, 14);
            lblMenuHeThong.Name = "lblMenuHeThong";
            lblMenuHeThong.Size = new Size(88, 23);
            lblMenuHeThong.TabIndex = 1;
            lblMenuHeThong.Text = "Hệ Thống";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(0, 192, 192);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cậpNhậtToolStripMenuItem, hệThốngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(740, 28);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // cậpNhậtToolStripMenuItem
            // 
            cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            cậpNhậtToolStripMenuItem.Size = new Size(85, 24);
            cậpNhậtToolStripMenuItem.Text = "Cập Nhật";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(88, 24);
            hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(740, 501);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(btnExit);
            Controls.Add(btnDeleteB);
            Controls.Add(btnDeleteA);
            Controls.Add(btnMoveLeftAll);
            Controls.Add(btnMoveRightAll);
            Controls.Add(btnMoveLeft);
            Controls.Add(btnMoveRight);
            Controls.Add(grpLopB);
            Controls.Add(grpLopA);
            Controls.Add(btnCapNhat);
            Controls.Add(cboLop);
            Controls.Add(txtTen);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Cập Nhật 2 ListBox";
            FormClosing += Form1_FormClosing;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            grpLopA.ResumeLayout(false);
            grpLopB.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private TextBox txtTen;
        private ComboBox cboLop;
        private ListBox lstLopA;
        private ListBox lstLopB;
        private Button btnCapNhat;
        private Button btnMoveRight;
        private Button btnMoveLeft;
        private Button btnMoveRightAll;
        private Button btnMoveLeftAll;
        private Button btnDeleteA;
        private Button btnDeleteB;
        private Button btnExit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel headerPanel;
        private Label lblMenuCapNhat;
        private Label lblMenuHeThong;
        private GroupBox grpLopA;
        private GroupBox grpLopB;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
    }
}
