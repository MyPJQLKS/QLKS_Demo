
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
            this.tabPage_check = new System.Windows.Forms.TabPage();
            this.dataGridView_check = new System.Windows.Forms.DataGridView();
            this.button_update = new System.Windows.Forms.Button();
            this.radioButton_dathue = new System.Windows.Forms.RadioButton();
            this.radioButton_chuathue = new System.Windows.Forms.RadioButton();
            this.textBox_maphong = new System.Windows.Forms.TextBox();
            this.textBox_tenphong = new System.Windows.Forms.TextBox();
            this.textBox_mlphong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_datphong_check = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_searchdathue = new System.Windows.Forms.RadioButton();
            this.radioButton_searchchuathue = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage_confirm = new System.Windows.Forms.TabPage();
            this.textBox_tenkh = new System.Windows.Forms.TextBox();
            this.textBox_mathe = new System.Windows.Forms.TextBox();
            this.textBox_cmt = new System.Windows.Forms.TextBox();
            this.dateTimePicker_ngaydat = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_ngaytra = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView_confirm = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox_maphong_fk = new System.Windows.Forms.ComboBox();
            this.textBox_manv = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_check.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_check)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage_confirm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_confirm)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
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
            this.tabPage_check.Location = new System.Drawing.Point(4, 22);
            this.tabPage_check.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_check.Name = "tabPage_check";
            this.tabPage_check.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_check.Size = new System.Drawing.Size(786, 399);
            this.tabPage_check.TabIndex = 2;
            this.tabPage_check.Text = "Kiểm tra phòng";
            this.tabPage_check.UseVisualStyleBackColor = true;
            // 
            // dataGridView_check
            // 
            this.dataGridView_check.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_check.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_check.Location = new System.Drawing.Point(4, 173);
            this.dataGridView_check.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_check.Name = "dataGridView_check";
            this.dataGridView_check.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_check.RowHeadersWidth = 51;
            this.dataGridView_check.RowTemplate.Height = 24;
            this.dataGridView_check.Size = new System.Drawing.Size(778, 219);
            this.dataGridView_check.TabIndex = 25;
            this.dataGridView_check.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_datphong_CellContentClick);
            this.dataGridView_check.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_datphong_CellContentClick);
            // 
            // button_update
            // 
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.Location = new System.Drawing.Point(568, 16);
            this.button_update.Margin = new System.Windows.Forms.Padding(2);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(80, 32);
            this.button_update.TabIndex = 26;
            this.button_update.Text = "Cập nhật";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // radioButton_dathue
            // 
            this.radioButton_dathue.AutoSize = true;
            this.radioButton_dathue.Location = new System.Drawing.Point(458, 23);
            this.radioButton_dathue.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_dathue.Name = "radioButton_dathue";
            this.radioButton_dathue.Size = new System.Drawing.Size(63, 17);
            this.radioButton_dathue.TabIndex = 27;
            this.radioButton_dathue.TabStop = true;
            this.radioButton_dathue.Text = "Đã thuê";
            this.radioButton_dathue.UseVisualStyleBackColor = true;
            // 
            // radioButton_chuathue
            // 
            this.radioButton_chuathue.AutoSize = true;
            this.radioButton_chuathue.Location = new System.Drawing.Point(458, 55);
            this.radioButton_chuathue.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_chuathue.Name = "radioButton_chuathue";
            this.radioButton_chuathue.Size = new System.Drawing.Size(74, 17);
            this.radioButton_chuathue.TabIndex = 28;
            this.radioButton_chuathue.TabStop = true;
            this.radioButton_chuathue.Text = "Chưa thuê";
            this.radioButton_chuathue.UseVisualStyleBackColor = true;
            // 
            // textBox_maphong
            // 
            this.textBox_maphong.Location = new System.Drawing.Point(200, 24);
            this.textBox_maphong.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_maphong.Name = "textBox_maphong";
            this.textBox_maphong.Size = new System.Drawing.Size(175, 20);
            this.textBox_maphong.TabIndex = 29;
            // 
            // textBox_tenphong
            // 
            this.textBox_tenphong.Location = new System.Drawing.Point(200, 63);
            this.textBox_tenphong.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_tenphong.Name = "textBox_tenphong";
            this.textBox_tenphong.Size = new System.Drawing.Size(175, 20);
            this.textBox_tenphong.TabIndex = 30;
            // 
            // textBox_mlphong
            // 
            this.textBox_mlphong.Location = new System.Drawing.Point(200, 98);
            this.textBox_mlphong.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_mlphong.Name = "textBox_mlphong";
            this.textBox_mlphong.Size = new System.Drawing.Size(175, 20);
            this.textBox_mlphong.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Mã phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Tên phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Mã loại phòng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Trạng thái:";
            // 
            // button_datphong_check
            // 
            this.button_datphong_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_datphong_check.Location = new System.Drawing.Point(568, 55);
            this.button_datphong_check.Margin = new System.Windows.Forms.Padding(2);
            this.button_datphong_check.Name = "button_datphong_check";
            this.button_datphong_check.Size = new System.Drawing.Size(80, 32);
            this.button_datphong_check.TabIndex = 36;
            this.button_datphong_check.Text = "Đặt phòng";
            this.button_datphong_check.UseVisualStyleBackColor = true;
            this.button_datphong_check.Click += new System.EventHandler(this.button_datphong_check_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.radioButton_searchchuathue);
            this.panel1.Controls.Add(this.radioButton_searchdathue);
            this.panel1.Location = new System.Drawing.Point(410, 101);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 44);
            this.panel1.TabIndex = 37;
            // 
            // radioButton_searchdathue
            // 
            this.radioButton_searchdathue.AutoSize = true;
            this.radioButton_searchdathue.Location = new System.Drawing.Point(116, 23);
            this.radioButton_searchdathue.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_searchdathue.Name = "radioButton_searchdathue";
            this.radioButton_searchdathue.Size = new System.Drawing.Size(63, 17);
            this.radioButton_searchdathue.TabIndex = 26;
            this.radioButton_searchdathue.Text = "Đã thuê";
            this.radioButton_searchdathue.UseVisualStyleBackColor = true;
            // 
            // radioButton_searchchuathue
            // 
            this.radioButton_searchchuathue.AutoSize = true;
            this.radioButton_searchchuathue.Checked = true;
            this.radioButton_searchchuathue.Location = new System.Drawing.Point(14, 23);
            this.radioButton_searchchuathue.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_searchchuathue.Name = "radioButton_searchchuathue";
            this.radioButton_searchchuathue.Size = new System.Drawing.Size(74, 17);
            this.radioButton_searchchuathue.TabIndex = 27;
            this.radioButton_searchchuathue.TabStop = true;
            this.radioButton_searchchuathue.Text = "Chưa thuê";
            this.radioButton_searchchuathue.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 4);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Cập nhật theo:";
            // 
            // tabPage_confirm
            // 
            this.tabPage_confirm.Controls.Add(this.textBox_manv);
            this.tabPage_confirm.Controls.Add(this.textBox_maphong_fk);
            this.tabPage_confirm.Controls.Add(this.button4);
            this.tabPage_confirm.Controls.Add(this.label19);
            this.tabPage_confirm.Controls.Add(this.label18);
            this.tabPage_confirm.Controls.Add(this.label17);
            this.tabPage_confirm.Controls.Add(this.label16);
            this.tabPage_confirm.Controls.Add(this.label15);
            this.tabPage_confirm.Controls.Add(this.label14);
            this.tabPage_confirm.Controls.Add(this.label13);
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
            this.tabPage_confirm.Controls.Add(this.textBox_mathe);
            this.tabPage_confirm.Controls.Add(this.textBox_tenkh);
            this.tabPage_confirm.Location = new System.Drawing.Point(4, 22);
            this.tabPage_confirm.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_confirm.Name = "tabPage_confirm";
            this.tabPage_confirm.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_confirm.Size = new System.Drawing.Size(786, 399);
            this.tabPage_confirm.TabIndex = 1;
            this.tabPage_confirm.Text = "Đặt phòng";
            this.tabPage_confirm.UseVisualStyleBackColor = true;
            this.tabPage_confirm.Click += new System.EventHandler(this.tabPage_confirm_Click);
            // 
            // textBox_tenkh
            // 
            this.textBox_tenkh.Location = new System.Drawing.Point(204, 32);
            this.textBox_tenkh.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_tenkh.Name = "textBox_tenkh";
            this.textBox_tenkh.Size = new System.Drawing.Size(150, 20);
            this.textBox_tenkh.TabIndex = 0;
            // 
            // textBox_mathe
            // 
            this.textBox_mathe.Location = new System.Drawing.Point(467, 113);
            this.textBox_mathe.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_mathe.Name = "textBox_mathe";
            this.textBox_mathe.Size = new System.Drawing.Size(150, 20);
            this.textBox_mathe.TabIndex = 1;
            // 
            // textBox_cmt
            // 
            this.textBox_cmt.Location = new System.Drawing.Point(204, 64);
            this.textBox_cmt.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_cmt.Name = "textBox_cmt";
            this.textBox_cmt.Size = new System.Drawing.Size(150, 20);
            this.textBox_cmt.TabIndex = 4;
            // 
            // dateTimePicker_ngaydat
            // 
            this.dateTimePicker_ngaydat.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker_ngaydat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_ngaydat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ngaydat.Location = new System.Drawing.Point(506, 18);
            this.dateTimePicker_ngaydat.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_ngaydat.Name = "dateTimePicker_ngaydat";
            this.dateTimePicker_ngaydat.Size = new System.Drawing.Size(98, 23);
            this.dateTimePicker_ngaydat.TabIndex = 5;
            // 
            // dateTimePicker_ngaytra
            // 
            this.dateTimePicker_ngaytra.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker_ngaytra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_ngaytra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ngaytra.Location = new System.Drawing.Point(506, 45);
            this.dateTimePicker_ngaytra.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_ngaytra.Name = "dateTimePicker_ngaytra";
            this.dateTimePicker_ngaytra.Size = new System.Drawing.Size(98, 23);
            this.dateTimePicker_ngaytra.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(390, 81);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(422, 113);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(405, 24);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(370, 51);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 13;
            // 
            // dataGridView_confirm
            // 
            this.dataGridView_confirm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_confirm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_confirm.Location = new System.Drawing.Point(5, 190);
            this.dataGridView_confirm.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_confirm.Name = "dataGridView_confirm";
            this.dataGridView_confirm.RowHeadersWidth = 51;
            this.dataGridView_confirm.RowTemplate.Height = 24;
            this.dataGridView_confirm.Size = new System.Drawing.Size(780, 206);
            this.dataGridView_confirm.TabIndex = 14;
            this.dataGridView_confirm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_confirm_CellClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(176, 149);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 26);
            this.button1.TabIndex = 15;
            this.button1.Text = "Thêm thẻ phòng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(308, 149);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 26);
            this.button2.TabIndex = 16;
            this.button2.Text = "Sửa thẻ phòng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(441, 149);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 26);
            this.button3.TabIndex = 17;
            this.button3.Text = "Xóa thẻ phòng";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(107, 35);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Tên Khách hàng:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(124, 67);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "CMND/CCCD:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(388, 81);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Mã nhân viên:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(410, 24);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Ngày đặt phòng:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(412, 51);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 13);
            this.label17.TabIndex = 22;
            this.label17.Text = "Ngày trả phòng:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(138, 104);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "Mã phòng:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(420, 115);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 13);
            this.label19.TabIndex = 24;
            this.label19.Text = "Mã thẻ:";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(31, 149);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 26);
            this.button4.TabIndex = 25;
            this.button4.Text = "Cập nhật";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox_maphong_fk
            // 
            this.textBox_maphong_fk.FormattingEnabled = true;
            this.textBox_maphong_fk.Location = new System.Drawing.Point(201, 99);
            this.textBox_maphong_fk.Name = "textBox_maphong_fk";
            this.textBox_maphong_fk.Size = new System.Drawing.Size(153, 21);
            this.textBox_maphong_fk.TabIndex = 26;
            // 
            // textBox_manv
            // 
            this.textBox_manv.FormattingEnabled = true;
            this.textBox_manv.Location = new System.Drawing.Point(469, 81);
            this.textBox_manv.Name = "textBox_manv";
            this.textBox_manv.Size = new System.Drawing.Size(148, 21);
            this.textBox_manv.TabIndex = 27;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_confirm);
            this.tabControl1.Controls.Add(this.tabPage_check);
            this.tabControl1.Location = new System.Drawing.Point(10, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(794, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // FormDatphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 445);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDatphong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt phòng khách sạn";
            this.Load += new System.EventHandler(this.FormDatphong_Load);
            this.tabPage_check.ResumeLayout(false);
            this.tabPage_check.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_check)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage_confirm.ResumeLayout(false);
            this.tabPage_confirm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_confirm)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage_check;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radioButton_searchchuathue;
        private System.Windows.Forms.RadioButton radioButton_searchdathue;
        private System.Windows.Forms.Button button_datphong_check;
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
        private System.Windows.Forms.ComboBox textBox_manv;
        private System.Windows.Forms.ComboBox textBox_maphong_fk;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView_confirm;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngaytra;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngaydat;
        private System.Windows.Forms.TextBox textBox_cmt;
        private System.Windows.Forms.TextBox textBox_mathe;
        private System.Windows.Forms.TextBox textBox_tenkh;
        private System.Windows.Forms.TabControl tabControl1;
    }
}