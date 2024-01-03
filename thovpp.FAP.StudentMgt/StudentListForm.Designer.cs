namespace thovpp.FAP.StudentMgt
{
    partial class StudentListForm
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
            btnSayHello = new Button();
            Exit = new Button();
            dlgOpenFile = new OpenFileDialog();
            btnImage = new Button();
            picAvatar = new PictureBox();
            lblFileName = new Label();
            pnlImage = new Panel();
            dgvStudentList = new DataGridView();
            btnLoadData = new Button();
            lblId = new Label();
            lblName = new Label();
            lblAddress = new Label();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtId = new TextBox();
            rgbStudent = new GroupBox();
            btnAddNew = new Button();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudentList).BeginInit();
            rgbStudent.SuspendLayout();
            SuspendLayout();
            // 
            // btnSayHello
            // 
            btnSayHello.Location = new Point(29, 32);
            btnSayHello.Name = "btnSayHello";
            btnSayHello.Size = new Size(100, 40);
            btnSayHello.TabIndex = 0;
            btnSayHello.Text = "Say Hello";
            btnSayHello.UseVisualStyleBackColor = true;
            btnSayHello.Click += btnSayHello_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(195, 32);
            Exit.Name = "Exit";
            Exit.Size = new Size(116, 40);
            Exit.TabIndex = 1;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += btnExit;
            // 
            // dlgOpenFile
            // 
            dlgOpenFile.FileName = "dlgOpenFile";
            dlgOpenFile.Filter = "JPEG files |*.jpg;*.jpeg|PNG files|*.png";
            // 
            // btnImage
            // 
            btnImage.Location = new Point(29, 138);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(140, 40);
            btnImage.TabIndex = 2;
            btnImage.Text = "Choose Image";
            btnImage.UseVisualStyleBackColor = true;
            btnImage.Click += OpenImage;
            // 
            // picAvatar
            // 
            picAvatar.BorderStyle = BorderStyle.Fixed3D;
            picAvatar.Location = new Point(3, 3);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(491, 403);
            picAvatar.SizeMode = PictureBoxSizeMode.AutoSize;
            picAvatar.TabIndex = 3;
            picAvatar.TabStop = false;
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Location = new Point(195, 148);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(51, 20);
            lblFileName.TabIndex = 4;
            lblFileName.Text = "image";
            // 
            // pnlImage
            // 
            pnlImage.AutoScroll = true;
            pnlImage.BorderStyle = BorderStyle.Fixed3D;
            pnlImage.Controls.Add(picAvatar);
            pnlImage.Location = new Point(29, 200);
            pnlImage.Name = "pnlImage";
            pnlImage.Size = new Size(507, 408);
            pnlImage.TabIndex = 5;
            // 
            // dgvStudentList
            // 
            dgvStudentList.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvStudentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentList.Location = new Point(542, 228);
            dgvStudentList.Name = "dgvStudentList";
            dgvStudentList.RowHeadersWidth = 51;
            dgvStudentList.Size = new Size(500, 380);
            dgvStudentList.TabIndex = 6;
            dgvStudentList.SelectionChanged += ShowAStudent;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(500, 101);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(105, 40);
            btnLoadData.TabIndex = 7;
            btnLoadData.Text = "Load Data";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += LoadData;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(50, 34);
            lblId.Name = "lblId";
            lblId.Size = new Size(22, 20);
            lblId.TabIndex = 8;
            lblId.Text = "Id";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(50, 74);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 9;
            lblName.Text = "Name";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(50, 113);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.TabIndex = 10;
            lblAddress.Text = "Address";
            // 
            // txtName
            // 
            txtName.Location = new Point(133, 71);
            txtName.Name = "txtName";
            txtName.Size = new Size(203, 27);
            txtName.TabIndex = 11;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(133, 113);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(203, 27);
            txtAddress.TabIndex = 12;
            // 
            // txtId
            // 
            txtId.Location = new Point(133, 27);
            txtId.Name = "txtId";
            txtId.Size = new Size(203, 27);
            txtId.TabIndex = 13;
            // 
            // rgbStudent
            // 
            rgbStudent.BackColor = SystemColors.AppWorkspace;
            rgbStudent.Controls.Add(txtId);
            rgbStudent.Controls.Add(txtAddress);
            rgbStudent.Controls.Add(txtName);
            rgbStudent.Controls.Add(lblAddress);
            rgbStudent.Controls.Add(lblName);
            rgbStudent.Controls.Add(lblId);
            rgbStudent.Location = new Point(611, 67);
            rgbStudent.Name = "rgbStudent";
            rgbStudent.Size = new Size(373, 155);
            rgbStudent.TabIndex = 14;
            rgbStudent.TabStop = false;
            rgbStudent.Text = "  Student Info  ";
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(500, 32);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(105, 40);
            btnAddNew.TabIndex = 15;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += AddNewStudent;
            // 
            // StudentListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 615);
            Controls.Add(btnAddNew);
            Controls.Add(rgbStudent);
            Controls.Add(btnLoadData);
            Controls.Add(dgvStudentList);
            Controls.Add(pnlImage);
            Controls.Add(lblFileName);
            Controls.Add(btnImage);
            Controls.Add(Exit);
            Controls.Add(btnSayHello);
            Name = "StudentListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentListForm";
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            pnlImage.ResumeLayout(false);
            pnlImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudentList).EndInit();
            rgbStudent.ResumeLayout(false);
            rgbStudent.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSayHello;
        private Button Exit;
        private OpenFileDialog dlgOpenFile;
        private Button btnImage;
        private PictureBox picAvatar;
        private Label lblFileName;
        private Panel pnlImage;
        private DataGridView dgvStudentList;
        protected internal Button btnLoadData;
        private Label lblId;
        private Label lblName;
        private Label lblAddress;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtId;
        private GroupBox rgbStudent;
        protected internal Button btnAddNew;
    }
}
