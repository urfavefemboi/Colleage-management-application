using QLDCDKT.Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLDCDKT.Function;

namespace QLDCDKT
{
    public partial class formlichdayrpt : Form
    {
        reportfunction report;
        public formlichdayrpt()
        {
            InitializeComponent();
        }
        private static string Laydulieucombo(String dulieu, String table)
        {
            String sql = "SELECT " + dulieu + " FROM " + table;
            return sql;
        }

        private void formlichdayrpt_Load(object sender, EventArgs e)
        {
            function.Fillcombo(Laydulieucombo("MaKhoa", "Khoa"), txtkhoa, "MaKhoa", "MaKhoa");
         
            this.reportViewer1.RefreshReport();

           
        }

        private void txtkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqllop = "Select MaLop from Lop where MaKhoa='" + txtkhoa.Text + "'";
            function.Fillcombo(sqllop, txtlop, "MaLop", "MaLop");           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT MaGV,MaNH,MaHK,MaMon,MaLop " +
               "FROM LichDay " +              
               "WHERE MaLop = '" + txtlop.Text + "'";
            report = new reportfunction("lichdaydataset", "QLDCDKT.report.lichdayrpt.rdlc", sql, reportViewer1);
            report.handleShowReport();
        }
    }
}
