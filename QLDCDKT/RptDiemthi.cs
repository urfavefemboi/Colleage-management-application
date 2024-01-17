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
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Interfaces;
using System.Data.Entity.Core.Mapping;

namespace QLDCDKT
{
    public partial class RptDiemthi : Form
    {
        reportfunction report;
        public RptDiemthi()
        {
            InitializeComponent();
        }
        private static string Laydulieucombo(String dulieu, String table)
        {
            String sql = "SELECT " + dulieu + " FROM " + table;
            return sql;
        }


        private void RptDiemthi_Load(object sender, EventArgs e)
        {
            function.Fillcombo(Laydulieucombo("MaKhoa", "Khoa"), txtkhoa, "MaKhoa", "MaKhoa");
            this.reportViewer1.RefreshReport();

            this.reportViewer2.RefreshReport();
        }

        private void txtkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqllop = "Select MaMon from MonHoc where MaKhoa='" + txtkhoa.Text + "'";
            function.Fillcombo(sqllop, txtmon, "MaMon", "MaMon");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT BaiThi.MaSV,BaiThi.MaBaiThi,DiemThi.DiemThi,DiemThi.XepLoai " +
                "FROM BaiThi " +
                "INNER JOIN DiemThi " +
                "ON BaiThi.MaBaiThi = DiemThi.MaBaiThi " +
                "WHERE BaiThi.MaMon = '" + txtmon.Text + "'and DiemThi.TongDiem<=5";
           report = new reportfunction("DiemThiDataSet", "QLDCDKT.report.rptDiemthi.rdlc",sql,reportViewer1);
            report.handleShowReport();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {                                                                                                                                                          
           
        }

        private void txtlop_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txttk_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtmon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer2_Load_1(object sender, EventArgs e)
        {

        }

        private void btntimkiem_Click_1(object sender, EventArgs e)
        {
            string sql = "select  BaiThi.MaSV, DiemThi.MaBaiThi, BaiThi.MaMon, DiemThi.TongDiem" +
                " from BaiThi " +                                       
                "INNER JOIN DiemThi " +
                "ON BaiThi.MaBaiThi = DiemThi.MaBaiThi " +
                "WHERE BaiThi.MaSV like '%"
                + txttk.Text + "%'";
            report = new reportfunction("dtbtongdataset", "QLDCDKT.report.dtbtong.rdlc", sql, reportViewer2);
            report.handleShowReport();
        }
    }
}
