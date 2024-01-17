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
    public partial class formdssinhvien : Form
    {
        reportfunction report;

        public formdssinhvien()
        {
            InitializeComponent();
        }

        private void formdssinhvien_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql= "select * from SinhVien where MaSV like '%"+txttk.Text+"%'or MaLop like'%"+txttk.Text+"%' or TenSV like'%"+txttk.Text+"%'";
            report=new reportfunction("dssinhviendataset", "QLDCDKT.report.dssinhvienrpt.rdlc",sql,reportViewer1);
            report.handleShowReport();
        }

        private void txttk_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
