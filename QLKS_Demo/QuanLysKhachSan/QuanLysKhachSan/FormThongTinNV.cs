using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLysKhachSan
{
    public partial class FormThongTinNV : Form
    {
        public string tenTK;
        public string maNV;
        public FormThongTinNV(string tenTK)
        {
            InitializeComponent();
            this.tenTK = tenTK;
            label1.Text = tenTK;
            load();
            loadUser();
        }
        #region Load
        void loadUser()
        {
            DataTable data = new DataTable();
            data = DataExcute.Instance.ExecuteQuery("Select manv from usertable where taikhoan='"+tenTK+"'");
            if(data.Rows.Count>0)
            {
                maNV = data.Rows[0]["manv"].ToString();
            }
            if(maNV=="")
            {
                MessageBox.Show("Hãy thêm mã nhân viên của bạn");
                textBox1.Enabled = true;
            }else
            {
                DataTable da = new DataTable();
                da = DataExcute.Instance.ExecuteQuery("Select * from nhanvien where manv='" + maNV + "'");
                if(da.Rows.Count>0)
                {
                    DataRow dataRow = da.Rows[0];
                    textBox1.Text = dataRow["manv"].ToString();
                    textBox2.Text = dataRow["tennv"].ToString();
                    textBox3.Text = dataRow["quequan"].ToString();
                    Double db = Convert.ToDouble(dataRow["luong"].ToString());
                    textBox4.Text = db.ToString();
                    DateTime date = Convert.ToDateTime(dataRow["ngaysinh"]);
                    textBox5.Text = date.ToString("MM/dd/yyyy");
                }    
            }    
            
        }
        void load()
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
        }
        #endregion
        #region Event
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox3.Enabled = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textBox4.Enabled = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            textBox5.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data = DataExcute.Instance.ExecuteQuery("Select * from nhanvien where manv='" + textBox1.Text + "'");
            if(data.Rows.Count>0)
            {
                DataRow dataRow = data.Rows[0];
                textBox2.Text = dataRow["tennv"].ToString();
                textBox3.Text = dataRow["quequan"].ToString();
                Double db = Convert.ToDouble(dataRow["luong"].ToString());
                textBox4.Text = db.ToString();
                DateTime date = Convert.ToDateTime(dataRow["ngaysinh"]);
                textBox5.Text = date.ToString("MM/dd/yyyy");
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataExcute.Instance.ExecuteNonQuery("Update usertable set manv='" + textBox1.Text + "' where taikhoan='" + label1.Text + "'");
            int rez = DataExcute.Instance.ExecuteNonQuery("Update nhanvien set manv='"+textBox1.Text+"', tennv='" + textBox2.Text + "', ngaysinh='" + textBox5.Text + "', quequan='" + textBox3.Text + "', luong=" + textBox4.Text + " where manv in (Select nv.manv from nhanvien nv, usertable us where nv.manv=us.manv and us.taikhoan='"+label1.Text+"')");
            if(rez>0)
            {
                this.Close();
                MessageBox.Show("Sửa thành công");
            }    
            else
            {
                MessageBox.Show("Sửa thông tin thất bại");
            }    
        }
    }
}
