namespace QLDCDKT
{
    partial class RptDiemthi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptDiemthi));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtkhoa = new System.Windows.Forms.ComboBox();
            this.txtmon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txttk = new System.Windows.Forms.TextBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.qLDCDKTDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDCDKTDataSet = new QLDCDKT.QLDCDKTDataSet();
            this.BaithisinhvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLDCDKTDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDCDKTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaithisinhvienBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(134, 40);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(634, 339);
            this.reportViewer1.TabIndex = 0;
            // 
            // txtkhoa
            // 
            this.txtkhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtkhoa.FormattingEnabled = true;
            this.txtkhoa.Location = new System.Drawing.Point(9, 32);
            this.txtkhoa.Name = "txtkhoa";
            this.txtkhoa.Size = new System.Drawing.Size(121, 21);
            this.txtkhoa.TabIndex = 1;
            this.txtkhoa.SelectedIndexChanged += new System.EventHandler(this.txtkhoa_SelectedIndexChanged);
            // 
            // txtmon
            // 
            this.txtmon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtmon.FormattingEnabled = true;
            this.txtmon.Location = new System.Drawing.Point(145, 32);
            this.txtmon.Name = "txtmon";
            this.txtmon.Size = new System.Drawing.Size(121, 21);
            this.txtmon.TabIndex = 2;
            this.txtmon.SelectedIndexChanged += new System.EventHandler(this.txtmon_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã Môn";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(613, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 32);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tìm mã môn";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(38, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(922, 625);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(914, 599);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Báo cáo sinh viên thi lại";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtmon);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtkhoa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(321, 418);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 80);
            this.panel1.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.btntimkiem);
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(914, 599);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Báo cáo điểm tổng từng sinh viên";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // reportViewer2
            // 
            this.reportViewer2.Location = new System.Drawing.Point(79, 33);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(781, 434);
            this.reportViewer2.TabIndex = 0;
            this.reportViewer2.Load += new System.EventHandler(this.reportViewer2_Load_1);
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(35, 25);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(100, 20);
            this.txttk.TabIndex = 1;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btntimkiem.Image")));
            this.btntimkiem.Location = new System.Drawing.Point(549, 516);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(38, 33);
            this.btntimkiem.TabIndex = 2;
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click_1);
            // 
            // qLDCDKTDataSetBindingSource
            // 
            this.qLDCDKTDataSetBindingSource.DataSource = this.qLDCDKTDataSet;
            this.qLDCDKTDataSetBindingSource.Position = 0;
            // 
            // qLDCDKTDataSet
            // 
            this.qLDCDKTDataSet.DataSetName = "QLDCDKTDataSet";
            this.qLDCDKTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BaithisinhvienBindingSource
            // 
            this.BaithisinhvienBindingSource.DataMember = "Baithisinhvien";
            this.BaithisinhvienBindingSource.DataSource = this.qLDCDKTDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhap ma sinh vien can tim";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txttk);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(374, 491);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 58);
            this.panel2.TabIndex = 4;
            // 
            // RptDiemthi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(998, 649);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RptDiemthi";
            this.Text = "RptDiemthi";
            this.Load += new System.EventHandler(this.RptDiemthi_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qLDCDKTDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDCDKTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaithisinhvienBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox txtkhoa;
        private System.Windows.Forms.ComboBox txtmon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource qLDCDKTDataSetBindingSource;
        private QLDCDKTDataSet qLDCDKTDataSet;
        private System.Windows.Forms.BindingSource BaithisinhvienBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
    }
}