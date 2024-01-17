namespace QLDCDKT
{
    partial class FormBaiThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBaiThi));
            this.txtlop = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsv = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgbaithi = new System.Windows.Forms.DataGridView();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.picbt = new System.Windows.Forms.PictureBox();
            this.txtkhoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnbaithi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btndone = new System.Windows.Forms.Button();
            this.txtmon = new System.Windows.Forms.ComboBox();
            this.txtmabt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgbaithi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbt)).BeginInit();
            this.SuspendLayout();
            // 
            // txtlop
            // 
            this.txtlop.FormattingEnabled = true;
            this.txtlop.Location = new System.Drawing.Point(868, 105);
            this.txtlop.Name = "txtlop";
            this.txtlop.Size = new System.Drawing.Size(100, 21);
            this.txtlop.TabIndex = 63;
            this.txtlop.SelectedIndexChanged += new System.EventHandler(this.txtlop_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(817, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "Mã Lớp";
            // 
            // txtsv
            // 
            this.txtsv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtsv.FormattingEnabled = true;
            this.txtsv.Location = new System.Drawing.Point(147, 156);
            this.txtsv.Name = "txtsv";
            this.txtsv.Size = new System.Drawing.Size(100, 21);
            this.txtsv.TabIndex = 61;
            this.txtsv.SelectedIndexChanged += new System.EventHandler(this.txtsv_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Mã Sinh viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(439, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 64;
            this.label1.Text = "BÀI THI";
            // 
            // dtgbaithi
            // 
            this.dtgbaithi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgbaithi.Location = new System.Drawing.Point(545, 132);
            this.dtgbaithi.Name = "dtgbaithi";
            this.dtgbaithi.Size = new System.Drawing.Size(434, 256);
            this.dtgbaithi.TabIndex = 65;
            this.dtgbaithi.Click += new System.EventHandler(this.dtgbaithi_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Enabled = false;
            this.btnhuy.Image = ((System.Drawing.Image)(resources.GetObject("btnhuy.Image")));
            this.btnhuy.Location = new System.Drawing.Point(827, 394);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(44, 34);
            this.btnhuy.TabIndex = 70;
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.Location = new System.Drawing.Point(877, 394);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(46, 34);
            this.btnthoat.TabIndex = 69;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.Location = new System.Drawing.Point(727, 394);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(44, 34);
            this.btnxoa.TabIndex = 68;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnadd
            // 
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.Location = new System.Drawing.Point(625, 394);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(46, 34);
            this.btnadd.TabIndex = 67;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.Location = new System.Drawing.Point(677, 394);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(44, 34);
            this.btnsua.TabIndex = 71;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // picbt
            // 
            this.picbt.Location = new System.Drawing.Point(310, 156);
            this.picbt.Name = "picbt";
            this.picbt.Size = new System.Drawing.Size(138, 142);
            this.picbt.TabIndex = 72;
            this.picbt.TabStop = false;
            // 
            // txtkhoa
            // 
            this.txtkhoa.FormattingEnabled = true;
            this.txtkhoa.Location = new System.Drawing.Point(604, 105);
            this.txtkhoa.Name = "txtkhoa";
            this.txtkhoa.Size = new System.Drawing.Size(100, 21);
            this.txtkhoa.TabIndex = 74;
            this.txtkhoa.SelectedIndexChanged += new System.EventHandler(this.txtkhoa_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(553, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Mã khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "Mã Bài Thi";
            // 
            // btnbaithi
            // 
            this.btnbaithi.Enabled = false;
            this.btnbaithi.Location = new System.Drawing.Point(342, 304);
            this.btnbaithi.Name = "btnbaithi";
            this.btnbaithi.Size = new System.Drawing.Size(75, 23);
            this.btnbaithi.TabIndex = 77;
            this.btnbaithi.Text = "Gửi bài";
            this.btnbaithi.UseVisualStyleBackColor = true;
            this.btnbaithi.Click += new System.EventHandler(this.btnbaithi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 78;
            this.label4.Text = "Mã môn";
            // 
            // btndone
            // 
            this.btndone.Enabled = false;
            this.btndone.Image = ((System.Drawing.Image)(resources.GetObject("btndone.Image")));
            this.btndone.Location = new System.Drawing.Point(777, 394);
            this.btndone.Name = "btndone";
            this.btndone.Size = new System.Drawing.Size(44, 34);
            this.btndone.TabIndex = 80;
            this.btndone.UseVisualStyleBackColor = true;
            this.btndone.Click += new System.EventHandler(this.btndone_Click);
            // 
            // txtmon
            // 
            this.txtmon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtmon.FormattingEnabled = true;
            this.txtmon.Location = new System.Drawing.Point(147, 203);
            this.txtmon.Name = "txtmon";
            this.txtmon.Size = new System.Drawing.Size(100, 21);
            this.txtmon.TabIndex = 81;
            // 
            // txtmabt
            // 
            this.txtmabt.Enabled = false;
            this.txtmabt.Location = new System.Drawing.Point(147, 245);
            this.txtmabt.Name = "txtmabt";
            this.txtmabt.Size = new System.Drawing.Size(100, 20);
            this.txtmabt.TabIndex = 82;
            // 
            // FormBaiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1043, 462);
            this.Controls.Add(this.txtmabt);
            this.Controls.Add(this.txtmon);
            this.Controls.Add(this.btndone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnbaithi);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtlop);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtsv);
            this.Controls.Add(this.label9);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBaiThi";
            this.Text = "FormBaiThi";
            this.Load += new System.EventHandler(this.FormBaiThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgbaithi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox txtlop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txtsv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgbaithi;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.PictureBox picbt;
        private System.Windows.Forms.ComboBox txtkhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnbaithi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btndone;
        private System.Windows.Forms.ComboBox txtmon;
        private System.Windows.Forms.TextBox txtmabt;
    }
}