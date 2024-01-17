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
    public partial class FormDKMon : Form
    {
        public FormDKMon()
        {
            InitializeComponent();
        }
        public void DinhdangdulieuMonhoc()
        {
            dtgMH.Columns[0].HeaderText = "Mã môn";
            dtgMH.Columns[1].HeaderText = "Tên môn";
            dtgMH.Columns[2].HeaderText = "Mã khoa";
            for (int i = 0; i < dtgMH.Columns.Count; i++)
            {
                dtgMH.Columns[i].Width = 120;
            }
            dtgMH.AllowUserToAddRows = false;
            dtgMH.EditMode = DataGridViewEditMode.EditProgrammatically;
            

        }
        public void DinhdangdulieuDKM()
        {
            dtgDK.Columns[0].HeaderText = "Mã ĐKM";
            dtgDK.Columns[1].HeaderText = "Mã Sinh viên";
            dtgDK.Columns[2].HeaderText = "Mã môn";
            for (int i = 0; i < dtgMH.Columns.Count; i++)
            {
                dtgMH.Columns[i].Width = 120;
            }
            dtgDK.AllowUserToAddRows = false;
            dtgDK.EditMode = DataGridViewEditMode.EditProgrammatically;
            

        }
        public void Laydulieumonhoc()
        {
            DataTable dtbmonhoc=new DataTable();
            String sql = "Select * from MonHoc";
            dtbmonhoc = function.Laydulieulengird(sql);
            dtgMH.DataSource=dtbmonhoc;
            DinhdangdulieuMonhoc();
        }
        public void LaydulieuDKM()
        {
            DataTable dtbdkm = new DataTable();
            String sql = "Select * from DangKyMonHoc";
            dtbdkm = function.Laydulieulengird(sql);
            dtgDK.DataSource = dtbdkm;
            DinhdangdulieuDKM();

        }
        private static string Laydulieucombo(String dulieu, String table)
        {
            String sql = "SELECT " + dulieu + " FROM " + table;
            return sql;
        }
        public void ComboMakhoa()
        {
            function.Fillcombo(Laydulieucombo("MaKhoa", "Khoa"), txtmakhoa, "MaKhoa", "MaKhoa");
        }
        public void Resetcombo()
        {
            txtmakhoa.SelectedIndex = -1;
            txtlop.SelectedIndex = -1;
            txtsv.SelectedIndex = -1;
        }

        private void FormDKMon_Load(object sender, EventArgs e)
        {
           // Laydulieumonhoc();
            LaydulieuDKM();
            ComboMakhoa();
            Resetcombo();
        }
        static public void enable_control(Boolean e, Form fr)
        {
            foreach (Control ctr in fr.Controls)
            {
                if (ctr.Name.StartsWith("txt") || ctr.Name == "btnluu" || ctr.Name == "btnhuy")
                {
                    ctr.Enabled = !e;

                }
                if (ctr.Name == "btnadd" || ctr.Name == "btnsua" || ctr.Name == "btnxoa")
                {
                    ctr.Enabled = e;
                }
            }
        }

        private void txtmakhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            String sql = "Select MaMon,TenMon from MonHoc where MaKhoa='" + txtmakhoa.Text + "'";
            DataTable dtbMH = new DataTable();
            dtbMH = function.Laydulieulengird(sql);
            dtgMH.DataSource = dtbMH;
            // Lấy dữ liệu lớp học từ mã khoa
            string sqllophoc = "SELECT Lop.MaLop " +
                "FROM Lop " +
                "INNER JOIN Khoa " +
                "ON Lop.MaKhoa = Khoa.MaKhoa " +
                "WHERE Khoa.MaKhoa = '" + txtmakhoa.Text + "'";
            function.Fillcombo(sqllophoc, txtlop, "MaLop", "MaLop");
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmon.Text=="")
                {
                    MessageBox.Show("Hãy chọn môn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtsv.Text == "")
                {
                    MessageBox.Show("Hãy chọn mã SV", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                String sql = "Insert into DangKyMonHoc values ('" + txtmadkm.Text + "','" + txtsv.Text + "','" + txtmon.Text + "')";
                string sqlcheckkey = "SELECT MaSV,MaMon FROM DangKyMonHoc " +
                            "WHERE MaSV = '" + txtsv.Text + "' AND MaMon = '" + txtmon.Text + "'";
                if (function.CheckKey(sqlcheckkey) == true)
                {
                    MessageBox.Show("Môn học đã đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (function.CheckKey(sqlcheckkey) == false)
                {
                    function.Runsql(sql);
                    dulieusvdkmh();
                    txtmadkm.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void txtlop_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy dữ liệu sinh viên  từ mã lớp
            string sqlsv = "SELECT SinhVien.MaSV " +
                "FROM SinhVien " +
                "INNER JOIN Lop " +
                "ON Lop.MaLop = SinhVien.MaLop " +
                "WHERE Lop.MaLop = '" + txtlop.Text + "'";
            function.Fillcombo(sqlsv, txtsv, "MaSV", "MaSV");
        }

        private void dtgMH_Click(object sender, EventArgs e)
        {
            txtmon.Text = dtgMH.CurrentRow.Cells["MaMon"].Value.ToString();
        }
        public void dulieusvdkmh()
        {
            DataTable dtbmonsvdk = new DataTable();
            String sql = "Select * from DangKyMonHoc where MaSV='" + txtsv.Text + "'";
            dtbmonsvdk = function.Laydulieulengird(sql);
            dtgDK.DataSource = dtbmonsvdk;
            DinhdangdulieuDKM();
        }

        private void txtsv_SelectedIndexChanged(object sender, EventArgs e)
        {
            dulieusvdkmh();
        }

        private void dtgMH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmadkm.Text=="")
            {
                MessageBox.Show("hãy chọn mã đăng ký môn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("bạn có muốn xóa", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql;
                sql = "delete DangKyMonHoc where MaDKM='" + txtmadkm.Text + "'";
                function.Runsql(sql);
                txtmadkm.Clear();
                dulieusvdkmh();
               
            }
           
        }

        private void dtgDK_Click(object sender, EventArgs e)
        {
            txtmadkm.Text = dtgDK.CurrentRow.Cells["MaDKM"].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {

        }
    }
}
