
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
            this.tabPage_confirm = new System.Windows.Forms.TabPage();
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
            this.dataGridView_datphong = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage_check.SuspendLayout();
            this.tabPage_confirm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_datphong)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_check);
            this.tabControl1.Controls.Add(this.tabPage_confirm);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 486);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_check
            // 
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
            this.tabPage_check.Controls.Add(this.dataGridView_datphong);
            this.tabPage_check.Location = new System.Drawing.Point(4, 25);
            this.tabPage_check.Name = "tabPage_check";
            this.tabPage_check.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_check.Size = new System.Drawing.Size(767, 457);
            this.tabPage_check.TabIndex = 0;
            this.tabPage_check.Text = "KIểm tra";
            this.tabPage_check.UseVisualStyleBackColor = true;
            // 
            // tabPage_confirm
            // 
            this.tabPage_confirm.Controls.Add(this.dateTimePicker2);
            this.tabPage_confirm.Controls.Add(this.dateTimePicker1);
            this.tabPage_confirm.Controls.Add(this.textBox5);
            this.tabPage_confirm.Controls.Add(this.textBox4);
            this.tabPage_confirm.Controls.Add(this.textBox3);
            this.tabPage_confirm.Controls.Add(this.textBox2);
            this.tabPage_confirm.Controls.Add(this.textBox1);
            this.tabPage_confirm.Location = new System.Drawing.Point(4, 25);
            this.tabPage_confirm.Name = "tabPage_confirm";
            this.tabPage_confirm.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_confirm.Size = new System.Drawing.Size(767, 457);
            this.tabPage_confirm.TabIndex = 1;
            this.tabPage_confirm.Text = "Đặt phòng";
            this.tabPage_confirm.UseVisualStyleBackColor = true;
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
            this.button_update.Location = new System.Drawing.Point(677, 18);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(84, 40);
            this.button_update.TabIndex = 12;
            this.button_update.Text = "Cập nhật";
            this.button_update.UseVisualStyleBackColor = true;
            // 
            // dataGridView_datphong
            // 
            this.dataGridView_datphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_datphong.Location = new System.Drawing.Point(6, 182);
            this.dataGridView_datphong.Name = "dataGridView_datphong";
            this.dataGridView_datphong.RowHeadersWidth = 51;
            this.dataGridView_datphong.RowTemplate.Height = 24;
            this.dataGridView_datphong.Size = new System.Drawing.Size(755, 269);
            this.dataGridView_datphong.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(482, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(482, 97);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(198, 22);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(159, 123);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(198, 22);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(159, 79);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(198, 22);
            this.textBox5.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(471, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 27);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(471, 55);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(112, 27);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // FormDatphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormDatphong";
            this.Text = "Đặt phòng khách sạn";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_check.ResumeLayout(false);
            this.tabPage_check.PerformLayout();
            this.tabPage_confirm.ResumeLayout(false);
            this.tabPage_confirm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_datphong)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView_datphong;
        private System.Windows.Forms.TabPage tabPage_confirm;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}