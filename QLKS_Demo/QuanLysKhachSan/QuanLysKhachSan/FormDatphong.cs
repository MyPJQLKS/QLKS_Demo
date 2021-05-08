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

        //đưa ra dữ liệu về các phòng đã/chưa được thuê
        //string ConnectionString =@"Data Source=localhost\SQLEXPRESS;Initial Catalog=QLKS_Demo;Integrated Security=True";
        string ConnectionString = SqlStringConnect.stringConnect;
        string macu, mapcu;
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
        //đưa dữ liệu từ cell trong data grid view lên các toolbox
        private void dataGridView_datphong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                DataGridViewRow row = this.dataGridView_check.Rows[e.RowIndex];
                textBox_maphong.Text = row.Cells[0].Value.ToString();
                mapcu= row.Cells[0].Value.ToString();
                textBox_tenphong.Text = row.Cells[1].Value.ToString();
                textBox_mlphong.Text = row.Cells[2].Value.ToString();
                string tt = row.Cells[3].Value.ToString();
                //label12.Text = tt;
                if(tt== "False")
                {
                    radioButton_chuathue.Checked = true;
                    radioButton_dathue.Checked = false;
                    textBox_maphong_fk.Text = textBox_maphong.Text;
                }
                else if( tt == "True")
                {
                    radioButton_dathue.Checked = true;
                    radioButton_chuathue.Checked = false;

                }
                //if()
                
                //using (SqlConnection sqlcon = new SqlConnection(ConnectionString))
                //{
                //    sqlcon.Open();
                //    SqlCommand command = new SqlCommand("execute thongtin_the '" + textBox_maphong + "'", sqlcon);
                //    command.ExecuteNonQuery();
                //    textBox_mathe.Text = (string)command.ExecuteScalar();
                //}
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
                    command.ExecuteNonQuery();
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
        //Load csdl khi mở form
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
            comboBox2_Index();
            comboBox1_Index();

        }

        //đưa dữ liệu từ cell trong data grid view lên các toolbox
        private void dataGridView_confirm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = this.dataGridView_confirm.Rows[e.RowIndex];
                textBox_mathe.Text= row.Cells[0].Value.ToString();
                macu= row.Cells[0].Value.ToString();
                textBox_maphong_fk.Text = row.Cells[1].Value.ToString();
                textBox_manv.Text = row.Cells[2].Value.ToString();
                textBox_tenkh.Text = row.Cells[3].Value.ToString();
                textBox_cmt.Text = row.Cells[4].Value.ToString();
                dateTimePicker_ngaydat.Value = Convert.ToDateTime(row.Cells[5].Value);
                dateTimePicker_ngaytra.Value = Convert.ToDateTime(row.Cells[6].Value);
                 
            }    
        }

        //event cho button nhập dữ liệu
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_cmt.Text == "" || textBox_manv.Text == "" || textBox_maphong_fk.Text == "" ||
                    textBox_mathe.Text == "" || textBox_tenkh.Text == "")
                {
                    MessageBox.Show("Chưa đủ thông tin", "Cảnh báo", MessageBoxButtons.OK);
                }
                else
                {
                    using (SqlConnection sqlcon = new SqlConnection(ConnectionString))
                    {
                        sqlcon.Open();
                        SqlCommand command = new SqlCommand(
                            "execute nhapdulieu N'" + textBox_mathe.Text + "', N'" + textBox_maphong_fk.Text + "', N'" + textBox_manv.Text + "', N'" + textBox_tenkh.Text + "', N'" + textBox_cmt.Text + "', '" + dateTimePicker_ngaydat.Value.ToString() + "', '" + dateTimePicker_ngaytra.Value.ToString() + "'", sqlcon);
                        sqlcon.InfoMessage += new SqlInfoMessageEventHandler(InfoMessageHandler);
                        command.ExecuteNonQuery();
                    }
                    load();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
        //event cho button cập nhật dữ liệu
        private void button4_Click(object sender, EventArgs e)
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
        //event cho button xóa dữ liệu được nhập trong textbox
        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox_mathe.Text=="")
            {
                MessageBox.Show("Chưa có thông tin về mã thẻ của phòng cần xóa!", "Cảnh báo", MessageBoxButtons.OK);

            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa thẻ có mã " + textBox_mathe.Text + " ?", "Cảnh báo", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(ConnectionString))
                    { 
                    sqlcon.Open();
                    SqlCommand sqlData = new SqlCommand("execute xoathe '"+textBox_mathe.Text+"'", sqlcon);
                        sqlcon.InfoMessage += new SqlInfoMessageEventHandler(InfoMessageHandler);
                        sqlData.ExecuteNonQuery();
                    }
                    load();
                }    
            }    
        }

        //private bool checkvalue()
        //{
        //    if(textBox_cmt.)
        //}
        //event cho button sửa dữ liệu được nhập trong textbox
        private void button2_Click(object sender, EventArgs e)
        {
            //if(textBox_cmt.Va)
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(ConnectionString))
                {
                    sqlcon.Open();
                    SqlCommand sqlData = new SqlCommand("execute checktofix N'"+macu+"',N'" +mapcu+ "',N'" + textBox_mathe.Text+"',N'"+textBox_maphong_fk.Text+"',N'"+textBox_manv.Text+"',N'"+textBox_tenkh.Text+"',N'"+textBox_cmt.Text+"','"+dateTimePicker_ngaydat.Value.ToString()+"','"+dateTimePicker_ngaytra.Value.ToString()+"'", sqlcon);
                    sqlcon.InfoMessage += new SqlInfoMessageEventHandler(InfoMessageHandler);
                    sqlData.ExecuteNonQuery();
                }
                load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void InfoMessageHandler(object mySender, SqlInfoMessageEventArgs myEvent)
        {
            MessageBox.Show(myEvent.Message);
        }

        private void comboBox1_Index()
        {
            textBox_maphong_fk.Items.Clear();
            using (SqlConnection sqlcon = new SqlConnection(ConnectionString))
            {
                sqlcon.Open();
                SqlCommand command = new SqlCommand("select maphong from phong where trangthai ='False'", sqlcon);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBox_maphong_fk.Items.Add(reader["maphong"].ToString());
                    textBox_maphong_fk.DisplayMember = (reader["maphong"].ToString());
                    textBox_maphong_fk.ValueMember = (reader["maphong"].ToString());
                }
            }
        }

        private void comboBox2_Index()
        {
            textBox_manv.Items.Clear();
            using (SqlConnection sqlcon = new SqlConnection(ConnectionString))
            {
                sqlcon.Open();
                SqlCommand command = new SqlCommand("select manv from nhanvien ", sqlcon);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBox_manv.Items.Add(reader["manv"].ToString());
                    textBox_manv.DisplayMember = (reader["manv"].ToString());
                    textBox_manv.ValueMember = (reader["manv"].ToString());
                }
            }
        }


        void load()
        {
            using (SqlConnection sqlcon = new SqlConnection(ConnectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("Select * from ThePhongThue", sqlcon);
                DataTable table = new DataTable();
                sqlData.Fill(table);
                dataGridView_confirm.DataSource = table;
            }
            comboBox2_Index();
            comboBox1_Index();
        }
    }
}
