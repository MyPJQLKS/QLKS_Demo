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

namespace QuanLysKhachSan
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            panel4.Visible = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if(panel4.Visible==true)
            {
                using (SqlConnection connect = new SqlConnection(SqlStringConnect.stringConnect))
                {
                    try
                    {
                        if(textBoxPassWord.Text==textBox1.Text)
                        {
                            connect.Open();
                            string que = "Insert into UserTable(taikhoan, matkhau, manv) values('" + textBoxUserName.Text + "', '" + textBoxPassWord.Text + "',NULL)";
                            SqlCommand com = new SqlCommand(que, connect);
                            int rez = com.ExecuteNonQuery();
                            if (rez > 0)
                            {
                                //thành công
                                MessageBox.Show("Thành công!\r\n Hãy nhập tài khoản và đăng nhập");
                                panel4.Visible = false;
                            }
                            connect.Close();
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không trùng nhau");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Tài khoản đã tồn tại!!");
                    }
                }
            }
            else
            {
                MessageBox.Show("A");
                panel4.Visible = true;
            } 
            
        }

        public bool ktMK(string pw)
        {
            int i = 0;
            foreach (char item in pw)
            {
                if (item == '-') i++; 
            }
            if (i > 0) return false;
            return true;
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            using(SqlConnection connec= new SqlConnection(SqlStringConnect.stringConnect))
            {
                try
                {
                    string tk = textBoxUserName.Text;
                    string mk = textBoxPassWord.Text;
                    string query="";
                    if (ktMK(mk))
                    {
                        query = "select * from usertable where taikhoan = '" + tk + "' and matkhau = '" + mk + "'";
                        connec.Open();
                        textBoxPassWord.Clear();
                        SqlCommand com = new SqlCommand(query, connec);
                        SqlDataReader dta = com.ExecuteReader();
                        if (dta.Read())
                        {
                            //thành công
                            FormMain fm = new FormMain();
                            this.Hide();
                            fm.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản hoặc mật khảu không chính xác");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Exception!");
                    }
                    
                    connec.Close();
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
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
