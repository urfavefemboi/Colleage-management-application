namespace QLDCDKT
{
    partial class FormTTgiaovien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTTgiaovien));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmagv = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtgGV = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.txtns = new System.Windows.Forms.DateTimePicker();
            this.txtkhoa = new System.Windows.Forms.ComboBox();
            this.rdonu = new System.Windows.Forms.RadioButton();
            this.rdonam = new System.Windows.Forms.RadioButton();
            this.btnhuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(323, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin Giáo Viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã giáo viên";
            // 
            // txtmagv
            // 
            this.txtmagv.Enabled = false;
            this.txtmagv.Location = new System.Drawing.Point(307, 92);
            this.txtmagv.Name = "txtmagv";
            this.txtmagv.Size = new System.Drawing.Size(99, 20);
            this.txtmagv.TabIndex = 2;
            // 
            // txtten
            // 
            this.txtten.Enabled = false;
            this.txtten.Location = new System.Drawing.Point(307, 145);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(99, 20);
            this.txtten.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên giáo viên";
            // 
            // txtsdt
            // 
            this.txtsdt.Enabled = false;
            this.txtsdt.Location = new System.Drawing.Point(540, 145);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(99, 20);
            this.txtsdt.TabIndex = 8;
            this.txtsdt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "SĐT";
            // 
            // txtdc
            // 
            this.txtdc.Enabled = false;
            this.txtdc.Location = new System.Drawing.Point(540, 92);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(99, 20);
            this.txtdc.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(467, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Giới tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ngày sinh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(467, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Mã khoa";
            // 
            // dtgGV
            // 
            this.dtgGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGV.Location = new System.Drawing.Point(67, 293);
            this.dtgGV.Name = "dtgGV";
            this.dtgGV.Size = new System.Drawing.Size(796, 291);
            this.dtgGV.TabIndex = 15;
            this.dtgGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgGV_CellContentClick);
            this.dtgGV.Click += new System.EventHandler(this.dtgGV_Click);
            // 
            // btnadd
            // 
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.Location = new System.Drawing.Point(302, 590);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(42, 35);
            this.btnadd.TabIndex = 16;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.Location = new System.Drawing.Point(350, 590);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(42, 35);
            this.btnsua.TabIndex = 17;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.Location = new System.Drawing.Point(398, 590);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(42, 35);
            this.btnxoa.TabIndex = 19;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.Enabled = false;
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.Location = new System.Drawing.Point(446, 590);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(42, 35);
            this.btnluu.TabIndex = 18;
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.Location = new System.Drawing.Point(540, 590);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(40, 35);
            this.btnthoat.TabIndex = 20;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // txtns
            // 
            this.txtns.Enabled = false;
            this.txtns.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtns.Location = new System.Drawing.Point(307, 196);
            this.txtns.Name = "txtns";
            this.txtns.Size = new System.Drawing.Size(103, 20);
            this.txtns.TabIndex = 21;
            // 
            // txtkhoa
            // 
            this.txtkhoa.Enabled = false;
            this.txtkhoa.FormattingEnabled = true;
            this.txtkhoa.Location = new System.Drawing.Point(540, 199);
            this.txtkhoa.Name = "txtkhoa";
            this.txtkhoa.Size = new System.Drawing.Size(99, 21);
            this.txtkhoa.TabIndex = 22;
            // 
            // rdonu
            // 
            this.rdonu.AutoSize = true;
            this.rdonu.Enabled = false;
            this.rdonu.Location = new System.Drawing.Point(307, 252);
            this.rdonu.Name = "rdonu";
            this.rdonu.Size = new System.Drawing.Size(31, 17);
            this.rdonu.TabIndex = 23;
            this.rdonu.TabStop = true;
            this.rdonu.Text = "F";
            this.rdonu.UseVisualStyleBackColor = true;
            // 
            // rdonam
            // 
            this.rdonam.AutoSize = true;
            this.rdonam.Enabled = false;
            this.rdonam.Location = new System.Drawing.Point(344, 252);
            this.rdonam.Name = "rdonam";
            this.rdonam.Size = new System.Drawing.Size(34, 17);
            this.rdonam.TabIndex = 24;
            this.rdonam.TabStop = true;
            this.rdonam.Text = "M";
            this.rdonam.UseVisualStyleBackColor = true;
            // 
            // btnhuy
            // 
            this.btnhuy.Enabled = false;
            this.btnhuy.Image = ((System.Drawing.Image)(resources.GetObject("btnhuy.Image")));
            this.btnhuy.Location = new System.Drawing.Point(494, 590);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(40, 35);
            this.btnhuy.TabIndex = 25;
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // FormTTgiaovien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(907, 649);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.rdonam);
            this.Controls.Add(this.rdonu);
            this.Controls.Add(this.txtkhoa);
            this.Controls.Add(this.txtns);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dtgGV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmagv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTTgiaovien";
            this.Text = "FormTTgiaovien";
            this.Load += new System.EventHandler(this.FormTTgiaovien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmagv;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtgGV;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.DateTimePicker txtns;
        private System.Windows.Forms.ComboBox txtkhoa;
        private System.Windows.Forms.RadioButton rdonu;
        private System.Windows.Forms.RadioButton rdonam;
        private System.Windows.Forms.Button btnhuy;
    }
}