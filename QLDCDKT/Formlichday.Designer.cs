namespace QLDCDKT
{
    partial class Formlichday
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formlichday));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlichday = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmakhoa = new System.Windows.Forms.ComboBox();
            this.txtnh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmagv = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmon = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txthk = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsotiet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtgLD = new System.Windows.Forms.DataGridView();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtlop = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(365, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lịch dạy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã lịch dạy";
            // 
            // txtlichday
            // 
            this.txtlichday.Enabled = false;
            this.txtlichday.Location = new System.Drawing.Point(176, 82);
            this.txtlichday.Name = "txtlichday";
            this.txtlichday.Size = new System.Drawing.Size(100, 20);
            this.txtlichday.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã khoa";
            // 
            // txtmakhoa
            // 
            this.txtmakhoa.Enabled = false;
            this.txtmakhoa.FormattingEnabled = true;
            this.txtmakhoa.Location = new System.Drawing.Point(176, 137);
            this.txtmakhoa.Name = "txtmakhoa";
            this.txtmakhoa.Size = new System.Drawing.Size(100, 21);
            this.txtmakhoa.TabIndex = 4;
            this.txtmakhoa.SelectedIndexChanged += new System.EventHandler(this.txtmakhoa_SelectedIndexChanged);
            // 
            // txtnh
            // 
            this.txtnh.Enabled = false;
            this.txtnh.FormattingEnabled = true;
            this.txtnh.Location = new System.Drawing.Point(600, 83);
            this.txtnh.Name = "txtnh";
            this.txtnh.Size = new System.Drawing.Size(100, 21);
            this.txtnh.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã NH";
            // 
            // txtmagv
            // 
            this.txtmagv.Enabled = false;
            this.txtmagv.FormattingEnabled = true;
            this.txtmagv.Location = new System.Drawing.Point(384, 83);
            this.txtmagv.Name = "txtmagv";
            this.txtmagv.Size = new System.Drawing.Size(100, 21);
            this.txtmagv.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã GV";
            // 
            // txtmon
            // 
            this.txtmon.Enabled = false;
            this.txtmon.FormattingEnabled = true;
            this.txtmon.Location = new System.Drawing.Point(600, 137);
            this.txtmon.Name = "txtmon";
            this.txtmon.Size = new System.Drawing.Size(100, 21);
            this.txtmon.TabIndex = 8;
            this.txtmon.SelectedIndexChanged += new System.EventHandler(this.txtmon_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(546, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mã Môn";
            // 
            // txthk
            // 
            this.txthk.Enabled = false;
            this.txthk.FormattingEnabled = true;
            this.txthk.Location = new System.Drawing.Point(384, 140);
            this.txthk.Name = "txthk";
            this.txthk.Size = new System.Drawing.Size(100, 21);
            this.txthk.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(330, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mã HK";
            // 
            // txtsotiet
            // 
            this.txtsotiet.Enabled = false;
            this.txtsotiet.Location = new System.Drawing.Point(600, 191);
            this.txtsotiet.Name = "txtsotiet";
            this.txtsotiet.Size = new System.Drawing.Size(100, 20);
            this.txtsotiet.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(546, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Số tiết";
            // 
            // dtgLD
            // 
            this.dtgLD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLD.Location = new System.Drawing.Point(82, 229);
            this.dtgLD.Name = "dtgLD";
            this.dtgLD.Size = new System.Drawing.Size(690, 227);
            this.dtgLD.TabIndex = 15;
            this.dtgLD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLD_CellClick);
            this.dtgLD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLD_CellContentClick);
            this.dtgLD.Click += new System.EventHandler(this.dtgLD_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Enabled = false;
            this.btnhuy.Image = ((System.Drawing.Image)(resources.GetObject("btnhuy.Image")));
            this.btnhuy.Location = new System.Drawing.Point(466, 462);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(42, 34);
            this.btnhuy.TabIndex = 31;
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.Location = new System.Drawing.Point(514, 462);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(42, 34);
            this.btnthoat.TabIndex = 30;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.Location = new System.Drawing.Point(370, 462);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(42, 34);
            this.btnxoa.TabIndex = 29;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.Enabled = false;
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.Location = new System.Drawing.Point(418, 462);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(42, 34);
            this.btnluu.TabIndex = 28;
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.Location = new System.Drawing.Point(322, 462);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(42, 34);
            this.btnsua.TabIndex = 27;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnadd
            // 
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.Location = new System.Drawing.Point(274, 462);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(42, 34);
            this.btnadd.TabIndex = 26;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtlop
            // 
            this.txtlop.Enabled = false;
            this.txtlop.FormattingEnabled = true;
            this.txtlop.Location = new System.Drawing.Point(176, 191);
            this.txtlop.Name = "txtlop";
            this.txtlop.Size = new System.Drawing.Size(100, 21);
            this.txtlop.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(122, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Mã Lớp";
            // 
            // Formlichday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(835, 534);
            this.Controls.Add(this.txtlop);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dtgLD);
            this.Controls.Add(this.txthk);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtsotiet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtmagv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmakhoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtlichday);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Formlichday";
            this.Text = "Formlichday";
            this.Load += new System.EventHandler(this.Formlichday_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlichday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtmakhoa;
        private System.Windows.Forms.ComboBox txtnh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtmagv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtmon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txthk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsotiet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtgLD;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ComboBox txtlop;
        private System.Windows.Forms.Label label9;
    }
}