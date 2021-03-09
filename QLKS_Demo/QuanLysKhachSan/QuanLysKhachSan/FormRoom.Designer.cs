namespace QuanLysKhachSan
{
    partial class FormRoom
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpKind = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnDeleteK = new System.Windows.Forms.Button();
            this.btnAddK = new System.Windows.Forms.Button();
            this.btnEditK = new System.Windows.Forms.Button();
            this.btnShowK = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txbIDKind = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgvKind = new System.Windows.Forms.DataGridView();
            this.tpRoom = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnDeleteR = new System.Windows.Forms.Button();
            this.btnAddR = new System.Windows.Forms.Button();
            this.btnEditR = new System.Windows.Forms.Button();
            this.btnShowR = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbNameRoom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbIDKind = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbIDRoom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgvRoom = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tpKind.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKind)).BeginInit();
            this.tpRoom.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpKind);
            this.tabControl1.Controls.Add(this.tpRoom);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(490, 611);
            this.tabControl1.TabIndex = 0;
            // 
            // tpKind
            // 
            this.tpKind.Controls.Add(this.panel5);
            this.tpKind.Location = new System.Drawing.Point(4, 25);
            this.tpKind.Name = "tpKind";
            this.tpKind.Padding = new System.Windows.Forms.Padding(3);
            this.tpKind.Size = new System.Drawing.Size(482, 582);
            this.tpKind.TabIndex = 0;
            this.tpKind.Text = "Loại Phòng";
            this.tpKind.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel12);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.dtgvKind);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(477, 575);
            this.panel5.TabIndex = 4;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnDeleteK);
            this.panel12.Controls.Add(this.btnAddK);
            this.panel12.Controls.Add(this.btnEditK);
            this.panel12.Controls.Add(this.btnShowK);
            this.panel12.Location = new System.Drawing.Point(0, 240);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(473, 69);
            this.panel12.TabIndex = 10;
            // 
            // btnDeleteK
            // 
            this.btnDeleteK.AutoSize = true;
            this.btnDeleteK.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDeleteK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeleteK.Location = new System.Drawing.Point(367, 20);
            this.btnDeleteK.Name = "btnDeleteK";
            this.btnDeleteK.Size = new System.Drawing.Size(75, 31);
            this.btnDeleteK.TabIndex = 6;
            this.btnDeleteK.Text = "Xóa";
            this.btnDeleteK.UseVisualStyleBackColor = true;
            this.btnDeleteK.Click += new System.EventHandler(this.btnDeleteK_Click);
            // 
            // btnAddK
            // 
            this.btnAddK.AutoSize = true;
            this.btnAddK.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddK.Location = new System.Drawing.Point(256, 20);
            this.btnAddK.Name = "btnAddK";
            this.btnAddK.Size = new System.Drawing.Size(75, 31);
            this.btnAddK.TabIndex = 5;
            this.btnAddK.Text = "Thêm";
            this.btnAddK.UseVisualStyleBackColor = true;
            this.btnAddK.Click += new System.EventHandler(this.btnAddK_Click);
            // 
            // btnEditK
            // 
            this.btnEditK.AutoSize = true;
            this.btnEditK.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEditK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEditK.Location = new System.Drawing.Point(146, 20);
            this.btnEditK.Name = "btnEditK";
            this.btnEditK.Size = new System.Drawing.Size(75, 31);
            this.btnEditK.TabIndex = 4;
            this.btnEditK.Text = "Sửa";
            this.btnEditK.UseVisualStyleBackColor = true;
            this.btnEditK.Click += new System.EventHandler(this.btnEditK_Click);
            // 
            // btnShowK
            // 
            this.btnShowK.AutoSize = true;
            this.btnShowK.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnShowK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnShowK.Location = new System.Drawing.Point(35, 20);
            this.btnShowK.Name = "btnShowK";
            this.btnShowK.Size = new System.Drawing.Size(75, 31);
            this.btnShowK.TabIndex = 3;
            this.btnShowK.Text = "Xem";
            this.btnShowK.UseVisualStyleBackColor = true;
            this.btnShowK.Click += new System.EventHandler(this.btnShowK_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txbDescription);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(3, 121);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(470, 113);
            this.panel6.TabIndex = 2;
            // 
            // txbDescription
            // 
            this.txbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbDescription.Location = new System.Drawing.Point(142, 15);
            this.txbDescription.Multiline = true;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(317, 83);
            this.txbDescription.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(4, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mô Tả:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txbPrice);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(0, 62);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(419, 53);
            this.panel7.TabIndex = 1;
            // 
            // txbPrice
            // 
            this.txbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbPrice.Location = new System.Drawing.Point(145, 15);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(247, 24);
            this.txbPrice.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(4, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đơn Giá:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txbIDKind);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Location = new System.Drawing.Point(0, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(419, 53);
            this.panel8.TabIndex = 0;
            // 
            // txbIDKind
            // 
            this.txbIDKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbIDKind.Location = new System.Drawing.Point(145, 15);
            this.txbIDKind.Name = "txbIDKind";
            this.txbIDKind.Size = new System.Drawing.Size(247, 24);
            this.txbIDKind.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(4, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã Loại Phòng:";
            // 
            // dtgvKind
            // 
            this.dtgvKind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKind.Location = new System.Drawing.Point(0, 315);
            this.dtgvKind.Name = "dtgvKind";
            this.dtgvKind.RowHeadersWidth = 51;
            this.dtgvKind.RowTemplate.Height = 24;
            this.dtgvKind.Size = new System.Drawing.Size(473, 241);
            this.dtgvKind.TabIndex = 0;
            // 
            // tpRoom
            // 
            this.tpRoom.Controls.Add(this.panel1);
            this.tpRoom.Location = new System.Drawing.Point(4, 25);
            this.tpRoom.Name = "tpRoom";
            this.tpRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tpRoom.Size = new System.Drawing.Size(482, 582);
            this.tpRoom.TabIndex = 1;
            this.tpRoom.Text = "Quản Lý Phòng";
            this.tpRoom.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.dtgvRoom);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 575);
            this.panel1.TabIndex = 5;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnDeleteR);
            this.panel10.Controls.Add(this.btnAddR);
            this.panel10.Controls.Add(this.btnEditR);
            this.panel10.Controls.Add(this.btnShowR);
            this.panel10.Location = new System.Drawing.Point(0, 240);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(473, 69);
            this.panel10.TabIndex = 11;
            // 
            // btnDeleteR
            // 
            this.btnDeleteR.AutoSize = true;
            this.btnDeleteR.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDeleteR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeleteR.Location = new System.Drawing.Point(367, 20);
            this.btnDeleteR.Name = "btnDeleteR";
            this.btnDeleteR.Size = new System.Drawing.Size(75, 31);
            this.btnDeleteR.TabIndex = 6;
            this.btnDeleteR.Text = "Xóa";
            this.btnDeleteR.UseVisualStyleBackColor = true;
            this.btnDeleteR.Click += new System.EventHandler(this.btnDeleteR_Click);
            // 
            // btnAddR
            // 
            this.btnAddR.AutoSize = true;
            this.btnAddR.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddR.Location = new System.Drawing.Point(256, 20);
            this.btnAddR.Name = "btnAddR";
            this.btnAddR.Size = new System.Drawing.Size(75, 31);
            this.btnAddR.TabIndex = 5;
            this.btnAddR.Text = "Thêm";
            this.btnAddR.UseVisualStyleBackColor = true;
            this.btnAddR.Click += new System.EventHandler(this.btnAddR_Click);
            // 
            // btnEditR
            // 
            this.btnEditR.AutoSize = true;
            this.btnEditR.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEditR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEditR.Location = new System.Drawing.Point(146, 20);
            this.btnEditR.Name = "btnEditR";
            this.btnEditR.Size = new System.Drawing.Size(75, 31);
            this.btnEditR.TabIndex = 4;
            this.btnEditR.Text = "Sửa";
            this.btnEditR.UseVisualStyleBackColor = true;
            this.btnEditR.Click += new System.EventHandler(this.btnEditR_Click);
            // 
            // btnShowR
            // 
            this.btnShowR.AutoSize = true;
            this.btnShowR.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnShowR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnShowR.Location = new System.Drawing.Point(35, 20);
            this.btnShowR.Name = "btnShowR";
            this.btnShowR.Size = new System.Drawing.Size(75, 31);
            this.btnShowR.TabIndex = 3;
            this.btnShowR.Text = "Xem";
            this.btnShowR.UseVisualStyleBackColor = true;
            this.btnShowR.Click += new System.EventHandler(this.btnShowR_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.cbStatus);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Location = new System.Drawing.Point(0, 180);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(424, 53);
            this.panel9.TabIndex = 8;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Trống",
            "Đã Thuê"});
            this.cbStatus.Location = new System.Drawing.Point(145, 10);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(95, 26);
            this.cbStatus.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(4, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Trạng Thái:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbNameRoom);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 53);
            this.panel2.TabIndex = 7;
            // 
            // txbNameRoom
            // 
            this.txbNameRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbNameRoom.Location = new System.Drawing.Point(145, 15);
            this.txbNameRoom.Name = "txbNameRoom";
            this.txbNameRoom.Size = new System.Drawing.Size(247, 24);
            this.txbNameRoom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Phòng:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbIDKind);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(424, 53);
            this.panel3.TabIndex = 1;
            // 
            // cbIDKind
            // 
            this.cbIDKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIDKind.FormattingEnabled = true;
            this.cbIDKind.Location = new System.Drawing.Point(145, 18);
            this.cbIDKind.Name = "cbIDKind";
            this.cbIDKind.Size = new System.Drawing.Size(247, 24);
            this.cbIDKind.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(4, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Loại Phòng:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbIDRoom);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(424, 53);
            this.panel4.TabIndex = 0;
            // 
            // txbIDRoom
            // 
            this.txbIDRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbIDRoom.Location = new System.Drawing.Point(145, 15);
            this.txbIDRoom.Name = "txbIDRoom";
            this.txbIDRoom.Size = new System.Drawing.Size(247, 24);
            this.txbIDRoom.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(4, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Phòng:";
            // 
            // dtgvRoom
            // 
            this.dtgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRoom.Location = new System.Drawing.Point(0, 315);
            this.dtgvRoom.Name = "dtgvRoom";
            this.dtgvRoom.RowHeadersWidth = 51;
            this.dtgvRoom.RowTemplate.Height = 24;
            this.dtgvRoom.Size = new System.Drawing.Size(473, 241);
            this.dtgvRoom.TabIndex = 0;
            // 
            // FormRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 609);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh Sách Phòng";
            this.Load += new System.EventHandler(this.FormRoom_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpKind.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKind)).EndInit();
            this.tpRoom.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpKind;
        private System.Windows.Forms.TabPage tpRoom;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnDeleteK;
        private System.Windows.Forms.Button btnAddK;
        private System.Windows.Forms.Button btnEditK;
        private System.Windows.Forms.Button btnShowK;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txbIDKind;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgvKind;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnDeleteR;
        private System.Windows.Forms.Button btnAddR;
        private System.Windows.Forms.Button btnEditR;
        private System.Windows.Forms.Button btnShowR;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbNameRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbIDRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgvRoom;
        private System.Windows.Forms.ComboBox cbIDKind;
    }
}