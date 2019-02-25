namespace DemoORM
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridViewGV = new System.Windows.Forms.DataGridView();
            this.MAGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MABM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDelete = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.txtMABM = new System.Windows.Forms.TextBox();
            this.txtDIACHI = new System.Windows.Forms.TextBox();
            this.txtGIOITINH = new System.Windows.Forms.TextBox();
            this.txtHOTEN = new System.Windows.Forms.TextBox();
            this.txtMAGV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gridViewBM = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.MABM1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENBM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIENTHOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRUONGBM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGV)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBM)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(866, 398);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage1.Controls.Add(this.txtSearch);
            this.tabPage1.Controls.Add(this.bSearch);
            this.tabPage1.Controls.Add(this.gridViewGV);
            this.tabPage1.Controls.Add(this.bDelete);
            this.tabPage1.Controls.Add(this.bUpdate);
            this.tabPage1.Controls.Add(this.bAdd);
            this.tabPage1.Controls.Add(this.txtMABM);
            this.tabPage1.Controls.Add(this.txtDIACHI);
            this.tabPage1.Controls.Add(this.txtGIOITINH);
            this.tabPage1.Controls.Add(this.txtHOTEN);
            this.tabPage1.Controls.Add(this.txtMAGV);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(858, 372);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Giáo viên";
            // 
            // gridViewGV
            // 
            this.gridViewGV.AllowUserToAddRows = false;
            this.gridViewGV.AllowUserToDeleteRows = false;
            this.gridViewGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAGV,
            this.HOTEN,
            this.GIOITINH,
            this.DIACHI,
            this.MABM});
            this.gridViewGV.Location = new System.Drawing.Point(204, 52);
            this.gridViewGV.Name = "gridViewGV";
            this.gridViewGV.ReadOnly = true;
            this.gridViewGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewGV.Size = new System.Drawing.Size(649, 314);
            this.gridViewGV.TabIndex = 16;
            this.gridViewGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewGV_CellClick);
            // 
            // MAGV
            // 
            this.MAGV.HeaderText = "Mã GV";
            this.MAGV.Name = "MAGV";
            this.MAGV.ReadOnly = true;
            // 
            // HOTEN
            // 
            this.HOTEN.HeaderText = "Họ tên";
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.ReadOnly = true;
            // 
            // GIOITINH
            // 
            this.GIOITINH.HeaderText = "Giới tính";
            this.GIOITINH.Name = "GIOITINH";
            this.GIOITINH.ReadOnly = true;
            // 
            // DIACHI
            // 
            this.DIACHI.HeaderText = "Địa chỉ";
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.ReadOnly = true;
            this.DIACHI.Width = 200;
            // 
            // MABM
            // 
            this.MABM.HeaderText = "Mã BM";
            this.MABM.Name = "MABM";
            this.MABM.ReadOnly = true;
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(49, 293);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 15;
            this.bDelete.Text = "Xóa";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(100, 264);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(75, 23);
            this.bUpdate.TabIndex = 14;
            this.bUpdate.Text = "Sửa";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(6, 264);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 13;
            this.bAdd.Text = "Thêm";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // txtMABM
            // 
            this.txtMABM.Location = new System.Drawing.Point(67, 186);
            this.txtMABM.Name = "txtMABM";
            this.txtMABM.Size = new System.Drawing.Size(108, 20);
            this.txtMABM.TabIndex = 12;
            // 
            // txtDIACHI
            // 
            this.txtDIACHI.Location = new System.Drawing.Point(67, 155);
            this.txtDIACHI.Name = "txtDIACHI";
            this.txtDIACHI.Size = new System.Drawing.Size(108, 20);
            this.txtDIACHI.TabIndex = 11;
            // 
            // txtGIOITINH
            // 
            this.txtGIOITINH.Location = new System.Drawing.Point(67, 125);
            this.txtGIOITINH.Name = "txtGIOITINH";
            this.txtGIOITINH.Size = new System.Drawing.Size(108, 20);
            this.txtGIOITINH.TabIndex = 10;
            // 
            // txtHOTEN
            // 
            this.txtHOTEN.Location = new System.Drawing.Point(67, 90);
            this.txtHOTEN.Name = "txtHOTEN";
            this.txtHOTEN.Size = new System.Drawing.Size(108, 20);
            this.txtHOTEN.TabIndex = 8;
            // 
            // txtMAGV
            // 
            this.txtMAGV.Location = new System.Drawing.Point(67, 60);
            this.txtMAGV.Name = "txtMAGV";
            this.txtMAGV.Size = new System.Drawing.Size(108, 20);
            this.txtMAGV.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mã BM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Địa chỉ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã GV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý giáo viên";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.gridViewBM);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(858, 372);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bộ môn";
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(570, 13);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(103, 23);
            this.bSearch.TabIndex = 17;
            this.bSearch.Text = "Tìm kiếm theo tên";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(704, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(109, 20);
            this.txtSearch.TabIndex = 18;
            // 
            // gridViewBM
            // 
            this.gridViewBM.AllowUserToAddRows = false;
            this.gridViewBM.AllowUserToDeleteRows = false;
            this.gridViewBM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewBM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MABM1,
            this.TENBM,
            this.DIENTHOAI,
            this.TRUONGBM});
            this.gridViewBM.Location = new System.Drawing.Point(168, 61);
            this.gridViewBM.Name = "gridViewBM";
            this.gridViewBM.ReadOnly = true;
            this.gridViewBM.Size = new System.Drawing.Size(684, 304);
            this.gridViewBM.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(330, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quản lý bộ môn";
            // 
            // MABM1
            // 
            this.MABM1.HeaderText = "Mã BM";
            this.MABM1.Name = "MABM1";
            this.MABM1.ReadOnly = true;
            // 
            // TENBM
            // 
            this.TENBM.HeaderText = "Tên BM";
            this.TENBM.Name = "TENBM";
            this.TENBM.ReadOnly = true;
            this.TENBM.Width = 200;
            // 
            // DIENTHOAI
            // 
            this.DIENTHOAI.HeaderText = "Điện thoại";
            this.DIENTHOAI.Name = "DIENTHOAI";
            this.DIENTHOAI.ReadOnly = true;
            this.DIENTHOAI.Width = 150;
            // 
            // TRUONGBM
            // 
            this.TRUONGBM.HeaderText = "Trưởng BM";
            this.TRUONGBM.Name = "TRUONGBM";
            this.TRUONGBM.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 399);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.TextBox txtMABM;
        private System.Windows.Forms.TextBox txtDIACHI;
        private System.Windows.Forms.TextBox txtGIOITINH;
        private System.Windows.Forms.TextBox txtHOTEN;
        private System.Windows.Forms.TextBox txtMAGV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridViewGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MABM;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gridViewBM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MABM1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENBM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIENTHOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRUONGBM;
    }
}

