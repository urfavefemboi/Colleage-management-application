using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using QLDCDKT.Function;

namespace QLDCDKT
{
    public partial class FormTTSinhvien : Form
    {
        public FormTTSinhvien()
        {
            InitializeComponent();
        }
        private void Dinhdangdulieu()
        {
            dtgSV.Columns[0].HeaderText = "Mã Sinh Viên";
            dtgSV.Columns[1].HeaderText = "Tên Sinh Viên";
            dtgSV.Columns[2].HeaderText = "Ngày sinh";
            dtgSV.Columns[3].HeaderText = "Giới tính";
            dtgSV.Columns[4].HeaderText = "Mã Lớp";
            for (int i = 0; i < dtgSV.Columns.Count; i++)
            {
                dtgSV.Columns[i].Width = 120;
            }
            dtgSV.AllowUserToAddRows = false;
            dtgSV.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void Laydulieulengrid()
        {
            DataTable dtbSV = new DataTable();
            String sql = "Select * from SinhVien";
            dtbSV = function.Laydulieulengird(sql);
            dtgSV.DataSource = dtbSV;
            Dinhdangdulieu();
        }
        private void Combolophoc()
        {
            String sqllop = "Select  MaLop from Lop";
            function.Fillcombo(sqllop, txtlop, "MaLop", "MaLop");
        }
        static public void enable_control(Boolean e, Form fr)
        {
            foreach (Control ctr in fr.Controls)
            {
                if (ctr.Name.StartsWith("txt") || ctr.Name.StartsWith("rdo") || ctr.Name == "btnluu" || ctr.Name == "btnhuy")
                {
                    ctr.Enabled = e;

                }
                if (ctr.Name == "btnadd" || ctr.Name == "btnsua" || ctr.Name == "btnxoa")
                {
                    ctr.Enabled = !e;
                }
            }
        }
        public void Cleartext()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr.Name.StartsWith("txt"))
                {
                    ctr.Text = "";
                }
            }

        }

        private void FormTTSinhvien_Load(object sender, EventArgs e)
        {
            Laydulieulengrid();
            Combolophoc();
        }
        String Capnhat = "";
        private void btnadd_Click(object sender, EventArgs e)
        {
            Capnhat = "T";
            enable_control(true, this);
            Cleartext();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Capnhat = "S";
            enable_control(true, this);
            
            txtmasv.Enabled = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                String sql = "";
                if (Capnhat == "T")
                {
                    foreach (Control ctr in this.Controls)
                    {
                        if (ctr.Name.StartsWith("txt").Equals(""))
                        {
                            MessageBox.Show("Ko được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        String gt = "";
                        if (rdonam.Checked == true)
                        {
                            gt = "M";
                        }
                        else if (rdonu.Checked == true)
                        {
                            gt = "F";
                        }
                        string sqlcheckkey = "SELECT MaSV FROM SinhVien " +
                            "WHERE MaSV = '" + txtmasv.Text + "'";
                        if (function.CheckKey(sqlcheckkey) == true)
                        {
                            MessageBox.Show("Trùng mã ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            sql = "INSERT INTO SinhVien VALUES('" + txtmasv.Text + "','"
                           + txttensv.Text + "','" + txtns.Text + "','" + gt + "','" + txtlop.Text + "')";
                        }
                        
                    }
                }
                else if (Capnhat == "S")
                {
                    foreach (Control ctr in this.Controls)
                    {
                        if (ctr.Name.StartsWith("txt").Equals(""))
                        {
                            MessageBox.Show("Ko được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    String gt = "";
                    if (rdonam.Checked == true)
                    {
                        gt = "M";
                    }
                    else if (rdonu.Checked == true)
                    {
                        gt = "F";
                    }
                    sql = "update  SinhVien set TenSV='" + txttensv.Text +
                           "',GioiTinh='" + gt + "',NgaySinh='"
                           + txtns.Text + "' where MaSV='" + txtmasv.Text + "'";
                }
                function.Runsql(sql);
                Laydulieulengrid();
               
                Cleartext();
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex.Message,"Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            enable_control(false, this);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmasv.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("bạn có muốn xóa", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql;
                sql = "delete SinhVien where MaSV='" + txtmasv.Text + "'";
                function.Runsql(sql);
                Cleartext();
                Laydulieulengrid();
            }
        }

        private void dtgSV_Click(object sender, EventArgs e)
        {
            txtmasv.Text = dtgSV.CurrentRow.Cells["MaSV"].Value.ToString();
            txttensv.Text = dtgSV.CurrentRow.Cells["TenSV"].Value.ToString();
            txtns.Text = dtgSV.CurrentRow.Cells["NgaySinh"].Value.ToString();
            if (dtgSV.CurrentRow.Cells["GioiTinh"].Value.ToString() == "M")
            {
                rdonam.Checked = true;
            }
            else if (dtgSV.CurrentRow.Cells["GioiTinh"].Value.ToString() == "F")
            {
                rdonu.Checked = true;
            }
            txtlop.Text = dtgSV.CurrentRow.Cells["MaLop"].Value.ToString();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            Cleartext();
            enable_control(false, this);
            Capnhat = "";
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}