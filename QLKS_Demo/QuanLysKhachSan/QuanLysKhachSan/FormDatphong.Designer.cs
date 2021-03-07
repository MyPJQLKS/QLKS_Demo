
namespace QuanLysKhachSan
{
    partial class FormDatphong
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
            this.tabPage_check = new System.Windows.Forms.TabPage();
            this.button_datphong_check = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_mlphong = new System.Windows.Forms.TextBox();
            this.textBox_tenphong = new System.Windows.Forms.TextBox();
            this.textBox_maphong = new System.Windows.Forms.TextBox();
            this.radioButton_chuathue = new System.Windows.Forms.RadioButton();
            this.radioButton_dathue = new System.Windows.Forms.RadioButton();
            this.button_update = new System.Windows.Forms.Button();
            this.dataGridView_check = new System.Windows.Forms.DataGridView();
            this.tabPage_confirm = new System.Windows.Forms.TabPage();
            this.dataGridView_confirm = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker_ngaytra = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_ngaydat = new System.Windows.Forms.DateTimePicker();
            this.textBox_cmt = new System.Windows.Forms.TextBox();
            this.textBox_maphong_fk = new System.Windows.Forms.TextBox();
            this.textBox_manv = new System.Windows.Forms.TextBox();
            this.textBox_mathe = new System.Windows.Forms.TextBox();
            this.textBox_tenkh = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_searchchuathue = new System.Windows.Forms.RadioButton();
            this.radioButton_searchdathue = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage_check.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_check)).BeginInit();
            this.tabPage_confirm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_confirm)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_check);
            this.tabControl1.Controls.Add(this.tabPage_confirm);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 523);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_check
            // 
            this.tabPage_check.Controls.Add(this.panel1);
            this.tabPage_check.Controls.Add(this.button_datphong_check);
            this.tabPage_check.Controls.Add(this.label4);
            this.tabPage_check.Controls.Add(this.label3);
            this.tabPage_check.Controls.Add(this.label2);
            this.tabPage_check.Controls.Add(this.label1);
            this.tabPage_check.Controls.Add(this.textBox_mlphong);
            this.tabPage_check.Controls.Add(this.textBox_tenphong);
            this.tabPage_check.Controls.Add(this.textBox_maphong);
            this.tabPage_check.Controls.Add(this.radioButton_chuathue);
            this.tabPage_check.Controls.Add(this.radioButton_dathue);
            this.tabPage_check.Controls.Add(this.button_update);
            this.tabPage_check.Controls.Add(this.dataGridView_check);
            this.tabPage_check.Location = new System.Drawing.Point(4, 25);
            this.tabPage_check.Name = "tabPage_check";
            this.tabPage_check.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_check.Size = new System.Drawing.Size(767, 494);
            this.tabPage_check.TabIndex = 0;
            this.tabPage_check.Text = "KIểm tra";
            this.tabPage_check.UseVisualStyleBackColor = true;
            // 
            // button_datphong_check
            // 
            this.button_datphong_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_datphong_check.Location = new System.Drawing.Point(655, 66);
            this.button_datphong_check.Name = "button_datphong_check";
            this.button_datphong_check.Size = new System.Drawing.Size(106, 40);
            this.button_datphong_check.TabIndex = 23;
            this.button_datphong_check.Text = "Đặt phòng";
            this.button_datphong_check.UseVisualStyleBackColor = true;
            this.button_datphong_check.Click += new System.EventHandler(this.button_datphong_check_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Trạng thái:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mã loại phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên phòng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã phòng:";
            // 
            // textBox_mlphong
            // 
            this.textBox_mlphong.Location = new System.Drawing.Point(164, 119);
            this.textBox_mlphong.Name = "textBox_mlphong";
            this.textBox_mlphong.Size = new System.Drawing.Size(232, 22);
            this.textBox_mlphong.TabIndex = 17;
            // 
            // textBox_tenphong
            // 
            this.textBox_tenphong.Location = new System.Drawing.Point(164, 75);
            this.textBox_tenphong.Name = "textBox_tenphong";
            this.textBox_tenphong.Size = new System.Drawing.Size(232, 22);
            this.textBox_tenphong.TabIndex = 16;
            // 
            // textBox_maphong
            // 
            this.textBox_maphong.Location = new System.Drawing.Point(164, 28);
            this.textBox_maphong.Name = "textBox_maphong";
            this.textBox_maphong.Size = new System.Drawing.Size(232, 22);
            this.textBox_maphong.TabIndex = 15;
            // 
            // radioButton_chuathue
            // 
            this.radioButton_chuathue.AutoSize = true;
            this.radioButton_chuathue.Location = new System.Drawing.Point(508, 66);
            this.radioButton_chuathue.Name = "radioButton_chuathue";
            this.radioButton_chuathue.Size = new System.Drawing.Size(94, 21);
            this.radioButton_chuathue.TabIndex = 14;
            this.radioButton_chuathue.TabStop = true;
            this.radioButton_chuathue.Text = "Chưa thuê";
            this.radioButton_chuathue.UseVisualStyleBackColor = true;
            // 
            // radioButton_dathue
            // 
            this.radioButton_dathue.AutoSize = true;
            this.radioButton_dathue.Location = new System.Drawing.Point(508, 26);
            this.radioButton_dathue.Name = "radioButton_dathue";
            this.radioButton_dathue.Size = new System.Drawing.Size(79, 21);
            this.radioButton_dathue.TabIndex = 13;
            this.radioButton_dathue.TabStop = true;
            this.radioButton_dathue.Text = "Đã thuê";
            this.radioButton_dathue.UseVisualStyleBackColor = true;
            // 
            // button_update
            // 
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.Location = new System.Drawing.Point(655, 18);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(106, 40);
            this.button_update.TabIndex = 12;
            this.button_update.Text = "Cập nhật";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // dataGridView_check
            // 
            this.dataGridView_check.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_check.Location = new System.Drawing.Point(6, 219);
            this.dataGridView_check.Name = "dataGridView_check";
            this.dataGridView_check.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_check.RowHeadersWidth = 51;
            this.dataGridView_check.RowTemplate.Height = 24;
            this.dataGridView_check.Size = new System.Drawing.Size(755, 269);
            this.dataGridView_check.TabIndex = 11;
            this.dataGridView_check.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_datphong_CellContentClick);
            this.dataGridView_check.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_datphong_CellContentClick);
            // 
            // tabPage_confirm
            // 
            this.tabPage_confirm.Controls.Add(this.button3);
            this.tabPage_confirm.Controls.Add(this.button2);
            this.tabPage_confirm.Controls.Add(this.button1);
            this.tabPage_confirm.Controls.Add(this.dataGridView_confirm);
            this.tabPage_confirm.Controls.Add(this.label11);
            this.tabPage_confirm.Controls.Add(this.label10);
            this.tabPage_confirm.Controls.Add(this.label9);
            this.tabPage_confirm.Controls.Add(this.label8);
            this.tabPage_confirm.Controls.Add(this.label7);
            this.tabPage_confirm.Controls.Add(this.label6);
            this.tabPage_confirm.Controls.Add(this.label5);
            this.tabPage_confirm.Controls.Add(this.dateTimePicker_ngaytra);
            this.tabPage_confirm.Controls.Add(this.dateTimePicker_ngaydat);
            this.tabPage_confirm.Controls.Add(this.textBox_cmt);
            this.tabPage_confirm.Controls.Add(this.textBox_maphong_fk);
            this.tabPage_confirm.Controls.Add(this.textBox_manv);
            this.tabPage_confirm.Controls.Add(this.textBox_mathe);
            this.tabPage_confirm.Controls.Add(this.textBox_tenkh);
            this.tabPage_confirm.Location = new System.Drawing.Point(4, 25);
            this.tabPage_confirm.Name = "tabPage_confirm";
            this.tabPage_confirm.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_confirm.Size = new System.Drawing.Size(767, 494);
            this.tabPage_confirm.TabIndex = 1;
            this.tabPage_confirm.Text = "Đặt phòng";
            this.tabPage_confirm.UseVisualStyleBackColor = true;
            this.tabPage_confirm.Click += new System.EventHandler(this.tabPage_confirm_Click);
            // 
            // dataGridView_confirm
            // 
            this.dataGridView_confirm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_confirm.Location = new System.Drawing.Point(7, 234);
            this.dataGridView_confirm.Name = "dataGridView_confirm";
            this.dataGridView_confirm.RowHeadersWidth = 51;
            this.dataGridView_confirm.RowTemplate.Height = 24;
            this.dataGridView_confirm.Size = new System.Drawing.Size(754, 254);
            this.dataGridView_confirm.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(380, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "Ngày dự kiến trả phòng:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(427, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Ngày đặt phòng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(449, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Mã thẻ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(407, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Mã nhân viên:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "CMND/CCCD:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mã phòng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tên Khách hàng:";
            // 
            // dateTimePicker_ngaytra
            // 
            this.dateTimePicker_ngaytra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_ngaytra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_ngaytra.Location = new System.Drawing.Point(561, 55);
            this.dateTimePicker_ngaytra.Name = "dateTimePicker_ngaytra";
            this.dateTimePicker_ngaytra.Size = new System.Drawing.Size(130, 27);
            this.dateTimePicker_ngaytra.TabIndex = 6;
            // 
            // dateTimePicker_ngaydat
            // 
            this.dateTimePicker_ngaydat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_ngaydat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_ngaydat.Location = new System.Drawing.Point(561, 22);
            this.dateTimePicker_ngaydat.Name = "dateTimePicker_ngaydat";
            this.dateTimePicker_ngaydat.Size = new System.Drawing.Size(130, 27);
            this.dateTimePicker_ngaydat.TabIndex = 5;
            // 
            // textBox_cmt
            // 
            this.textBox_cmt.Location = new System.Drawing.Point(159, 79);
            this.textBox_cmt.Name = "textBox_cmt";
            this.textBox_cmt.Size = new System.Drawing.Size(198, 22);
            this.textBox_cmt.TabIndex = 4;
            // 
            // textBox_maphong_fk
            // 
            this.textBox_maphong_fk.Location = new System.Drawing.Point(159, 123);
            this.textBox_maphong_fk.Name = "textBox_maphong_fk";
            this.textBox_maphong_fk.Size = new System.Drawing.Size(198, 22);
            this.textBox_maphong_fk.TabIndex = 3;
            // 
            // textBox_manv
            // 
            this.textBox_manv.Location = new System.Drawing.Point(510, 97);
            this.textBox_manv.Name = "textBox_manv";
            this.textBox_manv.Size = new System.Drawing.Size(198, 22);
            this.textBox_manv.TabIndex = 2;
            // 
            // textBox_mathe
            // 
            this.textBox_mathe.Location = new System.Drawing.Point(510, 139);
            this.textBox_mathe.Name = "textBox_mathe";
            this.textBox_mathe.Size = new System.Drawing.Size(198, 22);
            this.textBox_mathe.TabIndex = 1;
            // 
            // textBox_tenkh
            // 
            this.textBox_tenkh.Location = new System.Drawing.Point(159, 40);
            this.textBox_tenkh.Name = "textBox_tenkh";
            this.textBox_tenkh.Size = new System.Drawing.Size(198, 22);
            this.textBox_tenkh.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.radioButton_searchchuathue);
            this.panel1.Controls.Add(this.radioButton_searchdathue);
            this.panel1.Location = new System.Drawing.Point(444, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 54);
            this.panel1.TabIndex = 24;
            // 
            // radioButton_searchchuathue
            // 
            this.radioButton_searchchuathue.AutoSize = true;
            this.radioButton_searchchuathue.Checked = true;
            this.radioButton_searchchuathue.Location = new System.Drawing.Point(19, 28);
            this.radioButton_searchchuathue.Name = "radioButton_searchchuathue";
            this.radioButton_searchchuathue.Size = new System.Drawing.Size(94, 21);
            this.radioButton_searchchuathue.TabIndex = 27;
            this.radioButton_searchchuathue.TabStop = true;
            this.radioButton_searchchuathue.Text = "Chưa thuê";
            this.radioButton_searchchuathue.UseVisualStyleBackColor = true;
            // 
            // radioButton_searchdathue
            // 
            this.radioButton_searchdathue.AutoSize = true;
            this.radioButton_searchdathue.Location = new System.Drawing.Point(154, 28);
            this.radioButton_searchdathue.Name = "radioButton_searchdathue";
            this.radioButton_searchdathue.Size = new System.Drawing.Size(79, 21);
            this.radioButton_searchdathue.TabIndex = 26;
            this.radioButton_searchdathue.Text = "Đã thuê";
            this.radioButton_searchdathue.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(52, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "Cập nhật theo:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(121, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "Thêm thẻ phòng";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(297, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 32);
            this.button2.TabIndex = 16;
            this.button2.Text = "Sửa thẻ phòng";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(475, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 32);
            this.button3.TabIndex = 17;
            this.button3.Text = "Xóa thẻ phòng";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FormDatphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormDatphong";
            this.Text = "Đặt phòng khách sạn";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_check.ResumeLayout(false);
            this.tabPage_check.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_check)).EndInit();
            this.tabPage_confirm.ResumeLayout(false);
            this.tabPage_confirm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_confirm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_check;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_mlphong;
        private System.Windows.Forms.TextBox textBox_tenphong;
        private System.Windows.Forms.TextBox textBox_maphong;
        private System.Windows.Forms.RadioButton radioButton_chuathue;
        private System.Windows.Forms.RadioButton radioButton_dathue;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.DataGridView dataGridView_check;
        private System.Windows.Forms.TabPage tabPage_confirm;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngaytra;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngaydat;
        private System.Windows.Forms.TextBox textBox_cmt;
        private System.Windows.Forms.TextBox textBox_maphong_fk;
        private System.Windows.Forms.TextBox textBox_manv;
        private System.Windows.Forms.TextBox textBox_mathe;
        private System.Windows.Forms.TextBox textBox_tenkh;
        private System.Windows.Forms.DataGridView dataGridView_confirm;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_datphong_check;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radioButton_searchchuathue;
        private System.Windows.Forms.RadioButton radioButton_searchdathue;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}