﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace QuanLysKhachSan
{
    public partial class FormDatphong : Form
    {
        public FormDatphong()
        {
            InitializeComponent();
        }
        string ConnectionString =@"Data Source=localhost\SQLEXPRESS;Initial Catalog=QLKS_Demo;Integrated Security=True";
        private void button_update_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(ConnectionString))
            {
                sqlcon.Open();
                if (radioButton_searchchuathue.Checked == true)
                {
                    SqlDataAdapter sqlData = new SqlDataAdapter("Select * from Phong where trangthai = 'false'", sqlcon);
                    DataTable table = new DataTable();
                    sqlData.Fill(table);
                    dataGridView_check.DataSource = table;
                }
                else if (radioButton_searchdathue.Checked==true)
                {
                    SqlDataAdapter sqlData = new SqlDataAdapter("Select * from Phong where trangthai = 'true'", sqlcon);
                    DataTable table = new DataTable();
                    sqlData.Fill(table);
                    dataGridView_check.DataSource = table;
                }
                
            }
    }

        private void dataGridView_datphong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                DataGridViewRow row = this.dataGridView_check.Rows[e.RowIndex];
                textBox_maphong.Text = row.Cells[0].Value.ToString();
                textBox_tenphong.Text = row.Cells[1].Value.ToString();
                textBox_mlphong.Text = row.Cells[2].Value.ToString();
                string tt = row.Cells[3].Value.ToString();
                //label12.Text = tt;
                if(tt== "False")
                {
                    radioButton_chuathue.Checked = true;
                    radioButton_dathue.Checked = false;
                }
                else if( tt == "True")
                {
                    radioButton_dathue.Checked = true;
                    radioButton_chuathue.Checked = false;
                }
                textBox_maphong_fk.Text = textBox_maphong.Text;
                using (SqlConnection sqlcon = new SqlConnection(ConnectionString))
                {
                    sqlcon.Open();
                    SqlCommand command = new SqlCommand("execute thongtin_the '" + textBox_maphong + "'", sqlcon);
                    textBox_mathe.Text = (string)command.ExecuteScalar();
                }
            }
        }

        private void tabPage_confirm_Click(object sender, EventArgs e)
        {

        }

        private void button_datphong_check_Click(object sender, EventArgs e)
        {
            if(textBox_maphong.Text=="")
            {
                MessageBox.Show("Chưa chọn phòng", "Cảnh báo", MessageBoxButtons.OK);
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(ConnectionString))
                {
                    sqlcon.Open();
                    SqlCommand command = new SqlCommand("Select Count(*) from Phong where maphong= '" + textBox_maphong.Text+"'", sqlcon);
                    //command = new SqlCommand("")
                    if((int)command.ExecuteScalar() !=0)
                    {
                        tabControl1.SelectTab(tabPage_confirm);
                    }
                    else
                    {
                        MessageBox.Show("Không có mã phòng này", "Cảnh báo", MessageBoxButtons.OK);
                    }    
                }
            }
            if(radioButton_dathue.Checked == true)
            {
                MessageBox.Show("Phòng đang được dùng, mời chọn phòng khác", "Cảnh báo", MessageBoxButtons.OK);
            }
        }

        private void FormDatphong_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(ConnectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("Select * from ThePhongThue", sqlcon);
                DataTable table = new DataTable();
                sqlData.Fill(table);
                dataGridView_confirm.DataSource = table;
            }
        }

        private void dataGridView_confirm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = this.dataGridView_confirm.Rows[e.RowIndex];
                textBox_mathe.Text= row.Cells[0].Value.ToString();
                textBox_maphong.Text = row.Cells[1].Value.ToString();
                textBox_manv.Text = row.Cells[2].Value.ToString();
                textBox_tenkh.Text = row.Cells[3].Value.ToString();
                textBox_cmt.Text = row.Cells[4].Value.ToString();
                dateTimePicker_ngaydat.Value = DateTime.ParseExact(row.Cells[4].Value.ToString(), , CultureInfo.InvariantCulture);
            }    
        }
    }
}
