namespace QLDCDKT
{
    partial class FormChamdiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChamdiem));
            this.txtmabt = new System.Windows.Forms.TextBox();
            this.txtmon = new System.Windows.Forms.ComboBox();
            this.btndone = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtkhoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picbt = new System.Windows.Forms.PictureBox();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dtgbaithi = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.dtgdiemthi = new System.Windows.Forms.DataGridView();
            this.txtrf = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txttong = new System.Windows.Forms.TextBox();
            this.txtdiemtb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtxl = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgbaithi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdiemthi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmabt
            // 
            this.txtmabt.Enabled = false;
            this.txtmabt.Location = new System.Drawing.Point(1170, 130);
            this.txtmabt.Name = "txtmabt";
            this.txtmabt.Size = new System.Drawing.Size(100, 20);
            this.txtmabt.TabIndex = 101;
            // 
            // txtmon
            // 
            this.txtmon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtmon.FormattingEnabled = true;
            this.txtmon.Location = new System.Drawing.Point(83, 190);
            this.txtmon.Name = "txtmon";
            this.txtmon.Size = new System.Drawing.Size(100, 21);
            this.txtmon.TabIndex = 100;
            this.txtmon.SelectedIndexChanged += new System.EventHandler(this.txtmon_SelectedIndexChanged);
            // 
            // btndone
            // 
            this.btndone.Enabled = false;
            this.btndone.Image = ((System.Drawing.Image)(resources.GetObject("btndone.Image")));
            this.btndone.Location = new System.Drawing.Point(711, 267);
            this.btndone.Name = "btndone";
            this.btndone.Size = new System.Drawing.Size(45, 32);
            this.btndone.TabIndex = 99;
            this.btndone.UseVisualStyleBackColor = true;
            this.btndone.Click += new System.EventHandler(this.btndone_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 98;
            this.label4.Text = "Mã môn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1190, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 96;
            this.label3.Text = "Mã Bài Thi";
            // 
            // txtkhoa
            // 
            this.txtkhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtkhoa.FormattingEnabled = true;
            this.txtkhoa.Location = new System.Drawing.Point(83, 137);
            this.txtkhoa.Name = "txtkhoa";
            this.txtkhoa.Size = new System.Drawing.Size(100, 21);
            this.txtkhoa.TabIndex = 95;
            this.txtkhoa.SelectedIndexChanged += new System.EventHandler(this.txtkhoa_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 94;
            this.label2.Text = "Mã khoa";
            // 
            // picbt
            // 
            this.picbt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbt.Location = new System.Drawing.Point(1144, 156);
            this.picbt.Name = "picbt";
            this.picbt.Size = new System.Drawing.Size(161, 163);
            this.picbt.TabIndex = 93;
            this.picbt.TabStop = false;
            // 
            // btnsua
            // 
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.Location = new System.Drawing.Point(609, 267);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(45, 32);
            this.btnsua.TabIndex = 92;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Enabled = false;
            this.btnhuy.Image = ((System.Drawing.Image)(resources.GetObject("btnhuy.Image")));
            this.btnhuy.Location = new System.Drawing.Point(660, 267);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(45, 32);
            this.btnhuy.TabIndex = 91;
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.Location = new System.Drawing.Point(793, 375);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(45, 32);
            this.btnthoat.TabIndex = 90;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.Location = new System.Drawing.Point(1066, 375);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(45, 32);
            this.btnxoa.TabIndex = 89;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnadd
            // 
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.Location = new System.Drawing.Point(561, 267);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(45, 32);
            this.btnadd.TabIndex = 88;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dtgbaithi
            // 
            this.dtgbaithi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgbaithi.Location = new System.Drawing.Point(189, 113);
            this.dtgbaithi.Name = "dtgbaithi";
            this.dtgbaithi.Size = new System.Drawing.Size(318, 256);
            this.dtgbaithi.TabIndex = 87;
            this.dtgbaithi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgbaithi_CellContentClick);
            this.dtgbaithi.Click += new System.EventHandler(this.dtgbaithi_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(574, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 29);
            this.label8.TabIndex = 111;
            this.label8.Text = "CHẤM ĐIỂM";
            // 
            // dtgdiemthi
            // 
            this.dtgdiemthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdiemthi.Location = new System.Drawing.Point(793, 113);
            this.dtgdiemthi.Name = "dtgdiemthi";
            this.dtgdiemthi.Size = new System.Drawing.Size(318, 256);
            this.dtgdiemthi.TabIndex = 112;
            this.dtgdiemthi.Click += new System.EventHandler(this.dtgdiemthi_Click);
            // 
            // txtrf
            // 
            this.txtrf.Image = ((System.Drawing.Image)(resources.GetObject("txtrf.Image")));
            this.txtrf.Location = new System.Drawing.Point(1066, 80);
            this.txtrf.Name = "txtrf";
            this.txtrf.Size = new System.Drawing.Size(45, 32);
            this.txtrf.TabIndex = 113;
            this.txtrf.UseVisualStyleBackColor = true;
            this.txtrf.Click += new System.EventHandler(this.txtrf_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(693, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 105;
            this.label5.Text = "Điểm TBTP";
            // 
            // txttong
            // 
            this.txttong.Enabled = false;
            this.txttong.Location = new System.Drawing.Point(561, 228);
            this.txttong.Name = "txttong";
            this.txttong.Size = new System.Drawing.Size(55, 20);
            this.txttong.TabIndex = 106;
            this.txttong.TextChanged += new System.EventHandler(this.txttong_TextChanged);
            // 
            // txtdiemtb
            // 
            this.txtdiemtb.Enabled = false;
            this.txtdiemtb.Location = new System.Drawing.Point(696, 156);
            this.txtdiemtb.Name = "txtdiemtb";
            this.txtdiemtb.Size = new System.Drawing.Size(59, 20);
            this.txtdiemtb.TabIndex = 104;
            this.txtdiemtb.TextChanged += new System.EventHandler(this.txtdiemtb_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(558, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 107;
            this.label7.Text = "Tổng điểm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 103;
            this.label1.Text = "Điểm thi";
            // 
            // txtdiem
            // 
            this.txtdiem.Enabled = false;
            this.txtdiem.Location = new System.Drawing.Point(561, 160);
            this.txtdiem.Name = "txtdiem";
            this.txtdiem.Size = new System.Drawing.Size(42, 20);
            this.txtdiem.TabIndex = 102;
            this.txtdiem.TextChanged += new System.EventHandler(this.txtdiem_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(693, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 109;
            this.label6.Text = "Xếp loại";
            // 
            // txtxl
            // 
            this.txtxl.Enabled = false;
            this.txtxl.Location = new System.Drawing.Point(696, 228);
            this.txtxl.Name = "txtxl";
            this.txtxl.Size = new System.Drawing.Size(59, 20);
            this.txtxl.TabIndex = 108;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(186, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 114;
            this.label9.Text = "Bài thi";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(790, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 115;
            this.label10.Text = "Điểm thi";
            // 
            // FormChamdiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1365, 495);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtxl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtrf);
            this.Controls.Add(this.txtdiem);
            this.Controls.Add(this.dtgdiemthi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtdiemtb);
            this.Controls.Add(this.txtmabt);
            this.Controls.Add(this.txttong);
            this.Controls.Add(this.txtmon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btndone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtkhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picbt);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dtgbaithi);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormChamdiem";
            this.Text = "FormChamdiem";
            this.Load += new System.EventHandler(this.FormChamdiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgbaithi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdiemthi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmabt;
        private System.Windows.Forms.ComboBox txtmon;
        private System.Windows.Forms.Button btndone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtkhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picbt;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dtgbaithi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtgdiemthi;
        private System.Windows.Forms.Button txtrf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttong;
        private System.Windows.Forms.TextBox txtdiemtb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtxl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}