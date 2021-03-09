namespace QuanLysKhachSan
{
    partial class Form1
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
            this.cbmathe = new System.Windows.Forms.ComboBox();
            this.lbthanhtoan = new System.Windows.Forms.Label();
            this.gbhoadoanthanhtoan = new System.Windows.Forms.GroupBox();
            this.lbmathe = new System.Windows.Forms.Label();
            this.lbmahoadon = new System.Windows.Forms.Label();
            this.lbngayxuathoadon = new System.Windows.Forms.Label();
            this.gbchitietkh = new System.Windows.Forms.GroupBox();
            this.lbtongtien = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnhienthikh = new System.Windows.Forms.Button();
            this.btntinhtien = new System.Windows.Forms.Button();
            this.gbthanhtoan = new System.Windows.Forms.GroupBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.dataSet2 = new QuanLysKhachSan.DataSet2();
            this.thePhongThueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thePhongThueTableAdapter = new QuanLysKhachSan.DataSet2TableAdapters.ThePhongThueTableAdapter();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbmahd = new System.Windows.Forms.Label();
            this.lbngayxuathd = new System.Windows.Forms.Label();
            this.lbtinhtongtien = new System.Windows.Forms.Label();
            this.lbmt = new System.Windows.Forms.Label();
            this.gbhoadoanthanhtoan.SuspendLayout();
            this.gbchitietkh.SuspendLayout();
            this.gbthanhtoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thePhongThueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbmathe
            // 
            this.cbmathe.DataSource = this.thePhongThueBindingSource;
            this.cbmathe.DisplayMember = "mathe";
            this.cbmathe.FormattingEnabled = true;
            this.cbmathe.Location = new System.Drawing.Point(105, 29);
            this.cbmathe.Name = "cbmathe";
            this.cbmathe.Size = new System.Drawing.Size(102, 24);
            this.cbmathe.TabIndex = 0;
            // 
            // lbthanhtoan
            // 
            this.lbthanhtoan.AutoSize = true;
            this.lbthanhtoan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbthanhtoan.Location = new System.Drawing.Point(418, 9);
            this.lbthanhtoan.Name = "lbthanhtoan";
            this.lbthanhtoan.Size = new System.Drawing.Size(129, 26);
            this.lbthanhtoan.TabIndex = 1;
            this.lbthanhtoan.Text = "Thanh toán";
            this.lbthanhtoan.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbhoadoanthanhtoan
            // 
            this.gbhoadoanthanhtoan.Controls.Add(this.lbmt);
            this.gbhoadoanthanhtoan.Controls.Add(this.lbtinhtongtien);
            this.gbhoadoanthanhtoan.Controls.Add(this.lbngayxuathd);
            this.gbhoadoanthanhtoan.Controls.Add(this.lbmahd);
            this.gbhoadoanthanhtoan.Controls.Add(this.label6);
            this.gbhoadoanthanhtoan.Controls.Add(this.lbngayxuathoadon);
            this.gbhoadoanthanhtoan.Controls.Add(this.lbtongtien);
            this.gbhoadoanthanhtoan.Controls.Add(this.lbmahoadon);
            this.gbhoadoanthanhtoan.Location = new System.Drawing.Point(138, 204);
            this.gbhoadoanthanhtoan.Name = "gbhoadoanthanhtoan";
            this.gbhoadoanthanhtoan.Size = new System.Drawing.Size(804, 142);
            this.gbhoadoanthanhtoan.TabIndex = 2;
            this.gbhoadoanthanhtoan.TabStop = false;
            this.gbhoadoanthanhtoan.Text = "Hóa đơn thanh toán";
            this.gbhoadoanthanhtoan.Enter += new System.EventHandler(this.gbhoadoanthanhtoan_Enter);
            // 
            // lbmathe
            // 
            this.lbmathe.AutoSize = true;
            this.lbmathe.Location = new System.Drawing.Point(48, 29);
            this.lbmathe.Name = "lbmathe";
            this.lbmathe.Size = new System.Drawing.Size(51, 17);
            this.lbmathe.TabIndex = 3;
            this.lbmathe.Text = "Mã thẻ";
            this.lbmathe.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbmahoadon
            // 
            this.lbmahoadon.AutoSize = true;
            this.lbmahoadon.Location = new System.Drawing.Point(48, 38);
            this.lbmahoadon.Name = "lbmahoadon";
            this.lbmahoadon.Size = new System.Drawing.Size(83, 17);
            this.lbmahoadon.TabIndex = 4;
            this.lbmahoadon.Text = "Mã hóa đơn";
            // 
            // lbngayxuathoadon
            // 
            this.lbngayxuathoadon.AutoSize = true;
            this.lbngayxuathoadon.Location = new System.Drawing.Point(48, 65);
            this.lbngayxuathoadon.Name = "lbngayxuathoadon";
            this.lbngayxuathoadon.Size = new System.Drawing.Size(127, 17);
            this.lbngayxuathoadon.TabIndex = 5;
            this.lbngayxuathoadon.Text = "Ngày xuất hóa đơn";
            this.lbngayxuathoadon.Click += new System.EventHandler(this.label4_Click);
            // 
            // gbchitietkh
            // 
            this.gbchitietkh.Controls.Add(this.listView1);
            this.gbchitietkh.Location = new System.Drawing.Point(138, 365);
            this.gbchitietkh.Name = "gbchitietkh";
            this.gbchitietkh.Size = new System.Drawing.Size(804, 155);
            this.gbchitietkh.TabIndex = 6;
            this.gbchitietkh.TabStop = false;
            this.gbchitietkh.Text = "Chi tiết khách hàng";
            // 
            // lbtongtien
            // 
            this.lbtongtien.AutoSize = true;
            this.lbtongtien.Location = new System.Drawing.Point(48, 94);
            this.lbtongtien.Name = "lbtongtien";
            this.lbtongtien.Size = new System.Drawing.Size(68, 17);
            this.lbtongtien.TabIndex = 5;
            this.lbtongtien.Text = "Tổng tiền";
            this.lbtongtien.Click += new System.EventHandler(this.lbtongtien_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mã thẻ";
            // 
            // btnhienthikh
            // 
            this.btnhienthikh.Location = new System.Drawing.Point(243, 29);
            this.btnhienthikh.Name = "btnhienthikh";
            this.btnhienthikh.Size = new System.Drawing.Size(166, 24);
            this.btnhienthikh.TabIndex = 7;
            this.btnhienthikh.Text = "Hiển thị khách hàng";
            this.btnhienthikh.UseVisualStyleBackColor = true;
            this.btnhienthikh.Click += new System.EventHandler(this.btnhienthikh_Click);
            // 
            // btntinhtien
            // 
            this.btntinhtien.Location = new System.Drawing.Point(51, 76);
            this.btntinhtien.Name = "btntinhtien";
            this.btntinhtien.Size = new System.Drawing.Size(110, 26);
            this.btntinhtien.TabIndex = 8;
            this.btntinhtien.Text = "Tính tiền";
            this.btntinhtien.UseVisualStyleBackColor = true;
            this.btntinhtien.Click += new System.EventHandler(this.btntinhtien_Click);
            // 
            // gbthanhtoan
            // 
            this.gbthanhtoan.Controls.Add(this.btnthoat);
            this.gbthanhtoan.Controls.Add(this.lbmathe);
            this.gbthanhtoan.Controls.Add(this.btntinhtien);
            this.gbthanhtoan.Controls.Add(this.cbmathe);
            this.gbthanhtoan.Controls.Add(this.btnhienthikh);
            this.gbthanhtoan.Location = new System.Drawing.Point(138, 64);
            this.gbthanhtoan.Name = "gbthanhtoan";
            this.gbthanhtoan.Size = new System.Drawing.Size(804, 122);
            this.gbthanhtoan.TabIndex = 9;
            this.gbthanhtoan.TabStop = false;
            this.gbthanhtoan.Text = "Thanh toán";
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(243, 76);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(110, 26);
            this.btnthoat.TabIndex = 9;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thePhongThueBindingSource
            // 
            this.thePhongThueBindingSource.DataMember = "ThePhongThue";
            this.thePhongThueBindingSource.DataSource = this.dataSet2;
            // 
            // thePhongThueTableAdapter
            // 
            this.thePhongThueTableAdapter.ClearBeforeFill = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(51, 34);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(735, 105);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã thẻ";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã phòng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã nhân viên";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 105;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên khách hàng";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số CMT";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ngày thuê";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ngày dự kiến trả";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 119;
            // 
            // lbmahd
            // 
            this.lbmahd.AutoSize = true;
            this.lbmahd.Location = new System.Drawing.Point(240, 38);
            this.lbmahd.Name = "lbmahd";
            this.lbmahd.Size = new System.Drawing.Size(0, 17);
            this.lbmahd.TabIndex = 7;
            // 
            // lbngayxuathd
            // 
            this.lbngayxuathd.AutoSize = true;
            this.lbngayxuathd.Location = new System.Drawing.Point(240, 65);
            this.lbngayxuathd.Name = "lbngayxuathd";
            this.lbngayxuathd.Size = new System.Drawing.Size(0, 17);
            this.lbngayxuathd.TabIndex = 8;
            // 
            // lbtinhtongtien
            // 
            this.lbtinhtongtien.AutoSize = true;
            this.lbtinhtongtien.Location = new System.Drawing.Point(240, 94);
            this.lbtinhtongtien.Name = "lbtinhtongtien";
            this.lbtinhtongtien.Size = new System.Drawing.Size(0, 17);
            this.lbtinhtongtien.TabIndex = 9;
            // 
            // lbmt
            // 
            this.lbmt.AutoSize = true;
            this.lbmt.Location = new System.Drawing.Point(240, 122);
            this.lbmt.Name = "lbmt";
            this.lbmt.Size = new System.Drawing.Size(0, 17);
            this.lbmt.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 512);
            this.Controls.Add(this.gbthanhtoan);
            this.Controls.Add(this.gbchitietkh);
            this.Controls.Add(this.gbhoadoanthanhtoan);
            this.Controls.Add(this.lbthanhtoan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbhoadoanthanhtoan.ResumeLayout(false);
            this.gbhoadoanthanhtoan.PerformLayout();
            this.gbchitietkh.ResumeLayout(false);
            this.gbthanhtoan.ResumeLayout(false);
            this.gbthanhtoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thePhongThueBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbmathe;
        private System.Windows.Forms.Label lbthanhtoan;
        private System.Windows.Forms.GroupBox gbhoadoanthanhtoan;
        private System.Windows.Forms.Label lbmathe;
        private System.Windows.Forms.Label lbmahoadon;
        private System.Windows.Forms.Label lbngayxuathoadon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbtongtien;
        private System.Windows.Forms.GroupBox gbchitietkh;
        private System.Windows.Forms.Button btnhienthikh;
        private System.Windows.Forms.Button btntinhtien;
        private System.Windows.Forms.GroupBox gbthanhtoan;
        private System.Windows.Forms.Button btnthoat;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource thePhongThueBindingSource;
        private DataSet2TableAdapters.ThePhongThueTableAdapter thePhongThueTableAdapter;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label lbmt;
        private System.Windows.Forms.Label lbtinhtongtien;
        private System.Windows.Forms.Label lbngayxuathd;
        private System.Windows.Forms.Label lbmahd;
    }
}