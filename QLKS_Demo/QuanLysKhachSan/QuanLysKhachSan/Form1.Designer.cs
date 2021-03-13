namespace QuanLysKhachSan
{
    partial class frmthanhtoan
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
            this.gbthanhtoan = new System.Windows.Forms.GroupBox();
            this.cbmathe = new System.Windows.Forms.ComboBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btntinhtien = new System.Windows.Forms.Button();
            this.btnhienthikh = new System.Windows.Forms.Button();
            this.lbmathe = new System.Windows.Forms.Label();
            this.thePhongThueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new QuanLysKhachSan.DataSet1();
            this.gbhoadonthanhtoan = new System.Windows.Forms.GroupBox();
            this.lbmt = new System.Windows.Forms.Label();
            this.lbtinhtongtien = new System.Windows.Forms.Label();
            this.lbngayxuathd = new System.Windows.Forms.Label();
            this.lbmahd = new System.Windows.Forms.Label();
            this.lbmthe = new System.Windows.Forms.Label();
            this.lbtongtien = new System.Windows.Forms.Label();
            this.lbngayxuathoadon = new System.Windows.Forms.Label();
            this.lbmahoadon = new System.Windows.Forms.Label();
            this.gbchitietkh = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbTT = new System.Windows.Forms.Label();
            this.thePhongThueTableAdapter = new QuanLysKhachSan.DataSet1TableAdapters.ThePhongThueTableAdapter();
            this.buttonIn = new System.Windows.Forms.Button();
            this.gbthanhtoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thePhongThueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.gbhoadonthanhtoan.SuspendLayout();
            this.gbchitietkh.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbthanhtoan
            // 
            this.gbthanhtoan.Controls.Add(this.cbmathe);
            this.gbthanhtoan.Controls.Add(this.btnthoat);
            this.gbthanhtoan.Controls.Add(this.btntinhtien);
            this.gbthanhtoan.Controls.Add(this.btnhienthikh);
            this.gbthanhtoan.Controls.Add(this.lbmathe);
            this.gbthanhtoan.Location = new System.Drawing.Point(67, 42);
            this.gbthanhtoan.Margin = new System.Windows.Forms.Padding(2);
            this.gbthanhtoan.Name = "gbthanhtoan";
            this.gbthanhtoan.Padding = new System.Windows.Forms.Padding(2);
            this.gbthanhtoan.Size = new System.Drawing.Size(638, 81);
            this.gbthanhtoan.TabIndex = 0;
            this.gbthanhtoan.TabStop = false;
            this.gbthanhtoan.Text = "Thanh toán";
            // 
            // cbmathe
            // 
            this.cbmathe.FormattingEnabled = true;
            this.cbmathe.Location = new System.Drawing.Point(132, 21);
            this.cbmathe.Margin = new System.Windows.Forms.Padding(2);
            this.cbmathe.Name = "cbmathe";
            this.cbmathe.Size = new System.Drawing.Size(80, 21);
            this.cbmathe.TabIndex = 4;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(292, 58);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(71, 19);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btntinhtien
            // 
            this.btntinhtien.Location = new System.Drawing.Point(132, 58);
            this.btntinhtien.Margin = new System.Windows.Forms.Padding(2);
            this.btntinhtien.Name = "btntinhtien";
            this.btntinhtien.Size = new System.Drawing.Size(80, 19);
            this.btntinhtien.TabIndex = 2;
            this.btntinhtien.Text = "Tính tiền";
            this.btntinhtien.UseVisualStyleBackColor = true;
            this.btntinhtien.Click += new System.EventHandler(this.btntinhtien_Click);
            // 
            // btnhienthikh
            // 
            this.btnhienthikh.Location = new System.Drawing.Point(292, 24);
            this.btnhienthikh.Margin = new System.Windows.Forms.Padding(2);
            this.btnhienthikh.Name = "btnhienthikh";
            this.btnhienthikh.Size = new System.Drawing.Size(133, 19);
            this.btnhienthikh.TabIndex = 1;
            this.btnhienthikh.Text = "Hiển thị khách hàng";
            this.btnhienthikh.UseVisualStyleBackColor = true;
            this.btnhienthikh.Click += new System.EventHandler(this.btnhienthikh_Click);
            // 
            // lbmathe
            // 
            this.lbmathe.AutoSize = true;
            this.lbmathe.Location = new System.Drawing.Point(61, 24);
            this.lbmathe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbmathe.Name = "lbmathe";
            this.lbmathe.Size = new System.Drawing.Size(40, 13);
            this.lbmathe.TabIndex = 0;
            this.lbmathe.Text = "Mã thẻ";
            // 
            // thePhongThueBindingSource
            // 
            this.thePhongThueBindingSource.DataMember = "ThePhongThue";
            this.thePhongThueBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbhoadonthanhtoan
            // 
            this.gbhoadonthanhtoan.Controls.Add(this.buttonIn);
            this.gbhoadonthanhtoan.Controls.Add(this.lbmt);
            this.gbhoadonthanhtoan.Controls.Add(this.lbtinhtongtien);
            this.gbhoadonthanhtoan.Controls.Add(this.lbngayxuathd);
            this.gbhoadonthanhtoan.Controls.Add(this.lbmahd);
            this.gbhoadonthanhtoan.Controls.Add(this.lbmthe);
            this.gbhoadonthanhtoan.Controls.Add(this.lbtongtien);
            this.gbhoadonthanhtoan.Controls.Add(this.lbngayxuathoadon);
            this.gbhoadonthanhtoan.Controls.Add(this.lbmahoadon);
            this.gbhoadonthanhtoan.Location = new System.Drawing.Point(67, 142);
            this.gbhoadonthanhtoan.Margin = new System.Windows.Forms.Padding(2);
            this.gbhoadonthanhtoan.Name = "gbhoadonthanhtoan";
            this.gbhoadonthanhtoan.Padding = new System.Windows.Forms.Padding(2);
            this.gbhoadonthanhtoan.Size = new System.Drawing.Size(638, 126);
            this.gbhoadonthanhtoan.TabIndex = 1;
            this.gbhoadonthanhtoan.TabStop = false;
            this.gbhoadonthanhtoan.Text = "Hóa đơn thanh toán";
            // 
            // lbmt
            // 
            this.lbmt.AutoSize = true;
            this.lbmt.Location = new System.Drawing.Point(226, 95);
            this.lbmt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbmt.Name = "lbmt";
            this.lbmt.Size = new System.Drawing.Size(0, 13);
            this.lbmt.TabIndex = 7;
            // 
            // lbtinhtongtien
            // 
            this.lbtinhtongtien.AutoSize = true;
            this.lbtinhtongtien.Location = new System.Drawing.Point(226, 74);
            this.lbtinhtongtien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtinhtongtien.Name = "lbtinhtongtien";
            this.lbtinhtongtien.Size = new System.Drawing.Size(0, 13);
            this.lbtinhtongtien.TabIndex = 6;
            this.lbtinhtongtien.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbngayxuathd
            // 
            this.lbngayxuathd.AutoSize = true;
            this.lbngayxuathd.Location = new System.Drawing.Point(226, 52);
            this.lbngayxuathd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbngayxuathd.Name = "lbngayxuathd";
            this.lbngayxuathd.Size = new System.Drawing.Size(0, 13);
            this.lbngayxuathd.TabIndex = 5;
            // 
            // lbmahd
            // 
            this.lbmahd.AutoSize = true;
            this.lbmahd.Location = new System.Drawing.Point(226, 31);
            this.lbmahd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbmahd.Name = "lbmahd";
            this.lbmahd.Size = new System.Drawing.Size(0, 13);
            this.lbmahd.TabIndex = 4;
            // 
            // lbmthe
            // 
            this.lbmthe.AutoSize = true;
            this.lbmthe.Location = new System.Drawing.Point(61, 95);
            this.lbmthe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbmthe.Name = "lbmthe";
            this.lbmthe.Size = new System.Drawing.Size(40, 13);
            this.lbmthe.TabIndex = 3;
            this.lbmthe.Text = "Mã thẻ";
            // 
            // lbtongtien
            // 
            this.lbtongtien.AutoSize = true;
            this.lbtongtien.Location = new System.Drawing.Point(61, 74);
            this.lbtongtien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtongtien.Name = "lbtongtien";
            this.lbtongtien.Size = new System.Drawing.Size(52, 13);
            this.lbtongtien.TabIndex = 2;
            this.lbtongtien.Text = "Tổng tiền";
            // 
            // lbngayxuathoadon
            // 
            this.lbngayxuathoadon.AutoSize = true;
            this.lbngayxuathoadon.Location = new System.Drawing.Point(61, 52);
            this.lbngayxuathoadon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbngayxuathoadon.Name = "lbngayxuathoadon";
            this.lbngayxuathoadon.Size = new System.Drawing.Size(98, 13);
            this.lbngayxuathoadon.TabIndex = 1;
            this.lbngayxuathoadon.Text = "Ngày xuất hóa đơn";
            this.lbngayxuathoadon.Click += new System.EventHandler(this.lbngayxuathoadon_Click);
            // 
            // lbmahoadon
            // 
            this.lbmahoadon.AutoSize = true;
            this.lbmahoadon.Location = new System.Drawing.Point(61, 31);
            this.lbmahoadon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbmahoadon.Name = "lbmahoadon";
            this.lbmahoadon.Size = new System.Drawing.Size(65, 13);
            this.lbmahoadon.TabIndex = 0;
            this.lbmahoadon.Text = "Mã hóa đơn";
            // 
            // gbchitietkh
            // 
            this.gbchitietkh.Controls.Add(this.listView1);
            this.gbchitietkh.Location = new System.Drawing.Point(67, 284);
            this.gbchitietkh.Margin = new System.Windows.Forms.Padding(2);
            this.gbchitietkh.Name = "gbchitietkh";
            this.gbchitietkh.Padding = new System.Windows.Forms.Padding(2);
            this.gbchitietkh.Size = new System.Drawing.Size(638, 163);
            this.gbchitietkh.TabIndex = 1;
            this.gbchitietkh.TabStop = false;
            this.gbchitietkh.Text = "Chi tiết khách hàng";
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
            this.listView1.Location = new System.Drawing.Point(63, 17);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(527, 130);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã thẻ";
            this.columnHeader1.Width = 67;
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
            this.columnHeader3.Width = 109;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên khách hàng";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 108;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số CMT";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 98;
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
            this.columnHeader7.Width = 114;
            // 
            // lbTT
            // 
            this.lbTT.AutoSize = true;
            this.lbTT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTT.Location = new System.Drawing.Point(292, 7);
            this.lbTT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTT.Name = "lbTT";
            this.lbTT.Size = new System.Drawing.Size(109, 22);
            this.lbTT.TabIndex = 2;
            this.lbTT.Text = "Thanh Toán";
            // 
            // thePhongThueTableAdapter
            // 
            this.thePhongThueTableAdapter.ClearBeforeFill = true;
            // 
            // buttonIn
            // 
            this.buttonIn.Location = new System.Drawing.Point(514, 52);
            this.buttonIn.Name = "buttonIn";
            this.buttonIn.Size = new System.Drawing.Size(75, 23);
            this.buttonIn.TabIndex = 8;
            this.buttonIn.Text = "In hóa đơn";
            this.buttonIn.UseVisualStyleBackColor = true;
            this.buttonIn.Click += new System.EventHandler(this.buttonIn_Click);
            // 
            // frmthanhtoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 464);
            this.Controls.Add(this.lbTT);
            this.Controls.Add(this.gbchitietkh);
            this.Controls.Add(this.gbhoadonthanhtoan);
            this.Controls.Add(this.gbthanhtoan);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmthanhtoan";
            this.Text = "Formthanhtoan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbthanhtoan.ResumeLayout(false);
            this.gbthanhtoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thePhongThueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.gbhoadonthanhtoan.ResumeLayout(false);
            this.gbhoadonthanhtoan.PerformLayout();
            this.gbchitietkh.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbthanhtoan;
        private System.Windows.Forms.ComboBox cbmathe;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btntinhtien;
        private System.Windows.Forms.Button btnhienthikh;
        private System.Windows.Forms.Label lbmathe;
        private System.Windows.Forms.GroupBox gbhoadonthanhtoan;
        private System.Windows.Forms.GroupBox gbchitietkh;
        private System.Windows.Forms.Label lbTT;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource thePhongThueBindingSource;
        private DataSet1TableAdapters.ThePhongThueTableAdapter thePhongThueTableAdapter;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label lbmthe;
        private System.Windows.Forms.Label lbtongtien;
        private System.Windows.Forms.Label lbngayxuathoadon;
        private System.Windows.Forms.Label lbmahoadon;
        private System.Windows.Forms.Label lbmt;
        private System.Windows.Forms.Label lbtinhtongtien;
        private System.Windows.Forms.Label lbngayxuathd;
        private System.Windows.Forms.Label lbmahd;
        private System.Windows.Forms.Button buttonIn;
    }
}