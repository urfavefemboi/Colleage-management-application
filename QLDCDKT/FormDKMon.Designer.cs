namespace QLDCDKT
{
    partial class FormDKMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDKMon));
            this.txtsv = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtmadkm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dtgMH = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgDK = new System.Windows.Forms.DataGridView();
            this.txtmon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmakhoa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtlop = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDK)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsv
            // 
            this.txtsv.FormattingEnabled = true;
            this.txtsv.Location = new System.Drawing.Point(839, 438);
            this.txtsv.Name = "txtsv";
            this.txtsv.Size = new System.Drawing.Size(100, 21);
            this.txtsv.TabIndex = 39;
            this.txtsv.SelectedIndexChanged += new System.EventHandler(this.txtsv_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(764, 441);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Mã Sinh viên";
            // 
            // txtmadkm
            // 
            this.txtmadkm.Location = new System.Drawing.Point(335, 121);
            this.txtmadkm.Name = "txtmadkm";
            this.txtmadkm.Size = new System.Drawing.Size(100, 20);
            this.txtmadkm.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Mã ĐKM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(396, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 29);
            this.label1.TabIndex = 40;
            this.label1.Text = "ĐĂNG KÝ MÔN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Enabled = false;
            this.btnhuy.Image = ((System.Drawing.Image)(resources.GetObject("btnhuy.Image")));
            this.btnhuy.Location = new System.Drawing.Point(480, 309);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(42, 38);
            this.btnhuy.TabIndex = 47;
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.Location = new System.Drawing.Point(480, 353);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(42, 34);
            this.btnthoat.TabIndex = 46;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.Location = new System.Drawing.Point(480, 268);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(42, 35);
            this.btnxoa.TabIndex = 45;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Honeydew;
            this.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.Location = new System.Drawing.Point(480, 224);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(42, 38);
            this.btnadd.TabIndex = 42;
            this.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dtgMH
            // 
            this.dtgMH.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dtgMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMH.Location = new System.Drawing.Point(126, 207);
            this.dtgMH.Name = "dtgMH";
            this.dtgMH.Size = new System.Drawing.Size(309, 227);
            this.dtgMH.TabIndex = 41;
            this.dtgMH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMH_CellContentClick);
            this.dtgMH.Click += new System.EventHandler(this.dtgMH_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Bảng môn học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(565, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "DS môn sinh viên đăng ký";
            // 
            // dtgDK
            // 
            this.dtgDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDK.Location = new System.Drawing.Point(568, 207);
            this.dtgDK.Name = "dtgDK";
            this.dtgDK.Size = new System.Drawing.Size(371, 227);
            this.dtgDK.TabIndex = 52;
            this.dtgDK.Click += new System.EventHandler(this.dtgDK_Click);
            // 
            // txtmon
            // 
            this.txtmon.Enabled = false;
            this.txtmon.Location = new System.Drawing.Point(570, 117);
            this.txtmon.Name = "txtmon";
            this.txtmon.Size = new System.Drawing.Size(100, 20);
            this.txtmon.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(519, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Mã môn";
            // 
            // txtmakhoa
            // 
            this.txtmakhoa.FormattingEnabled = true;
            this.txtmakhoa.Location = new System.Drawing.Point(182, 438);
            this.txtmakhoa.Name = "txtmakhoa";
            this.txtmakhoa.Size = new System.Drawing.Size(100, 21);
            this.txtmakhoa.TabIndex = 57;
            this.txtmakhoa.SelectedIndexChanged += new System.EventHandler(this.txtmakhoa_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 441);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Mã khoa";
            // 
            // txtlop
            // 
            this.txtlop.FormattingEnabled = true;
            this.txtlop.Location = new System.Drawing.Point(616, 438);
            this.txtlop.Name = "txtlop";
            this.txtlop.Size = new System.Drawing.Size(100, 21);
            this.txtlop.TabIndex = 59;
            this.txtlop.SelectedIndexChanged += new System.EventHandler(this.txtlop_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(567, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Mã Lớp";
            // 
            // FormDKMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(984, 556);
            this.Controls.Add(this.txtlop);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtmakhoa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtmon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgDK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dtgMH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsv);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtmadkm);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDKMon";
            this.Text = "FormDKMon";
            this.Load += new System.EventHandler(this.FormDKMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtsv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtmadkm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dtgMH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgDK;
        private System.Windows.Forms.TextBox txtmon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtmakhoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtlop;
        private System.Windows.Forms.Label label7;
    }
}