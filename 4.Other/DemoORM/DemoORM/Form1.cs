using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ORMFramework;

namespace DemoORM
{
    public partial class Form1 : Form
    {
        DAMFramework sqlServerDAM = null;
        List<GIAOVIEN> giaovien = new List<GIAOVIEN>();
        List<BOMON> bomon = new List<BOMON>();
        public Form1()
        {
            InitializeComponent();
            sqlServerDAM = new SqlServerDAM("localhost", "QUANLYGIAOVIEN", "sa", "123456");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                sqlServerDAM.Open();
                giaovien = sqlServerDAM.ExecuteQuery<GIAOVIEN>("SELECT * FROM GIAOVIEN");
                bomon = sqlServerDAM.Select<BOMON>().AllRow().Query();
                SetDataGridViewGiaovien(giaovien);
                SetDataGridViewBomon(bomon);
                sqlServerDAM.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SetDataGridViewGiaovien(List<GIAOVIEN> giaovien)
        {
           
            gridViewGV.Rows.Clear();
            foreach (GIAOVIEN temp in giaovien)
            {
                gridViewGV.Rows.Add(temp.MAGV, temp.HOTEN, temp.PHAI, temp.DIACHI, temp.MABM);
            }
        }

        private void SetDataGridViewBomon(List<BOMON> bomon)
        {
            gridViewBM.Rows.Clear();
            foreach (BOMON temp in bomon)
            {
                gridViewBM.Rows.Add(temp.MABM, temp.TENBM, temp.DIENTHOAI, temp.TRUONGBM);
            }
        }

        private void gridViewGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = gridViewGV.CurrentCell.RowIndex; 
            txtMAGV.Text = giaovien[selectedRowIndex].MAGV;
            txtHOTEN.Text = giaovien[selectedRowIndex].HOTEN;
            txtGIOITINH.Text = giaovien[selectedRowIndex].PHAI;
            txtDIACHI.Text = giaovien[selectedRowIndex].DIACHI;
            txtMABM.Text = giaovien[selectedRowIndex].MABM;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMAGV.Text) || string.IsNullOrEmpty(txtHOTEN.Text) || string.IsNullOrEmpty(txtGIOITINH.Text)
                || string.IsNullOrEmpty(txtDIACHI.Text) || string.IsNullOrEmpty(txtMABM.Text))
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin giáo viên!");
            else
            {
                GIAOVIEN gv = new GIAOVIEN();
                gv.MAGV = txtMAGV.Text;
                gv.HOTEN = txtHOTEN.Text;
                gv.PHAI = txtGIOITINH.Text;
                gv.DIACHI = txtDIACHI.Text;
                gv.MABM = txtMABM.Text;
                try
                {
                    sqlServerDAM.Open();
                    sqlServerDAM.Insert(gv);
                    sqlServerDAM.Close();
                    Form1_Load(sender, e);
                    clearTextBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMAGV.Text) || string.IsNullOrEmpty(txtHOTEN.Text) || string.IsNullOrEmpty(txtGIOITINH.Text)
                || string.IsNullOrEmpty(txtDIACHI.Text) || string.IsNullOrEmpty(txtMABM.Text))
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin giáo viên!");
            else
            {
                GIAOVIEN gv = new GIAOVIEN();
                gv.MAGV = txtMAGV.Text;
                gv.HOTEN = txtHOTEN.Text;
                gv.PHAI = txtGIOITINH.Text;
                gv.DIACHI = txtDIACHI.Text;
                gv.MABM = txtMABM.Text;
                try
                {
                    sqlServerDAM.Open();
                    sqlServerDAM.Update(gv);
                    sqlServerDAM.Close();
                    Form1_Load(sender, e);
                    clearTextBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMAGV.Text) || string.IsNullOrEmpty(txtHOTEN.Text) || string.IsNullOrEmpty(txtGIOITINH.Text)
                || string.IsNullOrEmpty(txtDIACHI.Text) || string.IsNullOrEmpty(txtMABM.Text))
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin giáo viên!");
            else
            {
                GIAOVIEN gv = new GIAOVIEN();
                gv.MAGV = txtMAGV.Text;
                gv.HOTEN = txtHOTEN.Text;
                gv.PHAI = txtGIOITINH.Text;
                gv.DIACHI = txtDIACHI.Text;
                gv.MABM = txtMABM.Text;
                try
                {
                    sqlServerDAM.Open();
                    sqlServerDAM.Delete(gv);
                    sqlServerDAM.Close();
                    Form1_Load(sender, e);
                    clearTextBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            try
            {
                sqlServerDAM.Open();
                if (string.IsNullOrEmpty(txtSearch.Text))
                    giaovien = sqlServerDAM.Select<GIAOVIEN>().AllRow().Query();
                else
                    giaovien = sqlServerDAM.Select<GIAOVIEN>().Where("HOTEN LIKE N'%" + txtSearch.Text.Trim() + "%'").Query();

                if (giaovien == null || giaovien.Count == 0)
                    MessageBox.Show("Không thể tìm thấy kết quả");
                else
                    SetDataGridViewGiaovien(giaovien);
                sqlServerDAM.Close();
                clearTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void clearTextBox()
        {
            txtMAGV.Text = "";
            txtHOTEN.Text = "";
            txtGIOITINH.Text = "";
            txtDIACHI.Text = "";
            txtMABM.Text = "";
        }

    }
}
