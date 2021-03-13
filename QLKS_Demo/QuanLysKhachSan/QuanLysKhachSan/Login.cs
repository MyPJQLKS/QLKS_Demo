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
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            using(SqlConnection connec= new SqlConnection(SqlStringConnect.stringConnect))
            {
                try
                {
                    string tk = textBoxUserName.Text;
                    string mk = textBoxPassWord.Text;
                    connec.Open();
                    
                    string query = "select * from usertable where taikhoan = '"+tk+"' and matkhau = '"+mk+"'";
                    textBoxPassWord.Clear();
                    SqlCommand com = new SqlCommand(query, connec);
                    SqlDataReader dta = com.ExecuteReader();
                    if(dta.Read())
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
