
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
            this.dataGridView_datphong = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_datphong)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_datphong
            // 
            this.dataGridView_datphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_datphong.Location = new System.Drawing.Point(13, 225);
            this.dataGridView_datphong.Name = "dataGridView_datphong";
            this.dataGridView_datphong.RowHeadersWidth = 51;
            this.dataGridView_datphong.RowTemplate.Height = 24;
            this.dataGridView_datphong.Size = new System.Drawing.Size(775, 213);
            this.dataGridView_datphong.TabIndex = 0;
            // 
            // button_update
            // 
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.Location = new System.Drawing.Point(647, 162);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(84, 40);
            this.button_update.TabIndex = 1;
            this.button_update.Text = "Cập nhật";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // radioButton_dathue
            // 
            this.radioButton_dathue.AutoSize = true;
            this.radioButton_dathue.Location = new System.Drawing.Point(583, 50);
            this.radioButton_dathue.Name = "radioButton_dathue";
            this.radioButton_dathue.Size = new System.Drawing.Size(79, 21);
            this.radioButton_dathue.TabIndex = 2;
            this.radioButton_dathue.TabStop = true;
            this.radioButton_dathue.Text = "Đã thuê";
            this.radioButton_dathue.UseVisualStyleBackColor = true;
            // 
            // radioButton_chuathue
            // 
            this.radioButton_chuathue.AutoSize = true;
            this.radioButton_chuathue.Location = new System.Drawing.Point(583, 90);
            this.radioButton_chuathue.Name = "radioButton_chuathue";
            this.radioButton_chuathue.Size = new System.Drawing.Size(94, 21);
            this.radioButton_chuathue.TabIndex = 3;
            this.radioButton_chuathue.TabStop = true;
            this.radioButton_chuathue.Text = "Chưa thuê";
            this.radioButton_chuathue.UseVisualStyleBackColor = true;
            // 
            // textBox_maphong
            // 
            this.textBox_maphong.Location = new System.Drawing.Point(177, 30);
            this.textBox_maphong.Name = "textBox_maphong";
            this.textBox_maphong.Size = new System.Drawing.Size(232, 22);
            this.textBox_maphong.TabIndex = 4;
            // 
            // textBox_tenphong
            // 
            this.textBox_tenphong.Location = new System.Drawing.Point(177, 77);
            this.textBox_tenphong.Name = "textBox_tenphong";
            this.textBox_tenphong.Size = new System.Drawing.Size(232, 22);
            this.textBox_tenphong.TabIndex = 5;
            // 
            // textBox_mlphong
            // 
            this.textBox_mlphong.Location = new System.Drawing.Point(177, 121);
            this.textBox_mlphong.Name = "textBox_mlphong";
            this.textBox_mlphong.Size = new System.Drawing.Size(232, 22);
            this.textBox_mlphong.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mã loại phòng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Trạng thái:";
            // 
            // FormDatphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_mlphong);
            this.Controls.Add(this.textBox_tenphong);
            this.Controls.Add(this.textBox_maphong);
            this.Controls.Add(this.radioButton_chuathue);
            this.Controls.Add(this.radioButton_dathue);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.dataGridView_datphong);
            this.Name = "FormDatphong";
            this.Text = "Đặt phòng khách sạn";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_datphong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_datphong;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.RadioButton radioButton_dathue;
        private System.Windows.Forms.RadioButton radioButton_chuathue;
        private System.Windows.Forms.TextBox textBox_maphong;
        private System.Windows.Forms.TextBox textBox_tenphong;
        private System.Windows.Forms.TextBox textBox_mlphong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}