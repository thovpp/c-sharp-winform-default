namespace thovpp.FAP.StudentMgt
{
    public partial class StudentListForm : Form
    {

        List<Student> _ds = new List<Student>();
        public StudentListForm()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xin Chào. This is 1st message that come VS2022",
                "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("GoodBye, Are you sure!",
                  "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void OpenImage(object sender, EventArgs e)
        {
            DialogResult result = dlgOpenFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                //MessageBox.Show(dlgOpenFile.FileName);
                lblFileName.Text = "Image: " + dlgOpenFile.FileName;

                picAvatar.Image = new Bitmap(dlgOpenFile.FileName);
            }
        }

        private void LoadData(object sender, EventArgs e)
        {

            _ds.Add(new Student() { Id = "SE1", Name = "An", Address = "Dương Đông" });
            _ds.Add(new Student() { Id = "SE2", Name = "Dương", Address = "Tân Bình" });
            _ds.Add(new Student() { Id = "SE3", Name = "Dũng", Address = "Tân An" });

            dgvStudentList.DataSource = _ds;
        }

        private void ShowAStudent(object sender, EventArgs e)
        {
            if (dgvStudentList.SelectedRows.Count > 0)
            {
                // lấy ra dòng đầu tiền trong nhiều dòng vừa chọn 
                DataGridViewRow selectedRow = dgvStudentList.SelectedRows[0];
                //trích từng cell ra, chấm Value mặc định trả về Object cần phải .Tostring()
                txtId.Text = selectedRow.Cells["id"].Value.ToString();
                txtName.Text = selectedRow.Cells[1].Value.ToString();
                txtAddress.Text = selectedRow.Cells["Address"].Value.ToString();

            }
        }

        private void AddNewStudent(object sender, EventArgs e)
        {
            Student x = new Student() { 
            Id = txtId.Text,
            Name = txtName.Text,
            Address = txtAddress.Text,
            };
            _ds.Add(x);   // chỉ mới add trong danh sách thôi chưa hiển thị vào gridview
            // cần phải refresh cái lưới
            dgvStudentList.DataSource = null; // clear 
            dgvStudentList.DataSource = _ds;
        }
    }
}
