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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool IsFormOpen(Type formType)
        {
            foreach (Form form in Application.OpenForms)
                if (form.GetType().Name == formType.Name)
                    return true;
            return false;
        }

    private void Form1_Load(object sender, EventArgs e)
        {
            function.Connect();
            
        }

        private void thôngTinGVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!IsFormOpen(typeof(FormTTgiaovien)))
           {
                FormTTgiaovien fr = new FormTTgiaovien();
                fr.MdiParent = this;
                fr.Show();
            }
            else
            {
                MessageBox.Show("Form đã được mở", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }    
        }

        private void thôngTinSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen(typeof(FormTTSinhvien)))
            {
                FormTTSinhvien fr = new FormTTSinhvien();
                fr.MdiParent = this;
                fr.Show();
            }
            else
            {
                MessageBox.Show("Form đã được mở", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void lịchDạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!IsFormOpen(typeof(Formlichday)))
            {
                Formlichday fr = new Formlichday();
                fr.MdiParent = this;
                fr.Show();
            }
            else
            {
                MessageBox.Show("Form đã được mở", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void đăngKýMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!IsFormOpen(typeof(FormDKMon)))
            {
                FormDKMon fr = new FormDKMon();
                fr.MdiParent = this;
                fr.Show();
            }    
             else
            {
                MessageBox.Show("Form đã được mở", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void bàiThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!IsFormOpen(typeof(FormBaiThi)))
            {
                FormBaiThi fr = new FormBaiThi();
                fr.MdiParent = this;
                fr.Show();
            }    
             else
            {
                MessageBox.Show("Form đã được mở", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void chấmĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen(typeof(FormChamdiem)))
            {
                FormChamdiem fr = new FormChamdiem();
                fr.MdiParent = this;
                fr.Show();
            }                
             else
            {
                MessageBox.Show("Form đã được mở", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void điểmThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen(typeof(RptDiemthi)))
            {
                RptDiemthi fr = new RptDiemthi();
                fr.MdiParent = this;
                fr.Show();
            }                    
             else
            {
                MessageBox.Show("Form đã được mở", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void lịchDạyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen(typeof(formlichdayrpt)))
            {
                formlichdayrpt fr = new formlichdayrpt();
                fr.MdiParent = this;
                fr.Show();
            }                  
             else
            {
                MessageBox.Show("Form đã được mở", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void danhSáchGVSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen(typeof(formdssinhvien)))
            {
                formdssinhvien fr = new formdssinhvien();
                fr.MdiParent = this;
                fr.Show();
            }           
             else
            {
                MessageBox.Show("Form đã được mở", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }
    }
}
