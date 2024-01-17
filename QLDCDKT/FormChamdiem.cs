using QLDCDKT.Function;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLDCDKT
{
    public partial class FormChamdiem : Form
    {
        public FormChamdiem()
        {
            InitializeComponent();
        }

        static public void enable_control(Boolean e, Form fr)
        {
            foreach (Control ctr in fr.Controls)
            {
                if (ctr.Name.StartsWith("txtdiem") || ctr.Name == "btnluu" || ctr.Name == "btnhuy" || ctr.Name == "btnbaithi" || ctr.Name == "btndone")
                {
                    ctr.Enabled = e;

                }
                if (ctr.Name == "btnadd" || ctr.Name == "btnsua" || ctr.Name == "btnxoa")
                {
                    ctr.Enabled = !e;
                }
            }
        }
        public void Dinhdangdulieudiemthi()
        {
            dtgdiemthi.Columns[0].HeaderText = "Mã bài thi";
            dtgdiemthi.Columns[1].HeaderText = "Điểm thi";
            dtgdiemthi.Columns[2].HeaderText = "Điểm TBTP";
            dtgdiemthi.Columns[3].HeaderText = "Tổng điểm";
            dtgdiemthi.Columns[4].HeaderText = "Xếp loại";
            for (int i = 0; i < dtgdiemthi.Columns.Count; i++)
            {
                dtgdiemthi.Columns[i].Width = 100;
            }
            dtgdiemthi.AllowUserToAddRows = false;
            dtgdiemthi.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        public void Dinhdangdulieubaithi()
        {
            dtgbaithi.Columns[0].HeaderText = "Mã bài thi";
            dtgbaithi.Columns[1].HeaderText = "Mã môn";
            for (int i = 0; i < dtgbaithi.Columns.Count; i++)
            {
                dtgbaithi.Columns[i].Width = 100;
            }
            dtgbaithi.AllowUserToAddRows = false;
            dtgbaithi.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        public void Laydulieudiemthi()
        {
            DataTable dtbdiemthi = new DataTable();
            String sql = "select * from DiemThi ";
            dtbdiemthi = function.Laydulieulengird(sql);
            dtgdiemthi.DataSource = dtbdiemthi;
            Dinhdangdulieudiemthi();
        }
        private static string Laydulieucombo(String dulieu, String table)
        {
            String sql = "SELECT " + dulieu + " FROM " + table;
            return sql;
        }

        private void FormChamdiem_Load(object sender, EventArgs e)
        {
            Laydulieudiemthi();
            function.Fillcombo(Laydulieucombo("MaKhoa", "Khoa"), txtkhoa, "MaKhoa", "MaKhoa");
        }
       

        private void txtmon_SelectedIndexChanged(object sender, EventArgs e)
        {
            // lấy dữ liệu bài thi
            DataTable dtbbaithi = new DataTable();
            string sql = "select MaBaiThi, MaMon from BaiThi where MaMon='" + txtmon.Text + "'";
            dtbbaithi = function.Laydulieulengird(sql);
            dtgbaithi.DataSource = dtbbaithi;
            Dinhdangdulieubaithi();

            //lấy dữ liệu diem thi
           
           
        }

        private void dtgbaithi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public string txtanh = "";
        private void dtgbaithi_Click(object sender, EventArgs e)
        {
            txtmabt.Text = dtgbaithi.CurrentRow.Cells["MaBaiThi"].Value.ToString();
            string anh = "select BaiThi from BaiThi where MaBaiThi='" + txtmabt.Text + "'";
            txtanh = function.GetFieldValues(anh);
            picbt.ImageLocation = txtanh;
            Cleartext();
        }

        private void txtkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "Select MaMon from MonHoc where MaKhoa='" + txtkhoa.Text + "'";
            function.Fillcombo(sql, txtmon, "MaMon", "MaMon");
        }

        private void txtrf_Click(object sender, EventArgs e)
        {
            Laydulieudiemthi();
        }
        string Capnhat = "";
        private void btnadd_Click(object sender, EventArgs e)
        {
            Capnhat = "T";
            enable_control(true, this);
            Cleartext();
        }

        private void txtdiem_TextChanged(object sender, EventArgs e)
        {
            double diem, diemtb, tong;
            if (txtdiem.Text == "")
            {
                diem = 0;
            }
            else
            {
                diem = Convert.ToDouble(txtdiem.Text);
            }
            if (txtdiemtb.Text == "")
            {
                diemtb = 0;
            }
            else
            {
                diemtb = Convert.ToDouble(txtdiemtb.Text);
            }
            tong = Math.Ceiling((diem + diemtb) / 2) * 10 / 10;
            txttong.Text = tong.ToString();

        }

        private void txttong_TextChanged(object sender, EventArgs e)
        {
            double xl;
            if(txttong.Text=="")
            {
                xl = 0;
            }
            else
            {
                xl = Convert.ToDouble(txttong.Text);
            }
                if (xl >= 8.5)
                {
                    txtxl.Text = "A";
                }
                else if (xl >= 7 && xl <= 8.4)
                {
                    txtxl.Text = "B";
                }
                else if (xl >= 5.5 && xl <= 6.9)
                {
                    txtxl.Text = "C";
                }
                else if (xl < 5.4)
                {
                    txtxl.Text = "D";
                }
            
        }

        private void txtdiemtb_TextChanged(object sender, EventArgs e)
        {
            double diem, diemtb, tong;
            if (txtdiem.Text == "")
            {
                diem = 0;
            }
            else
            {
                diem = Convert.ToDouble(txtdiem.Text);
            }
            if (txtdiemtb.Text == "")
            {
                diemtb = 0;
            }
            else
            {
                diemtb = Convert.ToDouble(txtdiemtb.Text);
            }
            tong = Math.Ceiling((diem + diemtb) / 2) * 10 / 10;
            txttong.Text = tong.ToString();

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Capnhat = "S";
            enable_control(true, this);
        }
        public void Cleartext()
        {           
            txtdiem.Clear();
            txtdiemtb.Clear();
            txttong.Clear();
            txtxl.Clear();    
        }

        private void btndone_Click(object sender, EventArgs e)
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
                    }             
                    string sqlcheckkey = "SELECT MaBaiThi FROM DiemThi " +
                           "WHERE MaBaiThi = '" + txtmabt.Text + "'";
                    if (function.CheckKey(sqlcheckkey) == true)
                    {
                        MessageBox.Show("Đã có điểm thi môn này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else 
                    {
                        sql = "INSERT INTO DiemThi VALUES('"
                        + txtmabt.Text + "','"
                        + txtdiem.Text + "','" + txtdiemtb.Text + "','" + txttong.Text + "','" + txtxl.Text + "')";
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
                    sql = "update  DiemThi set DiemThi='" + txtdiem.Text +
                         "',DiemTBTP='" + txtdiemtb.Text + "',TongDiem='" + txttong.Text +
                         "',XepLoai='" + txtxl.Text + "' where MaBaiThi='" + txtmabt.Text + "'";
                }            
                     function.Runsql(sql);
                    enable_control(false, this);
                    Laydulieudiemthi();
                    Cleartext();
                    txtmabt.Clear();
                    txtanh = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dtgdiemthi_Click(object sender, EventArgs e)
        {
            txtmabt.Text = dtgdiemthi.CurrentRow.Cells["MaBaiThi"].Value.ToString();
            txtdiem.Text = dtgdiemthi.CurrentRow.Cells["DiemThi"].Value.ToString();
            txtdiemtb.Text = dtgdiemthi.CurrentRow.Cells["DiemTBTP"].Value.ToString();
            txttong.Text = dtgdiemthi.CurrentRow.Cells["TongDiem"].Value.ToString();
            txtxl.Text = dtgdiemthi.CurrentRow.Cells["XepLoai"].Value.ToString();
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
                string sql;
                sql = "delete DiemThi where MaBaiThi='" + txtmabt.Text + "'";
                function.Runsql(sql);
                txtmabt.Clear();
                Dinhdangdulieudiemthi();
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            enable_control(false, this);
            Cleartext();
            txtmabt.Clear();
            txtanh = "";
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
