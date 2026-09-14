namespace cau14_chuong2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = btnCapNhat;
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Bạn ko được phép nhập dữ liệu rỗng!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTen.Focus();
            }
            else
            {
                string strDuLieu = txtTen.Text.Trim();
                if (string.IsNullOrEmpty(strDuLieu))
                {
                    MessageBox.Show("Bạn ko được phép nhập dữ liệu rỗng!", "Thông Báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTen.Focus();
                    return;
                }

                // thêm vào lớp tùy chọn
                if (cboLop != null && cboLop.SelectedIndex == 1)
                    lstLopB.Items.Add(strDuLieu);
                else
                    lstLopA.Items.Add(strDuLieu);

                txtTen.Clear();
                txtTen.Focus();
            }
        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            if (toolStripStatusLabel1 != null)
            {
                toolStripStatusLabel1.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "    Designed by Xavier";
            }
        }

        private void BtnMoveRight_Click(object sender, EventArgs e)
        {
            DialogResult hoiChuyen;
            if (lstLopA.Items.Count > 0)
            {
                hoiChuyen = MessageBox.Show("Bạn có chắc chuyển những dữ liệu đang chọn ko?", "Thông Báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (hoiChuyen == DialogResult.Yes)
                    ChuyenDuLieu(lstLopA, lstLopB);
            }
            else
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");
        }

        private void BtnMoveLeft_Click(object sender, EventArgs e)
        {
            DialogResult hoiChuyen;
            if (lstLopB.Items.Count > 0)
            {
                hoiChuyen = MessageBox.Show("Bạn có chắc chuyển những dữ liệu đang chọn ko?", "Thông Báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (hoiChuyen == DialogResult.Yes)
                    ChuyenDuLieu(lstLopB, lstLopA);
            }
            else
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");
        }

        private void BtnMoveRightAll_Click(object sender, EventArgs e)
        {
            DialogResult hoiChuyen;
            if (lstLopA.Items.Count > 0)
            {
                hoiChuyen = MessageBox.Show("Bạn có chắc chuyển toàn bộ dữ liệu ko?", "Thông Báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (hoiChuyen == DialogResult.Yes)
                    ChuyenToanBo(lstLopA, lstLopB);
            }
            else
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");
        }

        private void BtnMoveLeftAll_Click(object sender, EventArgs e)
        {
            DialogResult hoiChuyen;
            if (lstLopB.Items.Count > 0)
            {
                hoiChuyen = MessageBox.Show("Bạn có chắc chuyển toàn bộ dữ liệu ko?", "Thông Báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (hoiChuyen == DialogResult.Yes)
                    ChuyenToanBo(lstLopB, lstLopA);
            }
            else
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");
        }

        private void BtnDeleteA_Click(object sender, EventArgs e)
        {
            // Delete entire class A after confirmation
            if (lstLopA.Items.Count > 0)
            {
                DialogResult hoiXoa = MessageBox.Show("Bạn có chắc muốn xóa toàn bộ Lớp A?", "Chú ý",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (hoiXoa == DialogResult.Yes)
                {
                    lstLopA.Items.Clear();
                    if (toolStripStatusLabel1 != null)
                        toolStripStatusLabel1.Text = "Đã xóa toàn bộ Lớp A";
                }
            }
            else
            {
                MessageBox.Show("Hiện danh sách đang rỗng!", "Chú ý");
            }
        }

        private void BtnDeleteB_Click(object sender, EventArgs e)
        {
            // Delete entire class B after confirmation
            if (lstLopB.Items.Count > 0)
            {
                DialogResult hoiXoa = MessageBox.Show("Bạn có chắc muốn xóa toàn bộ Lớp B?", "Chú ý",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (hoiXoa == DialogResult.Yes)
                {
                    lstLopB.Items.Clear();
                    if (toolStripStatusLabel1 != null)
                        toolStripStatusLabel1.Text = "Đã xóa toàn bộ Lớp B";
                }
            }
            else
            {
                MessageBox.Show("Hiện danh sách đang rỗng!", "Chú ý");
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                e.Cancel = true;
        }

        void ChuyenDuLieu(ListBox lst1, ListBox lst2)
        {
            int i = 0;
            while (i < lst1.Items.Count)
            {
                if (lst1.GetSelected(i))
                {
                    string stDuLieu = lst1.Items[i].ToString();
                    lst2.Items.Add(stDuLieu);
                    lst1.Items.RemoveAt(i);
                }
                else
                    i++;
            }
        }

        void ChuyenToanBo(ListBox lst1, ListBox lst2)
        {
            while (lst1.Items.Count != 0)
            {
                string stDuLieu = lst1.Items[0].ToString();
                lst2.Items.Add(stDuLieu);
                lst1.Items.RemoveAt(0);
            }
        }

        void XoaDuLieu(ListBox lst)
        {
            int i = 0;
            while (i < lst.Items.Count)
            {
                if (lst.GetSelected(i))
                    lst.Items.RemoveAt(i);
                else
                    i++;
            }
        }
    }
}
