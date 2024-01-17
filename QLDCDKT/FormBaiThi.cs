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
using System.IO;
using System.Security.Cryptography;
using QLDCDKT.Function;

namespace QLDCDKT
{
    public partial class FormBaiThi : Form
    {
        public FormBaiThi()
        {
            InitializeComponent();
           
        }
        DataTable dtbbaithi = new DataTable();
        public void Dinhdangdulieu()
        {
            dtgbaithi.Columns[0].HeaderText = "Mã Bài Thi";
            dtgbaithi.Columns[1].HeaderText = "Mã Môn";
            dtgbaithi.Columns[2].HeaderText = "Mã Sinh Viên";
            dtgbaithi.Columns[0].Width=120;
            dtgbaithi.Columns[1].Width = 120;
            dtgbaithi.Columns[2].Width = 120;
            dtgbaithi.AllowUserToAddRows = false;
            dtgbaithi.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        static public void enable_control(Boolean e, Form fr)
        {
            foreach (Control ctr in fr.Controls)
            {
                if (ctr.Name.StartsWith("txt") ||  ctr.Name == "btnluu" || ctr.Name == "btnhuy"||ctr.Name=="btnbaithi"||ctr.Name=="btndone")
                {
                    ctr.Enabled = e;

                }
                if (ctr.Name == "btnadd" || ctr.Name == "btnsua" || ctr.Name == "btnxoa")
                {
                    ctr.Enabled = !e;
                }
            }
        }

        private static string Laydulieucombo(String dulieu, String table)
        {
            String sql = "SELECT " + dulieu + " FROM " + table;
            return sql;
        }
        public void laydulieubaithi()
        {
            String sql = "Select MaBaiThi,MaMon,MaSV from BaiThi";
            dtbbaithi = function.Laydulieulengird(sql);
            dtgbaithi.DataSource = dtbbaithi;
            Dinhdangdulieu();
        }


        private void FormBaiThi_Load(object sender, EventArgs e)
        {
            //laydulieubaithi();
            function.Fillcombo(Laydulieucombo("MaKhoa", "Khoa"), txtkhoa, "MaKhoa", "MaKhoa");

        }

        private void txtlop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlsinhvien = "Select MaSV from SinhVien where MaLop='" + txtlop.Text + "'";
            function.Fillcombo(sqlsinhvien, txtsv, "MaSV", "MaSV");
        }

        private void txtkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqllop = "Select MaLop from Lop where MaKhoa='" + txtkhoa.Text + "'";
            function.Fillcombo(sqllop, txtlop, "MaLop", "MaLop");
        }
        public void Dulieubaithisinhvien()
        {
            String sql = "select MaBaiThi,MaMon,MaSV from BaiThi where MaSV='" + txtsv.Text + "'";
            dtbbaithi = function.Laydulieulengird(sql);
            dtgbaithi.DataSource = dtbbaithi;
            Dinhdangdulieu();
        }
        private void txtsv_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dulieubaithisinhvien();
            string sql = "Select MaMon from DangKyMonHoc where MaSV='" + txtsv.Text + "'";
            function.Fillcombo(sql, txtmon, "MaMon", "MaMon");
        }
        public string txtanh = "";

        private void btnbaithi_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgopen = new OpenFileDialog();
            dlgopen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgopen.FilterIndex = 2;
            dlgopen.Title = "ch" +
                "ọn ảnh";
            if (dlgopen.ShowDialog() == DialogResult.OK)
            {
                picbt.Image = Image.FromFile(dlgopen.FileName);
                txtanh = dlgopen.FileName;
            }
        }
        String Capnhat = "";
        private void btnadd_Click(object sender, EventArgs e)
        {
            Capnhat = "T";
            enable_control(true,this);
            txtmabt.Clear();
            txtanh = "";
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Capnhat = "S";
            enable_control(true, this);
            txtmabt.Enabled = false;
        }

        private void btndone_Click(object sender, EventArgs e)
        {
            try
            {
                String sql = "";
                if(Capnhat=="T")
                {
                    foreach (Control ctr in this.Controls)
                    {
                        if (ctr.Name.StartsWith("txt").Equals(""))
                        {
                            MessageBox.Show("Ko được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    if(txtanh.Trim().Equals(""))
                    {
                        MessageBox.Show("Hãy chọn bài thi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    string sqlcheckkey = "SELECT MaSV,MaMon FROM BaiThi " +
                           "WHERE MaSV = '" + txtsv.Text + "' AND MaMon = '" + txtmon.Text + "'";
                    if (function.CheckKey(sqlcheckkey) == true)
                    {
                        MessageBox.Show("Đã có bài thi môn này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else 
                    {
                        sql = "INSERT INTO BaiThi VALUES('"
                        + txtmabt.Text.Trim() + "','"
                        + txtmon.Text + "','" + txtsv.Text + "','" + txtanh.Trim() + "')";
                    }
                }
                else if(Capnhat=="S")
                {
                    foreach (Control ctr in this.Controls)
                    {
                        if (ctr.Name.StartsWith("txt").Equals(""))
                        {
                            MessageBox.Show("Ko được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    if (txtanh.Trim().Equals(""))
                    {
                        MessageBox.Show("Hãy chọn bài thi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    sql = "update  BaiThi set BaiThi='" + txtanh.Trim() +
                         "' where MaBaiThi='" + txtmabt.Text + "'";
                }
                
                    function.Runsql(sql);
                    enable_control(false, this);
                    Dulieubaithisinhvien();
                    txtmabt.Clear();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmabt.Text == "")
            {
                MessageBox.Show("hãy chọn mã đăng ký môn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("bạn có muốn xóa", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql,sqlbaithi;
                sqlbaithi = "delete BaiThi where MaBaiThi='" + txtmabt.Text + "'";
                function.Runsql(sqlbaithi);
                sql = "delete DiemThi where MaBaiThi='" + txtmabt.Text + "'";
                function.Runsql(sql);
                txtmabt.Clear();
                Dulieubaithisinhvien();

            }
        }

        private void dtgbaithi_Click(object sender, EventArgs e)
        {
            txtmabt.Text = dtgbaithi.CurrentRow.Cells["MaBaiThi"].Value.ToString();
            string anh="select BaiThi from BaiThi where MaBaiThi='"+txtmabt.Text+"'";
            txtanh =function.GetFieldValues(anh);
            picbt.ImageLocation = txtanh;
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            enable_control(false, this);
            txtmabt.Clear();

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
