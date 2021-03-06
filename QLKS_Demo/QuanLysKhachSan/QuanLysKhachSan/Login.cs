using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLysKhachSan.Properties;
namespace QuanLysKhachSan
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public string SqlStringConnect { get; private set; }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
            //SqlConnection connect = new SqlConnection(@"Data Source=localhost;Initial Catalog=QLKS_Demo;Integrated Security=True");
            SqlConnection connect = new SqlConnection(SqlString.str);
            try 
            {
                connect.Open();
                if(textBoxUserName.Text=="" && textBoxPassWord.Text=="")
                {
                    MessageBox.Show("Nhập đầy đủ thông tin");
                }
                else
                {
                    string us = textBoxUserName.Text;
                    string pw = textBoxPassWord.Text;
                    string query = "Select * from UserTable where taikhoan='" + us + "' and matkhau='" + pw + "'";
                    textBoxPassWord.Clear();
                    SqlCommand com = new SqlCommand(query, connect);
                    SqlDataReader rd = com.ExecuteReader();

                    if (rd.Read() == true)
                    {
                        //thành công
                        FormMain fm = new FormMain();
                        this.Hide();
                        fm.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                    }
                }
                
                connect.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Không thể kết nối");
            }
            

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát?","Thông báo!", MessageBoxButtons.OKCancel)!=System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }    
        }
    }
}
