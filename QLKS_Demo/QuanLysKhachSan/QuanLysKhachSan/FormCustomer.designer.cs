namespace QuanLysKhachSan
{
    partial class FormCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtgv_1 = new System.Windows.Forms.DataGridView();
            this.refresh_1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.refresh_2 = new System.Windows.Forms.Button();
            this.dtgv_2 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách Khách ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(528, 280);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtgv_1);
            this.tabPage1.Controls.Add(this.refresh_1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(520, 254);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách khách";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtgv_1
            // 
            this.dtgv_1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_1.Location = new System.Drawing.Point(9, 6);
            this.dtgv_1.Name = "dtgv_1";
            this.dtgv_1.Size = new System.Drawing.Size(505, 212);
            this.dtgv_1.TabIndex = 2;
            // 
            // refresh_1
            // 
            this.refresh_1.Location = new System.Drawing.Point(208, 224);
            this.refresh_1.Name = "refresh_1";
            this.refresh_1.Size = new System.Drawing.Size(75, 23);
            this.refresh_1.TabIndex = 3;
            this.refresh_1.Text = "Làm mới";
            this.refresh_1.UseVisualStyleBackColor = true;
            this.refresh_1.Click += new System.EventHandler(this.refresh_1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.refresh_2);
            this.tabPage2.Controls.Add(this.dtgv_2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(520, 254);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh sách khách đang thuê";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // refresh_2
            // 
            this.refresh_2.Location = new System.Drawing.Point(209, 224);
            this.refresh_2.Name = "refresh_2";
            this.refresh_2.Size = new System.Drawing.Size(75, 23);
            this.refresh_2.TabIndex = 4;
            this.refresh_2.Text = "Làm mới ";
            this.refresh_2.UseVisualStyleBackColor = true;
            this.refresh_2.Click += new System.EventHandler(this.refresh_2_Click);
            // 
            // dtgv_2
            // 
            this.dtgv_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_2.Location = new System.Drawing.Point(9, 6);
            this.dtgv_2.Name = "dtgv_2";
            this.dtgv_2.Size = new System.Drawing.Size(505, 212);
            this.dtgv_2.TabIndex = 3;
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 358);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "FormCustomer";
            this.Text = "Thông tin Khách ";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.DataGridView dtgv_1;
    private System.Windows.Forms.Button refresh_1;
    private System.Windows.Forms.DataGridView dtgv_2;
    private System.Windows.Forms.Button refresh_2;
}
}