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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace QLDCDKT
{
    public partial class Formlichday : Form
    {
        public Formlichday()
        {
            InitializeComponent();
        }
        private void Dinhdangdulieu()
        {
            dtgLD.Columns[0].HeaderText = "Mã lịch dạy";
            dtgLD.Columns[1].HeaderText = "Mã Giáo viên";
            dtgLD.Columns[2].HeaderText = "Mã Năm học";
            dtgLD.Columns[3].HeaderText = "Mã Học Kỳ";
            dtgLD.Columns[4].HeaderText = "Mã Môn";
            dtgLD.Columns[5].HeaderText = "Mã lớp";
            dtgLD.Columns[6].HeaderText = "Số tiết";
            for(int i=0;i<dtgLD.Columns.Count;i++)
            {
                dtgLD.Columns[i].Width = 120;
            }
            dtgLD.AllowUserToAddRows = false;
            dtgLD.EditMode = DataGridViewEditMode.EditProgrammatically;
            
        }
        
        private void Laydulieulengrid()
        {
            DataTable dtbLD=new DataTable();
            String sql = "Select * from LichDay";
            dtbLD = function.Laydulieulengird(sql);
            dtgLD.DataSource=dtbLD;
            Dinhdangdulieu();
        }
        private static string Laydulieucombo(String dulieu, String table)
        {
            String sql = "SELECT " + dulieu + " FROM "  + table;
            return sql;
        }
        static public void enable_control(Boolean e, Form fr)
        {
            foreach (Control ctr in fr.Controls)
            {
                if (ctr.Name.StartsWith("txt") ||  ctr.Name == "btnluu" || ctr.Name == "btnhuy")
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
        public void Comboboxdrop()
        {
            txtmakhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            txtlop.DropDownStyle = ComboBoxStyle.DropDownList;
            txtnh.DropDownStyle = ComboBoxStyle.DropDownList;
            txthk.DropDownStyle = ComboBoxStyle.DropDownList;
            txtmagv.DropDownStyle = ComboBoxStyle.DropDownList;
            txtmon.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        public void Comboboxreset()
        {
            txtmakhoa.SelectedIndex = -1;
            txtmagv.SelectedIndex = -1;
            txtnh.SelectedIndex = -1;
            txthk.SelectedIndex = -1;
            txtlop.SelectedIndex = -1;
            txtmon.SelectedIndex = -1;
        }

        private void Formlichday_Load(object sender, EventArgs e)
        {
            Laydulieulengrid();
            function.Fillcombo(Laydulieucombo("MaKhoa", "Khoa"), txtmakhoa, "MaKhoa", "MaKhoa");
            function.Fillcombo(Laydulieucombo("MaNH", "NamHoc"), txtnh, "MaNH", "MaNH");
            function.Fillcombo(Laydulieucombo("MaHK", "HocKy"), txthk, "MaHK", "MaHK");
          //  Comboboxdrop();
            Comboboxreset();

        }

        private void txtmakhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            // lấy dữ liệu giáo vien từ mã khoa
            string sqlgv = "SELECT GiaoVien.MaGV " +                  
                "FROM GiaoVien " +
                "INNER JOIN Khoa " +
                "ON GiaoVien.MaKhoa = Khoa.MaKhoa " +
                "WHERE Khoa.MaKhoa = '" + txtmakhoa.Text + "'";
            function.Fillcombo(sqlgv, txtmagv, "MaGV", "MaGV");

            // lấy dữ liệu môn học từ mã khoa
            string sqlmonhoc = "SELECT MonHoc.MaMon " +
                "FROM MonHoc " +
                "INNER JOIN Khoa " +
                "ON MonHoc.MaKhoa = Khoa.MaKhoa " +
                "WHERE Khoa.MaKhoa = '" + txtmakhoa.Text + "'";
            function.Fillcombo(sqlmonhoc, txtmon, "MaMon", "MaMon");

            // Lấy dữ liệu lớp học từ mã khoa
            string sqllophoc = "SELECT Lop.MaLop " +
                "FROM Lop " +
                "INNER JOIN Khoa " +
                "ON Lop.MaKhoa = Khoa.MaKhoa " +
                "WHERE Khoa.MaKhoa = '" + txtmakhoa.Text + "'";
            function.Fillcombo(sqllophoc, txtlop, "MaLop", "MaLop");
        }

        private void txtmon_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            if(txtlichday.Text=="")
            {
                MessageBox.Show("hãy chọn mã lịch dạy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }    
            Capnhat = "S";
            enable_control(true, this);
            txtlichday.Enabled=false;
            txtmakhoa.Enabled=false;
            txtlop.Enabled = false;
            txthk.Enabled = false;
            txtnh.Enabled = false;
            txtmon.Enabled = false;
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
                    }
                    bool isNumeric = int.TryParse(txtsotiet.Text.Trim(), out int n);
                    if (isNumeric == false)
                    {
                        MessageBox.Show("Số tiết không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                        txtsotiet.Focus();
                    }
                    bool isNegative = double.TryParse(txtsotiet.Text.Trim(), out double number) && number < 0;
                    if (isNumeric == false)
                    {
                        MessageBox.Show("Số tiết không được để dưới 0 ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                        txtsotiet.Focus();
                    }
                    sql = "Insert into LichDay values ('" + txtlichday.Text + "','" + txtmagv.Text + "','" + txtnh.Text
                        + "','" + txthk.Text + "','" + txtmon.Text +
                        "','" + txtlop.Text + "','" + txtsotiet.Text.Trim() + "')";
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
                    bool isNumeric = int.TryParse(txtsotiet.Text.Trim(), out int n);
                    if (isNumeric == false)
                    {
                        MessageBox.Show("Số tiết không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                        txtsotiet.Focus();
                    }
                    bool isNegative = double.TryParse(txtsotiet.Text.Trim(), out double number) && number < 0;
                    if (isNumeric == true)
                    {
                        MessageBox.Show("Số tiết không được để dưới 0 ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                        txtsotiet.Focus();
                    }
                    sql = "update  LichDay set MaGV='" + txtmagv.Text +
                        "',MaNH='" + txtnh.Text + "',MaHK='" + txthk.Text +
                        "',MaMon='" + txtmon.Text + "',MaLop='" + txtlop.Text +
                        "',SoTiet='" + txtsotiet.Text + "' where MaGV='" + txtmagv.Text + "'";
                }
                // lệnh kiểm tra lịch trùng
                string sqlcheckkey = "SELECT MaNH, MaHK, MaMon, MaLop FROM LichDay " +
                       "WHERE MaNH = '" + txtnh.Text + "' AND MaHK = '" + txthk.Text +
                       "' AND MaMon = '" + txtmon.Text +
                       "' AND MaLop = '" + txtlop.Text + "'";
                if (function.CheckKey(sqlcheckkey) == true)
                {
                    MessageBox.Show("Lịch dạy đã bị trùng hãy chọn lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if(function.CheckKey(sqlcheckkey)==false)
                {
                    function.Runsql(sql);
                    Laydulieulengrid();
                    Cleartext();
                }    

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.ToString());
            }
            enable_control(false, this);
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            Cleartext();
            enable_control(false, this);
            Capnhat = "";
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmagv.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("bạn có muốn xóa", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql;
                sql = "delete LichDay where MaLichDay='" + txtlichday.Text + "'";
                function.Runsql(sql);
                Cleartext();
                Laydulieulengrid();
            }
        }

        private void dtgLD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dtgLD_Click(object sender, EventArgs e)
        {
            
        }

        private void dtgLD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtlichday.Text = dtgLD.CurrentRow.Cells["MaLichDay"].Value.ToString();
            txtmagv.Text = dtgLD.CurrentRow.Cells["MaGV"].Value.ToString();
            txtnh.Text = dtgLD.CurrentRow.Cells["MaNH"].Value.ToString();
            txthk.Text = dtgLD.CurrentRow.Cells["MaHK"].Value.ToString();
           txtmon.Text = dtgLD.CurrentRow.Cells["MaMon"].Value.ToString();
            txtlop.Text = dtgLD.CurrentRow.Cells["MaLop"].Value.ToString();
            txtsotiet.Text = dtgLD.CurrentRow.Cells["SoTiet"].Value.ToString();
            string sqlmakhoa = "select MaKhoa from GiaoVien where MaGV='" + txtmagv.Text + "'";
            txtmakhoa.Text = function.GetFieldValues(sqlmakhoa);
           
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
