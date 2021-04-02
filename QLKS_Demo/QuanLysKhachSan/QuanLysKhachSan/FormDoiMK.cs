using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLysKhachSan
{
    public partial class FormDoiMK : Form
    {
        public FormDoiMK()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonThayDoi_Click(object sender, EventArgs e)
        {
            DataTable da = DataExcute.Instance.ExecuteQuery("select matkhau from usertable where taikhoan='admin'");
            DataRow dar = da.Rows[0];
            string mkc = dar["matkhau"].ToString();
            MessageBox.Show(mkc);
            if (textBoxMK.Text != "" && textBoxMKcu.Text != "" && textBoxMKmoi.Text != "")
            {
               // if()
            }
            else MessageBox.Show("Hãy nhập đủ thông tin"); 
        }
    }
}
