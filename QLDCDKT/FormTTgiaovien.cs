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
    public partial class FormTTgiaovien : Form
    {
        public FormTTgiaovien()
        {
            InitializeComponent();
        }
        public void Dinhdangdulieu()
        {
            dtgGV.Columns[0].HeaderText = "Mã giáo viên";
            dtgGV.Columns[1].HeaderText = "Tên giáo viên";
            dtgGV.Columns[2].HeaderText = "Ngày sinh";
            dtgGV.Columns[3].HeaderText = "Giới tính";
            dtgGV.Columns[4].HeaderText = "Địa chỉ";
            dtgGV.Columns[5].HeaderText = "SĐT";
            dtgGV.Columns[6].HeaderText = "Mã khoa";
            for(int i=0;i<dtgGV.Columns.Count;i++)
            {
                dtgGV.Columns[i].Width = 120;
            }
            dtgGV.AllowUserToAddRows = false;
            dtgGV.EditMode = DataGridViewEditMode.EditProgrammatically;
            

        }
        
        static public void enable_control(Boolean e, Form fr)
        {
            foreach (Control ctr in fr.Controls)
            {
                if (ctr.Name.StartsWith("txt") || ctr.Name.StartsWith("rdo") || ctr.Name == "btnluu" || ctr.Name == "btnhuy")
                {
                    ctr.Enabled = e;

                }
                if (ctr.Name == "btnadd" || ctr.Name == "btnsua" || ctr.Name == "btnxoa" )
                {
                    ctr.Enabled = !e;
                }
            }
        }
            public void Laydulieulengrid()
        {
            DataTable dtbgv;
            dtbgv = new DataTable();
            string sql = "Select * from GiaoVien";
            dtbgv = function.Laydulieulengird(sql);
            dtgGV.DataSource = dtbgv;
            Dinhdangdulieu();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void FormTTgiaovien_Load(object sender, EventArgs e)
        {
            Laydulieulengrid();
            string sqlmakhoa = "Select MaKhoa from Khoa";
            function.Fillcombo(sqlmakhoa, txtkhoa, "MaKhoa", "MaKhoa");
            
            
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
            if (txtmagv.Text == "")
            {
                MessageBox.Show("hãy chọn mã giáo viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Capnhat = "S";
            enable_control(true, this);
            txtmagv.Enabled = false;
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
                    String gt = "";
                    if (rdonu.Checked == true)
                    {
                        gt = "F";
                    }
                    else if (rdonam.Checked == true)
                    {
                        gt = "M";
                    }
                    string sqlcheckkey = "SELECT MaGV FROM GiaoVien " +
                            "WHERE MaGV = '" + txtmagv.Text +"'";
                    if (function.CheckKey(sqlcheckkey) == true)
                    {
                        MessageBox.Show("Trùng mã gv", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        sql = "INSERT INTO GiaoVien VALUES('" + txtmagv.Text + "','"
                            + txtten.Text + "','" + txtns.Text + "','" + gt + "','" + txtdc.Text + "','"
                            + txtsdt.Text + "','" + txtkhoa.Text + "')";
                    }
                }
                else
                    if (Capnhat == "S")
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
                    if (rdonu.Checked == true)
                    {
                        gt = "F";
                    }
                    else if (rdonam.Checked == true)
                    {
                        gt = "M";
                    }
                    sql = "update  GiaoVien set TenGV='" + txtten.Text +
                        "',GioiTinh='" + gt + "',DiaChi='" + txtdc.Text +
                        "',SDT='" + txtsdt.Text + "',MaKhoa='" + txtkhoa.Text +
                        "',NgaySinh='" + txtns.Text + "' where MaGV='" + txtmagv.Text + "'";
                }
                function.Runsql(sql);
                Laydulieulengrid();
                Cleartext();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            enable_control(false, this);
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
        private void btnhuy_Click(object sender, EventArgs e)
        {
            Cleartext();
            enable_control(false, this);
            Capnhat = "";
        }

        private void dtgGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmagv.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập mã nghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("bạn có muốn xóa", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql;
                sql = "delete GiaoVien where MaGV='" + txtmagv.Text + "'";
                function.Runsql(sql);
                Cleartext();
                Laydulieulengrid();
            }
        }

        private void dtgGV_Click(object sender, EventArgs e)
        {
            txtmagv.Text = dtgGV.CurrentRow.Cells["MaGV"].Value.ToString();
            txtten.Text = dtgGV.CurrentRow.Cells["TenGV"].Value.ToString();
            txtns.Text = dtgGV.CurrentRow.Cells["NgaySinh"].Value.ToString();
            if (dtgGV.CurrentRow.Cells["GioiTinh"].Value.ToString() == "M")
            {
                rdonam.Checked = true;
            }
            else if (dtgGV.CurrentRow.Cells["GioiTinh"].Value.ToString() == "F")
            {
                rdonu.Checked = true;
            }
            txtdc.Text = dtgGV.CurrentRow.Cells["DiaChi"].Value.ToString();
            txtsdt.Text = dtgGV.CurrentRow.Cells["SDT"].Value.ToString();
            txtkhoa.Text = dtgGV.CurrentRow.Cells["MaKhoa"].Value.ToString();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
